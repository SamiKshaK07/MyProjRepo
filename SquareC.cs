using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo
{
    public class SquareC
    {

        static void Main(string[] args)
        {
            new SquareC();
        }

        public SquareC()
        {
            Console.WriteLine("Enter a Number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int square = n1 * n1;
            int cube = square * n1;
            Console.WriteLine("The Square of Num is {0} and Cube of this is {1} ", square, cube);
            Console.ReadLine();
        }

    }
}


