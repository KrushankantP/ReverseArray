using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask User for number of elements they want to enter
            //Number of elements must be integer >0

            int numberofElementsToRead = 0;
            string inputStr = "";

            Console.WriteLine("How many element would you like to enter");
            inputStr = Console.ReadLine();

            numberofElementsToRead = IsStringANumber(inputStr, false);

            while (numberofElementsToRead == -1)
            {
                Console.WriteLine("Invalid number entered. Please Enter number > 0.");
                Console.WriteLine();
                Console.WriteLine("How many element would you like to enter?");
                inputStr = Console.ReadLine();
                numberofElementsToRead = IsStringANumber(inputStr, false);
            }

            int[] arrElements = new int[numberofElementsToRead];
            Console.WriteLine("Enter values you want to put in array !");

            for (int i = 0; i < numberofElementsToRead; i++)
            {
                Console.WriteLine("Enter " + (i+1)+ "value");
                int num = IsStringANumber(Console.ReadLine(), true);

                while (num == -1)
                {
                    Console.WriteLine("Invalid number enterd. Please enter a valid integer.");
                    Console.WriteLine();
                    Console.WriteLine("Enter " +(i+1)+ "value");

                    num = IsStringANumber(Console.ReadLine(), true);
                }
                arrElements[i] = num;
            }

            Console.WriteLine("Yor Elements in reverse order: ");
            for (int j = numberofElementsToRead - 1; j >= 0; j--)
            {
                Console.WriteLine(arrElements[j]);
            }
            Console.ReadLine();
            //Returns Integer > 0 OR -1
            
        }
        private static int IsStringANumber(string str, bool checkAnyInteger)
        {
            int retVal = -1;
            try
            {
                if (checkAnyInteger == true)
                {
                    retVal = Convert.ToInt32(str);
                }
                else
                {
                    if (Convert.ToInt32(str) > 0)
                    {
                        retVal = Convert.ToInt32(str);
                    }
                }
            }
            catch (Exception e)
            { 
                
            }
            return retVal;
        }
    }
}
