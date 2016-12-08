using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    /// <summary>
    /// This is the Contacts class used to create a contact.
    /// </summary>
    /// 
    class Contacts
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string addressLine1;

        public string AddressLine1
        {
            get { return addressLine1; }
            set { addressLine1 = value; }
        }
        private string addressLine2;

        public string AddressLine2
        {
            get { return addressLine2; }
            set { addressLine2 = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }
        private int zip;

        public int Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        public Contacts()
        {

        }

    }
}
