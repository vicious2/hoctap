using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab01
{
    public partial class Thongtincanhan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btDangky_Click(object sender, EventArgs e)
        {
            string kq = "";
            kq += "<h3>Thông tin về bạn:</h3>";
            kq += "<ul>";
            //Lấy thông tin từ client
            //họ tên
            kq += "<li>Họ tên: " + txtTen.Text + "</li>";
            //giới tính
            if (rdtNam.Checked)
                kq += "<li>Giới tính: " + rdtNam.Text + "</li>";
            else
                kq += "<li>Giới tính: " + rdtNu.Text + "</li>";
            //ngoại ngữ
            if (chkAnhvan.Checked)
                kq += "<li>Ngoại ngữ: " + chkAnhvan.Text + "</li>";
            else
                kq += "<li>Ngoại ngữ: " + chkPhapvan.Text + "</li>";
            //thu  nhập
            if (RdtThunhapA.Checked)
                kq += "<li>Thu nhập: " + RdtThunhapA.Text + "</li>";
            else if (RdtThunhapB.Checked)
                kq += "<li>Thu nhập: " + RdtThunhapB.Text + "</li>";
            else
                kq += "<li>Thu nhập: " + RdtThunhapC.Text + "</li>";
            //trình độ
            kq += "<li>Trình độ: " + rdtTrinhdo.SelectedValue + "</li>";
            //....tu code lay
            kq += "</ul>";
            //gui thong tin ket qua ve client
            lbThongtin.Text = kq;
        }
    }
}