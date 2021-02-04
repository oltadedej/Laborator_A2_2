using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_2_WEB.Laborator5
{
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                using (University_LaboratorEntities dbcontext = new University_LaboratorEntities())
                {
                    User userttoAdd = new User();
                    if (!String.IsNullOrEmpty(txtName.Text)) userttoAdd.Name = txtName.Text;
                    if (!String.IsNullOrEmpty(txtSurname.Text)) userttoAdd.Surname = txtSurname.Text;
                    if (!String.IsNullOrEmpty(txtEmail.Text)) userttoAdd.Email = txtEmail.Text;
                    if (!String.IsNullOrEmpty(txtBirthday.Text)) userttoAdd.Birthday = DateTime.ParseExact(txtBirthday.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    if (!String.IsNullOrEmpty(txtPassword.Text))
                    {
                        userttoAdd.Password = Extensions.Encryptdata(txtPassword.Text);
                        
                    }

                    dbcontext.Users.Add(userttoAdd);
                    dbcontext.SaveChanges();
                }
                txtName.Text = string.Empty;
                txtSurname.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtBirthday.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtCOnfirm.Text = string.Empty;



            }




        }
    }
}