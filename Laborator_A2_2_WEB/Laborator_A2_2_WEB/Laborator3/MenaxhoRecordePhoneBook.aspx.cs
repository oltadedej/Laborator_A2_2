using Laborator_A2_2_WEB.Laborator3.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_2_WEB.Laborator3
{
    public partial class MenaxhoRecordePhoneBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //hera e pare qe ngarkohet faqja 
            if (!Page.IsPostBack)
            {
                Configuration con = new Configuration();
                // veprime me lista  -- LINQ 
                con.phoneBooks.Select(i => i).ToList();// i ngjashem me select * from emertabele ne sql
                con.phoneBooks.Where(i => i.PhoneBookId == 1).FirstOrDefault();// select * from emeertabele where id=1 ne sql
                con.phoneBooks.Any(i => i.PhoneBookId == 1); //tregon nese ekziston nje element ne list -->  select count (id) from emertabele

                ddl.DataSource = con.phoneBooks; // i kalojme automatikisht si burim te dhenash gjithe listen e objekteve
                ddl.DataTextField = "PhoneBookPersonName"; //me shfaq si tekst te itemit phonebookpersonname
                ddl.DataValueField = "PhoneBookId"; // i kalojne si vlere vleerat e idphonebook nga lista

                ddl.DataBind(); // shfaqet burimi i te dhenave ne web 



            }
        }

        protected void shto_Click(object sender, EventArgs e)
        {

            Configuration con = new Configuration();
            PhoneBook item = new PhoneBook();


            if (!String.IsNullOrEmpty(txtPersonName.Text.Trim()))
            {
                item.PhoneBookPersonName = txtPersonName.Text.Trim();
            }
            if (!String.IsNullOrEmpty(txtPhoneBookNumber.Text.Trim()))
            {
                item.PhoneBookNumber = txtPhoneBookNumber.Text.Trim();
            }

            if (!String.IsNullOrEmpty(rdlPhoneType.SelectedValue.Trim()))
            {
                item.PhoneType = Convert.ToInt32(rdlPhoneType.SelectedValue.Trim());
            }

            item.PhoneBookId = con.phoneBooks.Count() + 1;

            con.phoneBooks.Add(item);
            ddl.DataSource = con.phoneBooks;
            ddl.DataTextField = "PhoneBookPersonName";
              ddl.DataValueField = "PhoneBookId";
            ddl.DataBind(); 




        }
    }
}