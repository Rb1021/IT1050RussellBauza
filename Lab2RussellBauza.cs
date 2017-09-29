using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Russell_Bauza
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1; // declare first number to add
            int number2; // declare second number to add
            int sum; //declare sum of number1 and number2

            Console.Write("Enter first integer: "); // prompt user
            // read first number from user
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer: "); // prompt user
            //read second number from user
            number2 = int.Parse(Console.ReadLine());
            sum = number1 + number2; // add numbers
         
            Console.WriteLine($"Sum is {sum}"); // Display sum

            int x; // declare x
            int y; // declare y
            int z; // declare z

            Console.Write("Enter value for x: "); // prompt user
            // read value

            x = int.Parse(Console.ReadLine());

            Console.Write("Enter value for y: "); // prompt user
            // read value

            y = int.Parse(Console.ReadLine());

            Console.Write("Enter value for z: "); // prompt user
            // read value

            z = int.Parse(Console.ReadLine());
            sum = (x + y) * (z + 10);

            Console.WriteLine($"Sum is {sum}"); // display sum
        }
    }
}
