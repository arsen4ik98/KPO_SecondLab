using System;
using System.Collections.Generic;

namespace Queue
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IQueue asd = new Queue();
            asd.Push(17);
            asd.Push(33);
            asd.Push(1);
            asd.Push(3);
            asd.Push(2);
            Console.WriteLine(asd.Pop());
            Console.WriteLine(asd.TakeTop());
            Console.WriteLine(asd.IsEmpty());
            asd.Push(17);
            Console.WriteLine(asd.Pop());
            Console.ReadKey();

        }
    }
}