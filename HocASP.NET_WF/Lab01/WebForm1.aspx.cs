using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab01
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnXuly_Click(object sender, EventArgs e)
        {
            //bổ sung code xử lý upload tập tin
            if (FUpload.HasFile) //người dùng có chọn tập tin cần upload
            {
                //lấy đường dẫn để lưu tập trên server
                string path = Server.MapPath("~/UpLoad/") + FUpload.FileName;
                //thực hiện up
                FUpload.SaveAs(path);
                lbThongbao.Text = "Upload thành công";
            }
            else
            {
                lbThongbao.Text = "Bạn chưa chọn tập tin để upload";
            }
        }
    }
}