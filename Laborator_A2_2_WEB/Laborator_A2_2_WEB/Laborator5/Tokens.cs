using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laborator_A2_2_WEB.Laborator5
{
    public static class Tokens
    {

        public static User LoggedUser
        {
            get
            {
                if (HttpContext.Current.Session["User"] != null)
                    return (User)HttpContext.Current.Session["User"];

                else return null;
            }

            set
            {
                if (LoggedUser != null)
                {
                    HttpContext.Current.Session["User"] = (User)HttpContext.Current.Session["User"];
                }
            }
        }

        public static List<Authorization> UserAuthorization
        {
            get
            {
                if (HttpContext.Current.Session["UserAuthorization"] == null)
                {
                    using (University_LaboratorEntities dbcontext = new University_LaboratorEntities())
                    {
                        var results = from user_authorz in dbcontext.User_Authorization
                                      join authoriz in dbcontext.Authorizations on user_authorz.AuthorizationId equals authoriz.AuthorizationId

                                      where user_authorz.UserId == LoggedUser.UserId
                                      select authoriz;

                        HttpContext.Current.Session["UserAuthorization"] = results.ToList<Authorization>();
                    }

                }
                return (List<Authorization>)HttpContext.Current.Session["UserAuthorization"];

            }
        }


        //rasti kur keni tabelen user_authorization
        public static bool IsAdmin
        {
            get
            {
                if (UserAuthorization != null)
                {
                    HttpContext.Current.Session["IsAdmin"] = UserAuthorization.Any(i => i.Description.Equals("Admin"));
                }
                return (bool)HttpContext.Current.Session["IsAdmin"];
            }
        }

        //public static bool IsAdminWithRoles
        //{
        //    get
        //    {
        //        if (LoggedUser != null)
        //        {
        //            HttpContext.Current.Session["IsAdmin"] = (bool)LoggedUser.Role;
        //        }
        //        return (bool)HttpContext.Current.Session["IsAdmin"];
        //    }
        //}



    }
}