using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laborator_A2_2_WEB.Laborator3.Domain
{
    public class Configuration
    {
        public List<PhoneBook> phoneBooks { get; set; } = new List<PhoneBook>(); //thenia me vlere direkt listes

        public Configuration()
        {
            PhoneBook item = new PhoneBook();
            item.PhoneBookId = 1;
            item.PhoneBookPersonName = "test1";
            item.PhoneBookNumber = "+3548965211";
            item.PhoneType = 1;

            phoneBooks.Add(item);

            item = new PhoneBook();
            item.PhoneBookId = 2;
            item.PhoneBookPersonName = "test2";
            item.PhoneBookNumber = "54789625";
            item.PhoneType = 2;
            phoneBooks.Add(item);
        }
    
    }
}

