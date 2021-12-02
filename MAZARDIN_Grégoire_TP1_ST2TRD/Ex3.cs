using System;

namespace MAZARDIN_Grégoire_TP1_ST2TRD
{
    public class Ex3
    {
        private static int PowerFunction(int x)
        {
            return (int) (10/((int)Math.Pow(x, 2) - 4)); 
            /*I had to cast int on Math.Pow because it gives a Double as a result, which can be divided by 0, and thus
             does not throw any exception*/
        }
        
        
        public void TryCatch()
        {
            string[] array = new string[7];
            for (int i = 0; i<array.GetLength(0); i++)
            {
                int input = i - 3;
                try
                {
                    int result = PowerFunction(input);
                    array[i] = "F(" + input + ") = " + result;
                    
                }catch (DivideByZeroException e)
                {
                    array[i] = "F(" + input + ") = No result because of 0 division";
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i] != null)
                {
                    Console.WriteLine(array[i]);
                }
            }
            
        }
    }
}