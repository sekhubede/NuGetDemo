using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FiggleDemo.Start();
            PastelDemo.Start();

            WaitForKey();
        }

        public static void WaitForKey()
        {
            Console.Write($"\n(press any key to exit)");
            Console.ReadKey(true);
        }
    }

    internal class FiggleDemo
    {
        public static void Start()
        {
            Console.WriteLine("=== Figgle Demo ===");
        }
    }

    internal class PastelDemo
    {
        public static void Start()
        {
            Console.WriteLine("=== Pastel Demo ===");
        }
    }
}
