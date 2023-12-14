using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Choise = -1;
            while (Choise!=0)
            {
                Console.WriteLine("Nhap 1 ky tu tu ban phim");
                Choise = int.Parse(Console.ReadLine());
                switch (Choise)
                {
                    case 1: 
                        Console.WriteLine("*********");
                        Console.WriteLine("********");
                        Console.WriteLine("*******");
                        Console.WriteLine("******");
                        Console.WriteLine("*****");
                        Console.WriteLine("****");
                        Console.WriteLine("***");
                        Console.WriteLine("**");
                        Console.WriteLine("*");
                        break;
                    case 2:
                        Console.WriteLine("**********");
                        Console.WriteLine("**********");
                        Console.WriteLine("**********");
                        Console.WriteLine("**********");
                        Console.WriteLine("**********");
                        Console.WriteLine("**********");
                        break;
                    case 3:
                        Console.WriteLine("**********");
                        Console.WriteLine("**********");
                        Console.WriteLine("**********");
                        break;
                        default: Console.WriteLine("nhap lai");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}