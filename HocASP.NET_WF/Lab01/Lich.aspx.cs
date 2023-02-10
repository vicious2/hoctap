﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab01
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void clNgaySinhNhat_SelectionChanged(object sender, EventArgs e)
        {
            //lấy ngày sinh nhật của người dùng chọn
            string ketqua = "";
            DateTime ngaysinhnhat = clNgaySinhNhat.SelectedDate;
            //xét trường hợp để xử lý thông báo
            if (ngaysinhnhat < DateTime.Today)
            {
                ketqua = string.Format("Sinh nhật của bạn đã qua <b>{0}</b> ngày", DateTime.Today.Subtract(ngaysinhnhat).Days);
            }
            else if (ngaysinhnhat > DateTime.Today)
            {
                ketqua = string.Format("Còn <b>{0}</b> ngày nữa mới đến sinh nhật bạn", ngaysinhnhat.Subtract(DateTime.Today).Days);
            }
            else
            {
                ketqua = "<h2>CHÚC MỪNG SINH NHẬT BẠN</h2>";
            }
            //gửi kết quả thông báo về client
            lbThongbao.Text = ketqua;
        }
    }
}