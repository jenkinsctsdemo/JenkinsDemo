using System;

namespace Demo
{
    public class Program
    {
        //TODO: document this method
        private static void Main(string[] args)
        {
            //hack: we really should not be doing this!
            //fixme: lets find a better way of doing this.
            Console.Out.WriteLine("Hello Jenkins!");
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            return x / y;
        }
    }
}