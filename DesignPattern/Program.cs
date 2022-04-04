using System;
using System.Threading.Tasks;
using Singleton;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
        //     Calculate calculate1=Calculate.GetInstance();
        //     calculate1.AddOne();
        //    Calculate calculate2=Calculate.GetInstance();
        //     calculate2.AddOne();
        //     Console.WriteLine(calculate1.Count);
        //     Console.WriteLine(calculate2.Count);
        //     calculate1.AddOne();
        //      Console.WriteLine(calculate1.Count);
        //     Console.WriteLine(calculate2.Count);
            Task task1=Task.Factory.StartNew(()=>{
                 Calculate calculate1=Calculate.GetInstance();
                 calculate1.AddOne();
                 Console.WriteLine($"calculte1{calculate1.Count}");
            });
            Task task2=Task.Factory.StartNew(()=>{
                 Calculate calculate2=Calculate.GetInstance();
                 calculate2.AddOne();
                 Console.WriteLine($"calculte2{calculate2.Count}");
            });
            Console.ReadKey();
        }
    }
}
