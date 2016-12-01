using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Contacts
    {
        public List<object> Person { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string OfficePhone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }


        public  Contacts(string firstName, string lastName, string officeNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            OfficePhone = officeNumber;
        }


        public Contacts(string firstName, string lastName, string cellPhone, string officePhone, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            CellPhone = cellPhone;
            OfficePhone = officePhone;
            Email = email;
        }



    }
}
