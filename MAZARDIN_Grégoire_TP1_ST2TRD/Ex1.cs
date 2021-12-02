using System;
using System.Linq;

namespace MAZARDIN_Grégoire_TP1_ST2TRD
{
    public class Ex1
    {
        public void Table(int task)
        {
            string[,] table = new string[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int result = (i + 1) * (j + 1);
                    if (task == 2 && result%2 != 0 || task == 1)
                    {
                        table[i, j] = (i + 1) + " * " + (j + 1) + " = " + result;
                    }
                }
            }

            for (int i = 0; i < table.GetLength(0); i++)
            {
                Console.WriteLine("----------Table des "+(i+1)+"----------");
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (table[i, j]!=null)
                    {
                        Console.WriteLine(table[i, j]);
                    }
                }
            }
        }

        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        public void Task3()
        {
            int number = AskUserForParameter();
            if (number == 0)
            {
                Console.WriteLine("----------Table de "+number+"----------");
                Console.WriteLine("0 * 0 = 0");
            }
            else
            {
                string[] table = new string[number];
            
                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j < number; j++)
                    {
                        int result = (i + 1) * (j + 1);
                        table[i] = (i + 1) + " * " + (j + 1) + " = " + result;
                    }
                
                }
            
                Console.WriteLine("----------Table de "+number+"----------");
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    if (table[i] != null)
                    {
                        Console.WriteLine(table[i]);
                    }
                }
            }
           
        }
    }
}