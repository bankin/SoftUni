using System;

class Pairs
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        string[] elements = inputLine.Split(' ');

        int firstElement = int.Parse(elements[0]);
        int secondElement = int.Parse(elements[1]);
        int prevValue = firstElement + secondElement;

        int maxdiff = 0;
        for (int i = 2; i < elements.Length - 1; i+=2)
        {
            firstElement = int.Parse(elements[i]);
            secondElement = int.Parse(elements[i+1]);
            int lastValue = firstElement + secondElement;
            int diff = Math.Abs(lastValue - prevValue);
            maxdiff = Math.Max(diff, maxdiff);
            prevValue = lastValue;
        }

        if (maxdiff == 0)
        {
            Console.WriteLine("Yes, value=" + prevValue);
        }
        else
        {
            Console.WriteLine("No, maxdiff=" + maxdiff);
        }
    }
}
