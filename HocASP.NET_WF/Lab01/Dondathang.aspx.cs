using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab01
{
    public partial class Dondathang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text=="")
            {
                lbLoi.Text = "chưa nhập số lượng";
                return;
            }
            lbLoi.Text = "";
            //Thêm tên bánh và số lượng vào lstBanh
            lstBanh.Items.Add(ddlBanh.SelectedItem.Text + "(" + txtSoLuong.Text + ")");
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            //duyệt các mục được chọn trong lstBanh và xóa đi
            for (int i =lstBanh.Items.Count - 1; i >= 0; i--)
            {
                if (lstBanh.Items[i].Selected)//nếu mục thứ i đc chọn
                {
                    //xóa khỏi lstBanh
                    lstBanh.Items.RemoveAt(i);
                }
                    
            }
        }

        protected void btnInhoadon_Click(object sender, EventArgs e)
        {
            //b1 thu thập thông tin đơn hàng từ client
            string ketqua = "";
            ketqua += "<h2>HÓA ĐƠN ĐẶT HÀNG </h2>";
            //lấy thông tin khách hàng
            ketqua += "Khách hàng :<i>" + txtHoten.Text + "</i><br>";
            ketqua += "Địa chỉ :<i>" + txtDiachi.Text + "</i><br>";
            ketqua += "Mã số thuế :<i>" + txtMasothue.Text + "</i><br>";
            //lấy thông tin bánh đặt
            ketqua += "Đặt các loại bánh sau: <br>";
            ketqua += "<table border=1 witdh=100%>";
            char[] strSep = { '(', ')' };
            foreach(ListItem x in lstBanh.Items)
            {
                string[] strArr = x.Text.Split(strSep);
                ketqua += string.Format("<tr><td>{0}</td><td>{1}</td></tr>", strArr[0], strArr[1]);

            }
            ketqua += "<table>";
            //b2. gửi thông tin đơn hàng cho client
            lbThongtin.Text = ketqua;
        }
    }
}