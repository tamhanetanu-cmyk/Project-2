using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class Program
    {
        public void Add()
        {
            int A = 50, b = 20;
            int c = A + b;
            Console.WriteLine("Add"+ c);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Add();       }
    }
}
