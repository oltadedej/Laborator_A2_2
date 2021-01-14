using Laborator_A2_2_WEB.Laborator3.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_2_WEB.Laborator3
{
    public partial class Afshisho : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string idToShow = Request.QueryString["IdPhoneBook"];
                if (!String.IsNullOrEmpty(idToShow))
                {
                    int id = Convert.ToInt32(idToShow);

                    Configuration con = new Configuration();
                    PhoneBook phoneBookToShow = con.phoneBooks.Where(i => i.PhoneBookId == id).FirstOrDefault();

                    //kushti where zevendeson ciklin foreach per te gjetur nje element
                    //foreach(var item in con.phoneBooks)
                    //{
                    //    if (item.PhoneBookId == id)
                    //    {
                    //        //behet afishimi
                    //    }
                    //}

                    if (phoneBookToShow != null)
                    {
                        //bej afishimin

                        phoneBookName.Text = phoneBookToShow.PhoneBookPersonName;
                        phoneBookNumer.Text = phoneBookToShow.PhoneBookNumber;

                        // ndryshi njihet si rregulli ternar   kusht if  ?     kusht else eshte :
                        phoneBookType.Text = phoneBookToShow.PhoneType==1 ?"Celular" : phoneBookToShow.PhoneType==2?"Work":"Home";

                    }

                }
            }

        }
    }
}