using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            TestIfElse(50);
        }

        public static void TestIfElse(int n)
        {
            if (n < 10)
            {
                Console.WriteLine("Less than 10");
            }
            else if (n < 20)
            {
                Console.WriteLine("Less than 20");
            }
            else if (n < 30)
            {
                Console.WriteLine("Less than 30");
            }
            else
            {
                Console.WriteLine("Shit -- It's bigger than 30!!!");
            }
        }
    }
}
