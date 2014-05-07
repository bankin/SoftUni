using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveSpecialLetters
{
    class FiveSpecialLetters
    {
        static string getUnique(string word)
        {
            char[] input = word.ToCharArray();
            return new String(input.Distinct().ToArray());
            //for (int i = input.Length - 1; i  >= 0; i--)
            //{
            //    for (int k = 0; k < i; k++)
            //    {
            //        if (input[k] == input[i])
            //        {
                        
            //        }
            //    }
            //}
        }

        static void Main(string[] args)
        {
            char[] letters = { 'a', 'b', 'c', 'd', 'e' };
            int[] weight = { 5, -12, 47, 7, -32 };
            bool first = true, wordPrinted = false ;
            //Console.WriteLine(getUnique("bcddc"));
            //Console.WriteLine(getUnique("cadea"));
            //return;

            int rangeStart = int.Parse(Console.ReadLine());
            int rangeEnd = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        for (int l = 0; l < 5; l++)
                        {
                            for (int g = 0; g < 5; g++)
                            {
                                string word = letters[i] + "" +letters[j] + letters[k] + letters[l] + letters[g];
                                string uniqueWord = getUnique(word);

                                int currentWeight = 0;
                                for (int m = 0; m < uniqueWord.Length; m++)
                                {
                                    //Console.WriteLine(new String(letters));
                                    //Console.WriteLine(uniqueWord[m]);
                                    //Console.WriteLine((new String(letters)).IndexOf(uniqueWord[m]));
                                    currentWeight += (m + 1) * weight[(new String(letters)).IndexOf(uniqueWord[m])];
                                    
                                }

                                if (currentWeight >= rangeStart && currentWeight <= rangeEnd)
                                {
                                    wordPrinted = true;
                                    if (first)
                                    {
                                        Console.Write(word);
                                        first = false;
                                    }
                                    else
                                    {
                                        Console.Write(" " + word);
                                    }                                    
                                }
                            }
                        }
                    }
                }
            }

            if (!wordPrinted)
            {
                Console.WriteLine("No");
            }
        }
    }
}
