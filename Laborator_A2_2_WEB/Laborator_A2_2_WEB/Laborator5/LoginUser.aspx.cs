using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_2_WEB.Laborator5
{
    public partial class LoginUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                User user = null;
                using(University_LaboratorEntities dbcontext = new University_LaboratorEntities())
                {
                    if (!String.IsNullOrEmpty(txtEmail.Text))
                    {
                        if (!dbcontext.Users.ToList().Any(i => i.Email.Equals(txtEmail.Text)))
                        {
                            lblMessazhe.Text = "Emaili nuk ekziston ne databaze";
                            return;
                        }

                        user = dbcontext.Users.ToList().Find(i => i.Email.Equals(txtEmail.Text));
                        if (user != null)
                        {

                            //logojme userin ne sistem
                            //bej hashimin e pasw qe ka vendosur perdoruesi tek forma e loginit
                            string hashPassword = Extensions.Encryptdata(txtPassword.Text);
                            //passw nk perputhen
                            if (!hashPassword.Equals(user.Password)){
                                lblMessazhe.Text = "Password i gabuar";
                                return;
                            }


                            // save user into session

                            Session["User"] = user;


                            //useri ekziston, email dhe passw i sakte
                            Response.Redirect("~/Laborator4/Students.aspx");
                        }



                    }
                }
            }
        }
    }
}