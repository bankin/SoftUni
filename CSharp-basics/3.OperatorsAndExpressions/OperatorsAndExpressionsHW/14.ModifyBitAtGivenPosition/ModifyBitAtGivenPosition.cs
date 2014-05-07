using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ModifyBitAtGivenPosition
{
    class ModifyBitAtGivenPosition
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input your number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Please input the position: ");
                int position = int.Parse(Console.ReadLine());
                Console.Write("Please input the value: ");
                int value = int.Parse(Console.ReadLine());

                if(value == 1){
                    int mask = 1 << position;
                    number |= mask;

                }
                else if(value == 0)
                {
                    int mask = ~(1 << position);
                    number &= mask;
                }
                else
                { 
                    Console.WriteLine("Wrong value"); 
                    return; 
                }

                Console.WriteLine("The result is "+number);
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("This is not a number");
            }
        }
    }
}
