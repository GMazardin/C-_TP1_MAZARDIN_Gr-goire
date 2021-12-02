using System;

namespace MAZARDIN_Grégoire_TP1_ST2TRD
{
    public class Ex5
    {
        private static int AskUserForParameter() //Asking user to give size
        {
            Console.WriteLine("Please write a size between 3 and 20 and press enter :");
            int.TryParse(Console.ReadLine(), out var input);
            int result = input;
            while(result < 3 || result > 20)
            {
                Console.WriteLine("Please write a size between 3 and 20 and press enter :");
                int.TryParse(Console.ReadLine(), out var input1);
                result = input1;
            }
            return result;
        }
        
        public void ChristmasTree()
        {
            int size = AskUserForParameter();
            for (int y = 0; y <= size; y++) //Iterating on the lines
            {
                for (int x = 0; x < (size*2)-1; x++) //Iterating on the Columns
                {
                    if (y == size && (x == size - 2  || x == size)) //Adding the trunk at the last row
                    {
                        Console.Write("|");
                    }
                    else if ((y < size) && ((x == size - 1) || (x >= size-1-y && x <= size-1+y))) 
                        /*First checking if we are not at the last row (trunk), then adding two more
                         stars each row*/
                    {
                        
                        if ((y > 0) && (x + y + (y%3)) % 3 == 0) 
                            //Checking for the positions with % like Ex4 to place the decoration
                        {
                            Random random = new Random(); //Creating a random weighted number to make the difference between i and o
                            int number = random.Next(0, 100);
                            if ((number -= 20) < 0)
                            {
                                Console.Write("o");
                            }
                            else
                            {
                                Console.Write("i");
                            }
                        }
                        else
                        {
                            Console.Write("*");   
                        }
                    }
                    else //Anywhere else = blank space
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}