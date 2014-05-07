using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    string word = (char)((int)'a'+i) + "";
                    word += "" + (char)((int)'a' + j + i);
                    word += "" + (char)((int)'a' + i);
                    Console.Write(word + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
