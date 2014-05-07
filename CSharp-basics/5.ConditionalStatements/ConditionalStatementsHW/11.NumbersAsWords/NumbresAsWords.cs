using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumbersAsWords
{
    class NumbersAsWords
    {
        public static string getUnits(string inputString)
        {
            string converted = "Error";

            switch (inputString)
            {
                case "0": converted = "zero"; break;
                case "1": converted = "one"; break;
                case "2": converted = "two"; break;
                case "3": converted = "three"; break;
                case "4": converted = "four"; break;
                case "5": converted = "five"; break;
                case "6": converted = "six"; break;
                case "7": converted = "seven"; break;
                case "8": converted = "eight"; break;
                case "9": converted = "nine"; break;
            }

            return converted;
        }

        public static string getTeens(string inputText)
        {
            string converted = "Error";

            switch (inputText)
            {
                case "10": converted = "ten"; break;
                case "11": converted = "eleven"; break;
                case "12": converted = "twelve"; break;
                case "13": converted = "thirteen"; break;
                case "14": converted = "fourteen"; break;
                case "15": converted = "fifteen"; break;
                case "16": converted = "sixteen"; break;
                case "17": converted = "seventeen"; break;
                case "18": converted = "eighteen"; break;
                case "19": converted = "nineteen"; break;
                case "20": converted = "twenty"; break;
            }

            return converted;
        }

        public static string getWholeTens(char inputText)
        {
            string converted = "Error";

            switch (inputText)
            {
                case '3': converted = "thirty"; break;
                case '4': converted = "fourty"; break;
                case '5': converted = "fifty"; break;
                case '6': converted = "sixty"; break;
                case '7': converted = "seventy"; break;
                case '8': converted = "eighty"; break;
                case '9': converted = "ninety"; break;
            }

            return converted;
        }

        public static string getTens(string inputText)
        {
            string converted = "Error";
            string errorCode = "Error";

            converted = getWholeTens(inputText[0]);
            if (errorCode.Equals(converted))
            {
                return errorCode;
            }

            inputText = char.ToString(inputText[1]);
            converted = converted + " " + getUnits(inputText);
            return converted;
        }

        public static string getHundrets(string inputText)
        {
            string converted = "Error";
            string errorCode = "Error";
            converted = getUnits(char.ToString(inputText[0]));
            if (errorCode.Equals(converted))
            {
                return errorCode;
            }
            converted += " hundred";
            if ('0' == inputText[1])
            {
                if ('0' == inputText[2])
                {
                    return converted;
                }
                else
                {
                    converted += " and " + getUnits(char.ToString(inputText[2]));
                    return converted;
                }
            }
            else if ('2' > converted[1])
            {
                converted += " and ";
            }

            inputText = char.ToString(inputText[1]) + char.ToString(inputText[2]);
            converted += " " + getTens(inputText);

            return converted;
        }

        static void Main(string[] args)
        {
            string inputText = "None";
            string finalText = "None";
            string errorCode = "None";
            //int thirdIntPart;
            //int secondIntPart;
            //int firstIntPart;
            int intValue;
            bool completed = false;

            while (!completed)
            {
                completed = true;
                Console.Write("insert number in the interval [0..999] : ");
                inputText = Console.ReadLine();
                bool isNumeric = int.TryParse(inputText, out intValue);
                if (!isNumeric)
                {
                    Console.WriteLine("This is not a number!");
                    completed = false;
                }
                else if ((0 > intValue) || (999 < intValue))
                {
                    Console.WriteLine("This is not a number in the interval [0..999]");
                    completed = false;
                }
            }

            if (1 == inputText.Length)
            {
                finalText = getUnits(inputText);
            }
            else if (2 == inputText.Length)
            {
                if (errorCode.Equals(getTeens(inputText)))
                {
                    finalText = getTeens(inputText);
                }
                else
                {
                    finalText = getTens(inputText);
                }

            }
            else if (3 == inputText.Length)
            {
                finalText = getHundrets(inputText);
            }

            //finalText[0] = char.ToUpper(finalText[0]);
            Console.WriteLine(finalText);
        }
    }
}
