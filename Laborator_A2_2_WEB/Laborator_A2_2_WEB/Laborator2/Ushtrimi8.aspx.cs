using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_2_WEB.Laborator2
{
    public partial class Ushtrimi8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)

        {
            

            Label1.Text = string.Empty;
            if (!string.IsNullOrEmpty(TextBox1.Text))
            {
                if (TextBox1.Text.Contains(" "))
                {
                    var array = TextBox1.Text.Split(' ');
                    Label1.Text = "Nr i fjaleve eshte" + array.Length;

                }



            }
        }
    }
}

