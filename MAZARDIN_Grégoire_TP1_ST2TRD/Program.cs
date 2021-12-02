using System;
using System.Data;

namespace MAZARDIN_Grégoire_TP1_ST2TRD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of the exercise you want to check");
            int.TryParse(Console.ReadLine(), out var choice);
            switch (choice)
            {
                case 1:
                    Ex1 Exercise1 = new Ex1();
                    Console.WriteLine("----------Task 1----------"+"\n");
                    Exercise1.Table(1);
                    Console.WriteLine();
                    Console.WriteLine("----------Task 2----------"+"\n");
                    Exercise1.Table(2);
                    Console.WriteLine();
                    Console.WriteLine("----------Task 3----------"+"\n");
                    Exercise1.Task3();
                    break;
                
                case 2:
                    Ex2 Exercise2 = new Ex2();
                    Console.WriteLine("----------Task 1----------"+"\n");
                    Exercise2.Prime();
                    Console.WriteLine();
                    Console.WriteLine("----------Task 2----------"+"\n");
                    Exercise2.Fibonacci();
                    Console.WriteLine();
                    Console.WriteLine("----------Task 3----------"+"\n");
                    Exercise2.Factorial();
                    break;
                
                case 3:
                    Ex3 Exercise3 = new Ex3();
                    Exercise3.TryCatch();
                    break;
                
                case 4:
                    Ex4 Exercise4 = new Ex4();
                    Exercise4.Square();
                    break;
                
                case 5:
                    Ex5 Exercise5 = new Ex5();
                    Exercise5.ChristmasTree();
                    break;
                
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            Console.WriteLine("Bye, thanks for checking my exercises !");
        }
    }
}