using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ContactDetails
{
     public class Contacts
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public string Phonenumber { get; set; }

        public string Email { get; set; }

        public Contacts(string firstname,string lastname,string address,string city,string state,string zip,string phonenumber,string email)
        {
            Firstname = firstname;
             Lastname=lastname;
             Address=address;
             City=city;
             State=state;
             Zip = zip; 
             Phonenumber=phonenumber;
             Email=email;

        }

         
    }
}
