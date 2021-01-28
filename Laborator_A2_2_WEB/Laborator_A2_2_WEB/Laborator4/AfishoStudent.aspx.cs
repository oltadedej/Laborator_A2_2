using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_2_WEB.Laborator4
{
    public partial class AfishoStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int std = Convert.ToInt32(Request.QueryString["idStudent"]);
                using (University_LaboratorEntities dbcontext = new University_LaboratorEntities())
                {
                    Student stdudent_ = dbcontext.Students.ToList().Where(i => i.StudentId == std).FirstOrDefault();
                    lblName.Text = stdudent_.Emer;
                    lblSurname.Text = stdudent_.Mbiemer;
                    lblEnrollmentDate.Text = stdudent_.EnrollmentDate.ToString("dd/MM/yyyy");



                }
            }

        }
    }
}