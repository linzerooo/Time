using System;

namespace ConsoleApplication6
{
    public class Program
    {
        public static void Main()
        {
            Time f1 = new Time(1,1,1);
            Time f2 = new Time(0,1,1);
            Console.WriteLine(f1+f2);
            Console.WriteLine(f1-f2);
            Console.WriteLine(f1*2);
            Console.WriteLine(f1/2);
        }
    }
}