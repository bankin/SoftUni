using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompanyInformation
{
    class CompanyInformation
    {
        static void Main(string[] args)
        {
            string companyName;
            string companyAddress;
            string phoneNumber;
            string faxNumber;
            string website;
            string managerFirstName;
            string managerLastName;
            int managerAge;
            string managerPhoneNumber;

            Console.Write("Insert company name: ");
            companyName = Console.ReadLine();
            Console.Write("Insert company address: ");
            companyAddress = Console.ReadLine();
            Console.Write("Insert company phone number: ");
            phoneNumber = Console.ReadLine();
            Console.Write("Insert company fax number: ");
            faxNumber = Console.ReadLine();
            Console.Write("Insert company website: ");
            website = Console.ReadLine();
            Console.Write("Insert manager first name: ");
            managerFirstName = Console.ReadLine();
            Console.Write("Insert manager last name: ");
            managerLastName = Console.ReadLine();
            Console.Write("Insert manager age: ");
            managerAge = int.Parse(Console.ReadLine());
            Console.Write("Insert manager phone number: ");
            managerPhoneNumber = Console.ReadLine();

            Console.WriteLine("Company info");
            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + companyAddress);
            Console.WriteLine("Tel. " + phoneNumber == "\n" ? "(no phone)" : phoneNumber);
            Console.WriteLine("Fax: " + faxNumber == "\n" ? "(no fax)" : faxNumber);
            Console.WriteLine("Web site: " + website);
            Console.WriteLine("Manager: " + managerFirstName + " " + managerLastName + "(age: " + managerAge + ", tel." + managerPhoneNumber + ")");
        }
    }
}
