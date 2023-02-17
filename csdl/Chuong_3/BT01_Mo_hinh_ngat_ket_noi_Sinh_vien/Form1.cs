using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //Su dung voi access

namespace BT01_Mo_hinh_ngat_ket_noi_Sinh_vien
{
    public partial class Form1 : Form
    {
        //Khai bao cac doi tuong can su dung
        //1.1 Chuoi ket noi
        string strcon = @"provider=microsoft.jet.oledb.4.0; data source=..\..\..\Data\QLSINHVIEN.mdb";

        //1.2 Khai bao cac doi tuong luu tru du lieu
        DataSet ds = new DataSet();

        //1.3 Khai bao cac DataAdapter su dung voi nguyen tac: 1 DataTable tuong ung voi 1 DataAdapter
        OleDbDataAdapter adpKhoa, adpSinhvien, adpKetqua;

        //1.4 Khai bao doi tuong CommandBuilder tuong ung de cap nhat du lieu cho bang SINHVIEN.
        //Luu y: Chi khai bao CommandBuilder cho doi tuong bang can cap nhat.
        OleDbCommandBuilder cmbSinhvien;
        int stt = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Khoi_tao_Doi_tuong();
            Doc_Du_lieu();
            Moc_noi_quan_he();
            Khoi_Tao_Combobox_Khoa();
            stt = 0;
            Gan_Du_lieu(stt);

        }

        private void Gan_Du_lieu(int stt)
        {
            //Lay dong du lieu thu stt trong tblSinhVien
            DataRow rsv = ds.Tables["SINHVIEN"].Rows[stt];
            txtmasv.Text = rsv["MaSV"].ToString();
            txthosv.Text = rsv["HoSV"].ToString();
            txttensv.Text = rsv["TenSV"].ToString();
            chkphai.Checked = (Boolean)rsv["Phai"];
            dtpngaysinh.Value = (DateTime)rsv["NgaySinh"];
            txtnoisinh.Text = rsv["NoiSinh"].ToString();
            cbokhoa.SelectedValue = rsv["MaKH"].ToString();
            txthocbong.Text = rsv["HocBong"].ToString();
            
            //Tính tổng điểm trong bảng tblketqua của sinhvien đó
            txttongdiem.Text = Tong_diem(txtmasv.Text).ToString();

            //Hiện thị số thứ tự mẫu tin hiện hành
            lblSTT.Text = (stt + 1) + "/" + (ds.Tables["SINHVIEN"].Rows.Count);
        }

        private object Tong_diem(string msv)
        {
            double kq = 0;
            object td = ds.Tables["KETQUA"].Compute("sum(Diem)", "MaSV='" + msv + "'");
            //luu y : truong hop sinh vien khong co diem thi phuong thuc compute tra ve gia tri DBNull
            if (td == DBNull.Value)
                kq = 0;
            else
                kq = Convert.ToDouble(td);
            return kq;
        }

        private void Khoi_Tao_Combobox_Khoa()
        {
            cbokhoa.DataSource = ds.Tables["KHOA"];
            cbokhoa.DisplayMember = "TenKH";
            cbokhoa.ValueMember ="MaKH" ;
        }

        private void Moc_noi_quan_he()
        {
            // Tạo mối quan hệ giữa tblkhoa và tblsinhvien
            ds.Relations.Add("FK_KH_SV", ds.Tables["KHOA"].Columns["MaKH"], ds.Tables["SINHVIEN"].Columns["MaKH"], true);

            //Tạo mối quan hệ giữa tblsinhvien và tblketqua
            ds.Relations.Add("FK_SV_KQ", ds.Tables["SINHVIEN"].Columns["MaSV"], ds.Tables["KETQUA"].Columns["MasV"], true);

            //Loại bỏ Cascade delete trong mối quan hệ
            ds.Relations["FK_KH_SV"].ChildKeyConstraint.DeleteRule = Rule.None;
            ds.Relations["FK_SV_KQ"].ChildKeyConstraint.DeleteRule = Rule.None;
        }

        private void Doc_Du_lieu()
        {
            //1. Doc du lieu cua bang KHOA
            //1.1 Sao chep cau truc cua table KHOA vao DataTable trong Dataset ds
            adpKhoa.FillSchema(ds, SchemaType.Source, "KHOA");
            //1.2 Sao chep du lieu cua table KHOA vao DataTable trong Dataset ds
            adpKhoa.Fill(ds, "KHOA");

            //2. Doc du lieu cho bang SINHVIEN
            adpSinhvien.FillSchema(ds, SchemaType.Source, "SINHVIEN");
            adpSinhvien.Fill(ds, "SINHVIEN");

            //3. Doc du lieu cho bang KETQUA
            adpKetqua.FillSchema(ds, SchemaType.Source, "KETQUA");
            adpKetqua.Fill(ds, "KETQUA");
        }

