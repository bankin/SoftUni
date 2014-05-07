using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _12.FallingRocks
{
    class FallingRocks
    {
        const int WIDTH = 80;
        const int HEIGHT = 12;
        static char[,] field = new char[HEIGHT, WIDTH];
        static char[] rocks = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
        static int dwarfX = 39;

        static void initField()
        {
            for (int i = 0; i < HEIGHT; i++)
            {
                for (int j = 0; j < WIDTH; j++)
                {
                    field[i, j] = ' ';
                }
            }
        }

        static void printField()
        {
            Console.Clear();            
            for (int i = 0; i < HEIGHT; i++)
            {
                for (int j = 0; j < WIDTH; j++)
                {
                    Console.Write(field[i, j]);
                }
                Console.WriteLine();
            }
        }

        static bool updateField()
        {
            for (int i = 0; i < WIDTH; i++)
            {
                if (field[HEIGHT - 2, dwarfX] != ' ')
                {
                    return true;
                }
                if (field[HEIGHT - 2, dwarfX + 1] != ' ')
                {
                    return true;
                }
                if (field[HEIGHT - 2, dwarfX + 2] != ' ')
                {
                    return true;
                }
            }
            for (int i = HEIGHT - 2; i > 0; i--)
            {
                for (int j = WIDTH - 1; j >= 0; j--)
                {
                    field[i, j] = field[i - 1, j];
                }
            }
            
            for (int i = 0; i < WIDTH; i++)
            {
                field[0, i] = ' ';
            }

            return false;
        }

        static void addRock(int rock, int index)
        {
            field[0, index] = rocks[rock];
        }

        static void moveDwarf(int dwarfX, int direction)
        {
            field[HEIGHT - 1, dwarfX] = ' ';
            field[HEIGHT - 1, dwarfX + 1] = ' ';
            field[HEIGHT - 1, dwarfX + 2] = ' ';

            field[HEIGHT - 1, dwarfX + direction] = '(';
            field[HEIGHT - 1, dwarfX + 1 + direction] = '0';
            field[HEIGHT - 1, dwarfX + 2 + direction] = ')';
        }

        static void Main(string[] args)
        {
            initField();

            field[HEIGHT - 1, dwarfX] = '(';
            field[HEIGHT - 1, dwarfX + 1] = '0';
            field[HEIGHT - 1, dwarfX + 2] = ')';

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo readkey;
                    readkey = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey();
                    }

                    if (readkey.Key == ConsoleKey.LeftArrow)
                    {
                        moveDwarf(dwarfX, -1);
                        dwarfX--;
                    }
                    else if (readkey.Key == ConsoleKey.RightArrow)
                    {
                        moveDwarf(dwarfX, 1);
                        dwarfX++;
                    }
                }
                
                Random r = new Random();
                int rock = r.Next(0, rocks.Length);
                int index = r.Next(0, 80);

                if (updateField())
                {
                    Console.Clear();
                    Console.WriteLine("GAME OVER");
                    return;
                }
                addRock(rock, index);
                printField();

                Thread.Sleep(300);
            }

        }
    }
}
