using System;

public class House
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write(new string('.', n / 2));
        Console.Write(new string('*', 1));
        Console.WriteLine(new string('.', n / 2));

        int outsideCounter = n / 2 - 1;
        int insideCounter = 1;

        while (outsideCounter != 0)
        {
            Console.Write(new string('.', outsideCounter));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', insideCounter));
            Console.Write(new string('*', 1));
            Console.WriteLine(new string('.', outsideCounter));

            outsideCounter--;
            insideCounter += 2;
        }

        Console.WriteLine(new string('*', n));

        int wallDistance = n / 4;

        for (int i = n / 2 + 1; i < n - 1; i++)
        {
            Console.Write(new string('.', wallDistance));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', n - 2 * wallDistance - 2));
            Console.Write(new string('*', 1));
            Console.WriteLine(new string('.', wallDistance));
        }

        Console.Write(new string('.', wallDistance));
        Console.Write(new string('*', n - 2 * wallDistance));
        Console.WriteLine(new string('.', wallDistance));
    }
}
