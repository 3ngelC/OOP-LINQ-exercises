using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercises
{
    internal class One
    {
        public static void MyIntStack()
        {
            int[] contents = new int[100];

        }
        
        public static int[] AddValues(int[] contents)
        {
            List<int> list = contents.ToList();
            
            

            try
            {
                ReadValue();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            {

            }
            

        }

        public static int ReadValue()
        {
            Console.WriteLine("Please enter a number");
            string valueInserted = Console.ReadLine();
            int value = Convert.ToInt32(valueInserted);
            return value;
        }
        
    }
}
