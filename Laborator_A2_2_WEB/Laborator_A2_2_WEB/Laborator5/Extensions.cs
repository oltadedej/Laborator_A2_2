using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Laborator_A2_2_WEB.Laborator5
{
    public static class Extensions
    {
        /// <summary>
        /// Function is used to encrypt the password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string Encryptdata(string password)
        {
            string strmsg = string.Empty;
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            strmsg = Convert.ToBase64String(encode);
            return strmsg;
        }


    }
}