using System;
using Singleton;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate1=Calculate.GetInstance();
            calculate1.AddOne();
           Calculate calculate2=Calculate.GetInstance();
            calculate2.AddOne();
            Console.WriteLine(calculate1.Count);
            Console.WriteLine(calculate2.Count);
            calculate1.AddOne();
             Console.WriteLine(calculate1.Count);
            Console.WriteLine(calculate2.Count);
        }
    }
}
