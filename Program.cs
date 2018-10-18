using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);

                Console.ReadLine();
            }
            catch (DivideByZeroException)//only number erros
            {
                Console.WriteLine("Error"); //different way of seeing a message
                //Console.WriteLine(e.Message); // also a different error message
            }
            catch (FormatException e)//only format erros
            {
                //Console.WriteLine("Error"); different way of seeing a message
                Console.WriteLine(e.Message); // also a different error message
            }
            finally //optional you can use for the program learn more about it
            {

            }


        }
    }
}