        private void Khoi_tao_Doi_tuong()
        {
            //1. Khoi tao cac doi tuong DataAdapter
            adpKhoa = new OleDbDataAdapter("select * from khoa", strcon);
            adpSinhvien = new OleDbDataAdapter("select * from sinhvien", strcon);
            adpKetqua = new OleDbDataAdapter("select * from ketqua", strcon);

            //2.Khoi tao doi tuong Commanbuilder
            cmbSinhvien = new OleDbCommandBuilder(adpSinhvien);
        }
        private void btntruoc_Click(object sender, EventArgs e)
        {
            stt--;
            Gan_Du_lieu(stt);
        }

        private void btnsau_Click(object sender, EventArgs e)
        {
            stt++;
            Gan_Du_lieu(stt);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmasv.ReadOnly = false;
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                    (ctl as TextBox).Clear();
                else if (ctl is CheckBox)
                    (ctl as CheckBox).Checked = true;
                else if (ctl is ComboBox)
                    (ctl as ComboBox).SelectedIndex = 0;
                else if (ctl is DateTimePicker)
                    (ctl as DateTimePicker).Value = new DateTime(2005, 1, 1);

            }
            txtmasv.Focus();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            //Xác định dòng cần hủy ==> sử dụng hàm Find tìm theo khóa chính của Datatable
            DataRow rsv = ds.Tables["SINHVIEN"].Rows.Find(txtmasv.Text);
            //Cần kiểm tra: Nếu bảng tblsinhvien có tồn tại những dòng liên quan trong bảng tblketqua thì không cho xóa
            //ngược lại thì xóa những sinh viên không có dòng liên quan đến bảng tblketqua
            //Sử dụng hàm Getchilrow để kiểm tra những dòng có liên quan trong bảng tblketqua ? giá trị trả về của hàm này là một mảng
            DataRow[] Mang_dong_lien_quan = rsv.GetChildRows("FK_SV_KQ");
            if (Mang_dong_lien_quan.Length > 0)
                MessageBox.Show("Không xóa được do tồn tại những dòng liên quan tblketqua");
            else
            {
                //xoa trong datatable
                rsv.Delete();
                //xoa trong csdl
                int n = adpSinhvien.Update(ds, "SINHVIEN");
                if (n>0)
                    MessageBox.Show("Huy sinh vien thanh cong");
                stt = 0;
                Gan_Du_lieu(stt);
            }
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            if (txtmasv.ReadOnly == true)//ghi sau khi sửa
            {
                //Xác định dòng cần sửa
                DataRow rsv = ds.Tables["SINHVIEN"].Rows.Find(txtmasv.Text);
                //tiến hành sửa
                rsv["HoSV"] = txthosv.Text;
                rsv["TenSV"] = txttensv.Text;
                rsv["Phai"] = chkphai.Checked;
                rsv["NgaySinh"] = dtpngaysinh.Value;
                rsv["NoiSinh"] = txtnoisinh.Text;
                rsv["MaKH"] = cbokhoa.SelectedValue.ToString();
                rsv["HocBong"] = txthocbong.Text;
            }
            else //ghi sau khi thêm mới
            {
                //kiểm tra khóa chính có trùng hay không>?
                DataRow rsv = ds.Tables["SINHVIEN"].Rows.Find(txtmasv.Text);
                if (rsv != null)//đã trùng khóa chính
                {
                    MessageBox.Show("Trùng khóa chính. Nhập lại mã sv");
                    txtmasv.Focus();
                    return;
                }
                //tạo mới sinh viên
                rsv = ds.Tables["SINHVIEN"].NewRow();
                rsv["MaSV"] = txtmasv.Text;
                rsv["HoSV"] = txthosv.Text;
                rsv["TenSV"] = txttensv.Text;
                rsv["Phai"] = chkphai.Checked;
                rsv["NgaySinh"] = dtpngaysinh.Value;
                rsv["NoiSinh"] = txtnoisinh.Text;
                rsv["MaKH"] = cbokhoa.SelectedValue.ToString();
                rsv["HocBong"] = txthocbong.Text;
                ds.Tables["SINHVIEN"].Rows.Add(rsv);
                txtmasv.ReadOnly = true;
            }
            int n = adpSinhvien.Update(ds, "SINHVIEN");
            if (n > 0)
                MessageBox.Show("Cap nhat sinh vien thanh cong");
        }

        private void btnkhong_Click(object sender, EventArgs e)
        {
            Gan_Du_lieu(stt);
        }
    }
}
