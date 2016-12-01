using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;

            List<Contacts> contacts = new List<Contacts>();
            var person1 = new Contacts("Jose","Cuervo","8395369871");
            var person2 = new Contacts("Jim", "Beam","9573548678");
            contacts.Add(person1);
            contacts.Add(person2);

            Console.WriteLine("~~~~~~~ Address Book ~~~~~~~");
            Console.WriteLine("");
            foreach (Contacts c in contacts)
            {
                Console.WriteLine(index++ + ")  Name: " + c.FirstName + " " + c.LastName + "     Office number: "+ c.OfficePhone);
            }
            Console.ReadKey();

        }
    }
}
