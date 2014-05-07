using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PlayWithTypes
{
    class PlayWithTypes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:\n1 --> int \n2 --> double \n3 --> string");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                case 2: 
                    double num = double.Parse(Console.ReadLine());
                    Console.WriteLine(num + 1); 
                    break;
                case 3: 
                    string text = Console.ReadLine();
                    Console.WriteLine(text+"*");
                    break;
                default: Console.WriteLine("Invalid option"); break;
            }
        }
    }
}
