﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLuong_QA_A2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            do
            {
                ShowMenu();
                userInput = Console.ReadLine();
                int a;
                int b;
                int c;
                int limit = 999999999;
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Please enter the 3 dimensions:");
                        Console.WriteLine("First dimension:");
                        Int32.TryParse(Console.ReadLine(), out a);
                        if (a < limit)
                        {
                            Console.WriteLine("Second dimension:");
                            Int32.TryParse(Console.ReadLine(), out b);
                            if (b < limit)
                            {
                                Console.WriteLine("Third dimension:");
                                Int32.TryParse(Console.ReadLine(), out c);
                                if (c < limit)
                                {

                                    if (a > 0 && b > 0 && c > 0)
                                    {
                                        Console.WriteLine(TriangleSolver.Analyze(a, b, c));
                                    }
                                    else
                                    {
                                        Console.WriteLine("Wrong input");
                                        break;
                                    }
                                }
                            }
                        }
                        break;

                    case "2":
                        Console.WriteLine("Application closing!");
                        break;

                    default:
                        Console.WriteLine("Wrong selection, please try again!");
                        Console.WriteLine();
                        break;
                }
            }
            while (userInput != "2");
            Console.ReadKey();
        }
        static void ShowMenu()
        {
            Console.WriteLine("Please select the following option: \n 1. Enter triangle dimensions \n 2. Exit");
        }
    }
}
