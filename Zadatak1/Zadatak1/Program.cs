using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerList l = new IntegerList();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(4);
            l.Add(5);
            l.RemoveAt(0);
            l.Remove(5);
            Console.WriteLine(l.Count);
            Console.WriteLine(l.Remove(100));
            Console.WriteLine(l.RemoveAt(5));
            l.Clear();
            Console.WriteLine(l.Count);

            
        }
    }
}
