using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_2_WEB.Laborator2
{
    public partial class Ushtrimi2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Olta Dedej";
            CheckBox1.Checked = true;
            AfishimMesazhi.Text = "Pershendetje:" + Label1.Text + " Gjinia juaj eshte:" + CheckBox1.Text + " Data e sotme eshte:" + DateTime.Now.ToString("MM/dd/yyyy");
          //  AfishimMesazhi.Text = $"Pershendetje:{Label1.Text}  Gjinia juaj eshte {CheckBox1.Text}  Data  e sotme eshte: {DateTime.Now.ToString("dd/MM/yyyy")}";


        }
    }
}