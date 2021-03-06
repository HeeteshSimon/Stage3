using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingHandson1
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Method1().Result;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static async Task<string> Method1()
        {
            return await Method2();
        }

        public static async Task<string> Method2()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5000);
                return "Async and Await Example";
            });
            
            
        }
    }
}
