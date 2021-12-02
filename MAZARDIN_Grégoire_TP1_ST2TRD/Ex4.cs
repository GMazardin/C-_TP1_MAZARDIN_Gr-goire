using System;

namespace MAZARDIN_Grégoire_TP1_ST2TRD
{
    public class Ex4
    {
        private static int[] AskUserForParameter() //Asking user for width and height
        {
            Console.WriteLine("Please write a width, a space, and then a height and press enter :");
            string line = Console.ReadLine(); //Reading input
            string[] numbers = line.Split(' '); //Separating the inputs
            int[] output = new int[2];
            for (int i = 0; i < output.Length; i++)
            {
                int.TryParse(numbers[i],out var result); //TryParsing all inputs and then adding them to int array
                output[i] = result;
            }
            return output;
        }
        
        
        public void Square()
        {
            int[] inputs = AskUserForParameter(); //Checking for inputs
            int width = inputs[0];
            int height = inputs[1];
            if (width >= 1 && width <= 1000 && height >= 1 && height <= 1000) //First condition of the exercise
            {
                for (int y = 0; y < height; y++) //Iterating on lines
                {
                    for (int x = 0; x < width; x++) //Iterating on columns
                    {
                        if ((x == 0 && (y == 0 || y == height - 1)) //Adding all the corners
                            || (x == width - 1 &&(y == 0 || y == height - 1)))
                        {
                            Console.Write("0");
                        }
                        else if (x == 0 || x == width - 1) //Adding the vertical outer lines
                        {
                            Console.Write("|");
                        }
                        else if (y == 0 || y == height - 1) //Adding the horizontal outer lines
                        {
                            Console.Write("-");
                        }
                        else if ((y + x - 2) % 3 == 0) 
                            /*Here all the * are separated by two blanks of each other. Thus we can use
                             the %3 to iterate and create all of them*/
                        {
                            Console.Write("*");
                        }
                        else //Anything else is blank space
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}