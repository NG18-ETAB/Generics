using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //MinTest();          
            GenericsTest();        
        }

        private static void GenericsTest()
        {
            // specific Pair, no type arguments, assumes int
            var pair = new Pair(1, 2);
            Console.WriteLine($"{pair}: {pair.First}, {pair.Second}");
            Console.WriteLine();

            // generic Pair<T>, one type argument, int
            var pairInt = new Pair<int>(1, 2);
            Console.WriteLine(pairInt);
            Console.WriteLine();

            // generic Pair<T>, one type argument, string
            var pairString = new Pair<string>("one", "two");
            Console.WriteLine(pairString);
            Console.WriteLine();

            // nested generic
            var tree = new Pair<Pair<int>>(new Pair<int>(1, 2), new Pair<int>(3, 4));
            Console.WriteLine(tree);
            tree.Second.First += 2;
            Console.WriteLine(tree);
            Console.WriteLine();

            // generic Pair<T1, T2>, two type arguments, int and string
            var pairIntString = new Pair<int, string>(1, "two");
            Console.WriteLine(pairIntString);
            Console.WriteLine();

            // generic Pair<T, T>, two identical type arguments, int and int
            var isoPair = new Pair<int, int>(1, 2);
            Console.WriteLine(isoPair);
            Console.WriteLine();
        }

        private static void MinTest()
        {
            Console.WriteLine(Utils.Min(1, 2));
            Console.WriteLine(Utils.Min("a", "b"));
            Console.WriteLine(Utils.Min(1, 2f).GetType().Name);
        }
    }
}
