using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab01
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btcong_Click(object sender, EventArgs e)
        {
            //Cong
            double so1 = double.Parse(txtso1.Text);
            double so2 = double.Parse(txtso2.Text);

            double kq = so1 + so2;

            txtkq.Text = kq.ToString();
            
        }

        protected void bttru_Click(object sender, EventArgs e)
        {
            double so1 = double.Parse(txtso1.Text);
            double so2 = double.Parse(txtso2.Text);

            double kq = so1 - so2;

            txtkq.Text = kq.ToString();
        }

        protected void btnhan_Click(object sender, EventArgs e)
        {
            double so1 = double.Parse(txtso1.Text);
            double so2 = double.Parse(txtso2.Text);

            double kq = so1 * so2;

            txtkq.Text = kq.ToString();
        }

        protected void btchia_Click(object sender, EventArgs e)
        {
            double so1 = double.Parse(txtso1.Text);
            double so2 = double.Parse(txtso2.Text);

            double kq = so1 / so2;

            txtkq.Text = kq.ToString();
        }
    }
}