using System;

namespace Demo
{
    class Operators
    {
        static void Main(string[] args)
        {
            Int32 val1 = 22, val2 = 33;
            bool status = false;

            Console.WriteLine(val1 + val2);
            Console.WriteLine(val1 < val2);
            Console.WriteLine(!(status));
            Console.ReadKey();
        }
    }
}
