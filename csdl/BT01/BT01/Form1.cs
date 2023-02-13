using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace BT01
{
    public partial class Form1 : Form
    {
        //khai báo các đối tượng
        //1.khai báo một biến (đối tượng) dataset
        string strcon = @"provider=microsoft.jet.oledb.4.0; data source=..\..\..\Dât\QLSinhVien.mdb";
        OleDbConnection cnn;
        DataSet ds = new DataSet();
        //2. Khai báo các datatable tương ứng với các bảng có chứa dữ liệu
        DataTable tblKhoa = new DataTable("KHOA");
        DataTable tblSinhVien = new DataTable("SINHVIEN");
        DataTable tblKetQua = new DataTable("KETQUA");
        int stt = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //khởi tạo kết nối
            cnn = new OleDbConnection(strcon);
            //tạo cấu trúc các bảng
            Tao_Cau_truc_cac_bang();
            //Móc nối các quan hệ cho các Datatable
            Moc_noi_Quan_he_Cac_bang();
            //nhập dữ liệu vào các datatable từ tập tin .txt
            Nhap_Lieu_Tu_Tap_Tin_Text();
            //nhập dữ liệu vào các datatable từ các bảng trong CSDL
            //Nhap_Lieu_Tu_CSDL();
            //Khởi tạo combobox
            Khoi_tao_Combobox();
            //Hiển thị dữ liệu stt=0;
            GanDuLieu(stt);

        }

        private void Nhap_Lieu_Tu_Tap_Tin_Text()
        {
            Bang_khoa();
            Bang_sinhvien();
            Bang_ketqua();
        }
        private void Bang_ketqua()
        {
            string[] mang_ketqua = File.ReadAllLines(@"..\..\..\Data\KETQUA.txt");
            foreach (string chuoi_ketqua in mang_ketqua)
            {
                string[] mang_thanh_phan = chuoi_ketqua.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                //Tạo dòng mới datarow
                DataRow rkq = tblKetQua.NewRow();
                for (int i = 0; i < mang_thanh_phan.Length; i++)
                {
                    rkq[i] = mang_thanh_phan[i];
                }
                tblKetQua.Rows.Add(rkq);
            }
        }

        private void Bang_sinhvien()
        {
            string[] mang_sinhvien = File.ReadAllLines(@"..\..\..\Data\SINHVIEN.txt");
            foreach (string chuoi_sinhvien in mang_sinhvien)
            {
                string[] mang_thanh_phan = chuoi_sinhvien.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                //Tạo dòng mới datarow
                DataRow rsv = tblSinhVien.NewRow();
                for (int i = 0; i < mang_thanh_phan.Length; i++)
                {
                    rsv[i] = mang_thanh_phan[i];
                }
                tblSinhVien.Rows.Add(rsv);
            }
        }

        private void Bang_khoa()
        {
            string[] mang_Khoa = File.ReadAllLines(@"..\..\..\Data\KHOA.txt");
            foreach (string chuoi_khoa in mang_Khoa)
            {
                string[] mang_thanh_phan = chuoi_khoa.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                //Tạo một dòng mới có cấu trúc là datarow
                DataRow rkh = tblKhoa.NewRow();
                rkh[0] = mang_thanh_phan[0];
                rkh[1] = mang_thanh_phan[1];
                //Thêm dòng tạo này vào tblkhoa
                tblKhoa.Rows.Add(rkh);
            }
        }

        private void Moc_noi_Quan_he_Cac_bang()
        {
            // Tạo mối quan hệ giữa tblkhoa và tblsinhvien
            ds.Relations.Add("FK_KH_SV", ds.Tables["KHOA"].Columns["MaKH"], ds.Tables["SINHVIEN"].Columns["MaKH"], true);
            //Tạo mối quan hệ giữa tblsinhvien và tblketqua
            ds.Relations.Add("FK_SV_KQ", ds.Tables["SINHVIEN"].Columns["MaSV"], ds.Tables["KETQUA"].Columns["MasV"], true);
            //Loại bỏ Cascade delete trong mối quan hệ
            ds.Relations["FK_KH_SV"].ChildKeyConstraint.DeleteRule = Rule.None;
            ds.Relations["FK_SV_KQ"].ChildKeyConstraint.DeleteRule = Rule.None;
        }

        private void Tao_Cau_truc_cac_bang()
        {
            //Tạo cấu trúc bảng tblkhoa
            tblKhoa.Columns.Add("MaKH", typeof(string));
            tblKhoa.Columns.Add("TenKH", typeof(string));
            //Khóa chính của tblkhoa
            tblKhoa.PrimaryKey = new DataColumn[] { tblKhoa.Columns["MaKH"] };
            //Tạo cấu trúc bảng tblsinhvien
            tblSinhVien.Columns.Add("MaSV", typeof(string));
            tblSinhVien.Columns.Add("HoSV", typeof(string));
            tblSinhVien.Columns.Add("TenSV", typeof(string));
            tblSinhVien.Columns.Add("Phai", typeof(Boolean));
            tblSinhVien.Columns.Add("NgaySinh", typeof(DateTime));
            tblSinhVien.Columns.Add("NoiSinh", typeof(string));
            tblSinhVien.Columns.Add("MaKH", typeof(string));
            tblSinhVien.Columns.Add("HocBong", typeof(double));
            //Khóa cính của tblsinhvien
            tblSinhVien.PrimaryKey = new DataColumn[] { tblSinhVien.Columns["MaSV"] };
            //Tạo cấu trúc bảng tblketqua
            tblKetQua.Columns.Add("MaSV", typeof(string));
            tblKetQua.Columns.Add("MaMH", typeof(string));
            tblKetQua.Columns.Add("Diem", typeof(Single));
            //Khóa chính của tblketqua
            tblKetQua.PrimaryKey = new DataColumn[] { tblKetQua.Columns["MaSV"], tblKetQua.Columns["MaMH"] };
            //Thêm các datatable vào dataset
            /* ds.Tables.Add(tblKhoa);
             ds.Tables.Add(tblSinhvien);
             ds.Tables.Add(tblKetqua);*/
            //Thêm các datatable vào dataset cách 2
            ds.Tables.AddRange(new DataTable[] { tblKhoa, tblKetQua, tblSinhVien });
        }

        private void GanDuLieu(int stt)
        {
            DataRow rsv = tblSinhVien.Rows[stt];
            txtmasv.Text = rsv["MaSV"].ToString();
            txthosv.Text = rsv["HoSV"].ToString();
            txttensv.Text = rsv["TenSV"].ToString();
            chkphai.Checked = (Boolean)rsv["Phai"];
            dtpngaysinh.Value = (DateTime)rsv["NgaySinh"];
            txtnoisinh.Text = rsv["NoiSinh"].ToString();
            cbokhoa.SelectedValue = rsv["MaKH"].ToString();
            txthocbong.Text = rsv["HocBong"].ToString();
            //Hiện thị số thứ tự mẫu tin hiện hành
            lblSTT.Text = (stt + 1) + "/" + (tblSinhVien.Rows.Count);
            //Tính tổng điểm trong bảng tblketqua của sinhvien đó
            txttongdiem.Text = Tongdiem(txtmasv.Text).ToString();
        }
        private double Tongdiem(string msv)
        {
            double kq = 0;
            object td = tblKetQua.Compute("sum(Diem)", "MaSV='" + msv + "'");
            if (td == DBNull.Value)
                kq = 0;
            else
                kq = Convert.ToDouble(td);
            return kq;
        }

        private void Khoi_tao_Combobox()
        {
            cbokhoa.DataSource = tblKhoa;
            cbokhoa.DisplayMember = "TenKH";
            cbokhoa.ValueMember = "MaKH";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ghi tập tin
            //lưu ý: tblSinhVien.Rows => tập hợp dòng (Không phải là mảng)=> chuyển thành mảng => ItemArray(là mảng tương ứng 1 dòng trong dataTable)
            //       để chuyển 1 mảng thành chuỗi => join => thí dụ: có mảng 1,2,3 = dùng join => chuyển thành chuỗi: "1|2|3"
            //thuật toán ghi một datatable vào tập tin
            //1.khai báo một mảng chuỗi với mỗi phần tử sẽ chứa 1 chuỗi tương ứng với 1 dòng trong dataTable
            //2. duyệt qua tập hợp Rows của DataTable và đưa từng dòng vào mảng chuỗi  với hàm join
            //3. sử dụng phương thức WriteAllLines để ghi mảng chuỗi vào tập tin SINHVIEN.txt
            List<string> Mang_chuoi_Sinh_vien = new List<string>();
            foreach (DataRow rsv in tblSinhVien.Rows)
            {

            }
        }

        private void btntruoc_Click(object sender, EventArgs e)
        {
            stt--;
            GanDuLieu(stt);
        }

        private void btnsau_Click(object sender, EventArgs e)
        {
            stt++;
            GanDuLieu(stt);
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
            DataRow rsv = tblSinhVien.Rows.Find(txtmasv.Text);
            //Cần kiểm tra: Nếu bảng tblsinhvien có tồn tại những dòng liên quan trong bảng tblketqua thì không cho xóa
            //ngược lại thì xóa những sinh viên không có dòng liên quan đến bảng tblketqua
            //Sử dụng hàm Getchilrow để kiểm tra những dòng có liên quan trong bảng tblketqua ? giá trị trả về của hàm này là một mảng
            DataRow[] Mang_dong_lien_quan = rsv.GetChildRows("FK_SV_KQ");
            if (Mang_dong_lien_quan.Length > 0)
                MessageBox.Show("Không xóa được do tồn tại những dòng liên quan tblketqua");
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            if (txtmasv.ReadOnly == true)//ghi sau khi sửa
            {
                //Xác định dòng cần sửa
                DataRow rsv = tblSinhVien.Rows.Find(txtmasv.Text);
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
                DataRow rsv = tblSinhVien.Rows.Find(txtmasv.Text);
                if (rsv !=null)//đã trùng khóa chính
                {
                    MessageBox.Show("Trùng khóa chính. Nhập lại mã sv");
                    txtmasv.Focus();
                    return;
                }
                //tạo mới sinh viên
                rsv = tblSinhVien.NewRow();
                rsv["MaSV"] = txtmasv.Text;
                rsv["HoSV"] = txthosv.Text;
                rsv["TenSV"] = txttensv.Text;
                rsv["Phai"] = chkphai.Checked;
                rsv["NgaySinh"] = dtpngaysinh.Value;
                rsv["NoiSinh"] = txtnoisinh.Text;
                rsv["MaKH"] = cbokhoa.SelectedValue.ToString();
                rsv["HocBong"] = txthocbong.Text;
                tblSinhVien.Rows.Add(rsv);
                txtmasv.ReadOnly = true;
            }
        }

        private void btnkhong_Click(object sender, EventArgs e)
        {
            GanDuLieu(stt);
        }
    }
}
