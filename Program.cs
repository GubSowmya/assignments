using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Input the first number to multiply: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the second to multiply :");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the third to multiply :");
            num3 = Convert.ToInt32(Console.ReadLine());

            int result = num1 * num2 * num3;
            Console.WriteLine("Output : {0} * {1} * {2} = {3}", num1, num2, num3, result);
            Console.ReadLine();

            




        }
    }
}
