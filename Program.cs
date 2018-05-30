using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            char[] spolgloska = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 't', 'w', 'z' };
            char[] samogloska = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };

            for (int j = 0; j < 5; j++)
            {
                int max = rand.Next(2, 6);
                for (int i = 0; i < max; i++)
                {

                    int spol = rand.Next(0, 17);
                    int samo = rand.Next(0, 6);


                    Console.Write(spolgloska[spol].ToString() + samogloska[samo]);
                }
                Console.WriteLine(" 1 ");

            }
            for (int j = 0; j < 20; j++)
            {
                int max2 = rand.Next(4, 8);
                for (int i = 0; i < max2; i++)
                {
                    double g = rand.NextDouble();
                    if (g < 0.0891)
                    {
                        Console.Write('a');
                    }
                    else if (g < 0.1038)
                    {
                        Console.Write('b');
                    }
                    else if (g < 0.1434)
                    {
                        Console.Write('c');
                    }
                    else if (g < 0.1759)
                    {
                        Console.Write('d');
                    }
                    else if (g < 0.2525)
                    {
                        Console.Write('e');
                    }
                    else if (g < 0.2555)
                    {
                        Console.Write('f');
                    }
                    else if (g < 0.2698)
                    {
                        Console.Write('g');
                    }
                    else if (g < 0.2805)
                    {
                        Console.Write('h');
                    }
                    else if (g < 0.3626)
                    {
                        Console.Write('i');
                    }
                    else if (g < 0.3854)
                    {
                        Console.Write('j');
                    }
                    else if (g < 0.4205)
                    {
                        Console.Write('k');
                    }
                    else if (g < 0.4415)
                    {
                        Console.Write('l');
                    }
                    else if (g < 0.4695)
                    {
                        Console.Write('m');
                    }
                    else if (g < 0.5247)
                    {
                        Console.Write('n');
                    }
                    else if (g < 0.602)
                    {
                        Console.Write('o');
                    }
                    else if (g < 0.6335)
                    {
                        Console.Write('p');
                    }
                    else if (g < 0.6804)
                    {
                        Console.Write('r');
                    }
                    else if (g < 0.7236)
                    {
                        Console.Write('s');
                    }
                    else if (g < 0.7634)
                    {
                        Console.Write('t');
                    }
                    else if (g < 0.7884)
                    {
                        Console.Write('u');
                    }
                    else if (g < 0.8349)
                    {
                        Console.Write('w');
                    }
                    else if (g < 0.8725)
                    {
                        Console.Write('y');
                    }
                    else if (g < 0.8824)
                    {
                        Console.Write('a');
                    }
                    else
                    {
                        Console.Write('z');
                    }
                    
                }
                Console.WriteLine();
            }
                Console.ReadKey();
            
        }
    }
}
