using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceConsumer
{
    public partial class WebFormServiceConsumer : System.Web.UI.Page
    {
        private localhost.WebServiceHelloWorld myWs;

        protected void Page_Load(object sender, EventArgs e)
        {
            myWs = new localhost.WebServiceHelloWorld();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.lbl_hello_world.Text = myWs.HelloWorld();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }

        protected void btn_hello_name_Click(object sender, EventArgs e)
        {
            this.lbl_hello_name.Text = myWs.Hello(this.txt_name.Text);
        }

        protected void Button1_Click2(object sender, EventArgs e)
        {
            int p1 = int.Parse(this.txt_p1.Text);
            int p2 = int.Parse(this.txt_p2.Text);
            this.lbl_add.Text = myWs.Add(p1, p2).ToString();
        }
    }
}