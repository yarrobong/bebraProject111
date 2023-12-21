using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bebraProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] existingArray = { -2, -4, 0, 1, 2, 3, 4, 5 };
            List<int> numbersList = new List<int>();

            for (int i = 0; i < existingArray.Length; i++)
            {

                numbersList.Add(existingArray[i]); 
                
            }



            




            foreach (int number in numbersList)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
