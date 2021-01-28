using Laborator_A2_2_WEB.Laborator3.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_2_WEB.Laborator4
{
    public partial class DSH_Perditeso_Record : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Configuration configuration = new Configuration();

                ddl1.DataSource = configuration.phoneBooks; // si burimi i te dhenave
                ddl1.DataTextField = "PhoneBookPersonName";
                ddl1.DataValueField = "PhoneBookId";
                ddl1.DataBind(); // mundeson qe burimi i te dhenave te shfaqet ne web
            }

        }

        protected void btnModifiko_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ddl1.SelectedValue))
            {

                int idToModify = Convert.ToInt32(ddl1.SelectedValue.Trim());
                Configuration con = new Configuration();
                PhoneBook itemToModify = con.phoneBooks.Where(i => i.PhoneBookId == idToModify).FirstOrDefault();
                if (itemToModify != null)
                {
                    if (!String.IsNullOrEmpty(txtPhoneBookPersonName.Text))
                    {
                        itemToModify.PhoneBookPersonName = txtPhoneBookPersonName.Text;
                    }
                    if (!String.IsNullOrEmpty(txtPhoneNumber.Text))
                    {
                        itemToModify.PhoneBookNumber = txtPhoneNumber.Text;
                    }

                    if (!String.IsNullOrEmpty(rdlPhoneBookType.SelectedValue))
                    {
                        itemToModify.PhoneType = Convert.ToInt32(rdlPhoneBookType.SelectedValue.Trim());
                    }

                    int index = con.phoneBooks.FindIndex(item => item.PhoneBookId == itemToModify.PhoneBookId);
                    con.phoneBooks[index] = itemToModify;
                }
                ddl1.DataSource = con.phoneBooks; // si burimi i te dhenave
                ddl1.DataTextField = "PhoneBookPersonName";
                ddl1.DataValueField = "PhoneBookId";
                ddl1.DataBind(); // mundeson qe burimi i te dhenave te shfaqet ne web

            }



        }
    }
}