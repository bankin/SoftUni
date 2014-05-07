using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input your 4-digit number: ");
                int number = int.Parse(Console.ReadLine());
                if (number < 1000 || number > 9999)
                {
                    Console.WriteLine("This is not a 4-digit number");
                }
                char[] arr = number.ToString().ToCharArray();
                char[] arr2 = number.ToString().ToCharArray();
                string num = "";
                int sum = 0;
                for (int i = 0; i < 4; i++)
                {
                    sum += number % 10;
                    num += number % 10;
                    number /= 10;
                }
               
                Console.WriteLine("The sum of the digits is "+sum);
                Console.WriteLine("The number inversed is "+num);
                char ch = arr[3];
                arr[3] = arr[2];
                arr[2] = arr[1];
                arr[1] = arr[0];
                arr[0] = ch;
                Console.WriteLine("The last digit infront " + (new string(arr)));
                ch = arr2[1];
                arr2[1] = arr2[2];
                arr2[2] = ch;
                Console.WriteLine("The second and third digits exchanged " + (new string(arr2)));
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("This is not a number");
            }
        }
    }
}
