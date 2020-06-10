using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceConsumer
{
    public partial class WebFormServiceCalculatorConsumer : System.Web.UI.Page
    {

        // tp 6 cant add a reference from other website is on 404 error
        private calculator.Calculator myWs;
        protected void Page_Load(object sender, EventArgs e)
        {
            myWs = new calculator.Calculator();
        }

        protected void btn_divide_Click(object sender, EventArgs e)
        {
            int p1 = int.Parse(this.txt_p1.Text);
            int p2 = int.Parse(this.txt_p2.Text);

            this.lbl_result.Text = this.myWs.Divide(p1, p2).ToString();
        }

        protected void btn_multiply_Click(object sender, EventArgs e)
        {

            int p1 = int.Parse(this.txt_p1.Text);
            int p2 = int.Parse(this.txt_p2.Text);

            this.lbl_result.Text = this.myWs.Multiply(p1, p2).ToString();
        }

        protected void btn_substract_Click(object sender, EventArgs e)
        {
            int p1 = int.Parse(this.txt_p1.Text);
            int p2 = int.Parse(this.txt_p2.Text);

            this.lbl_result.Text = this.myWs.Subtract(p1, p2).ToString();
        }
    }
}