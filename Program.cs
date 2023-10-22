using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algs_Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Mx, My, Mz;
            Console.Write("x = ");
            Mx = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            My = Convert.ToInt32(Console.ReadLine());
            Console.Write("z = ");
            Mz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"F (recursion) = {f(Mx, My, Mz)}");
            Console.WriteLine($"F (iteration method) = {fIt(Mx, My, Mz)}");
            Console.ReadKey();

            int truncated_subtr(int x, int y)
            {
                if (x < y) return 0;
                return x - y;
            }
            int g(int x, int y)
            {
                return 4 * x + 3 * y;
            }
            int h(int x, int y, int z, int t)
            {
                return ((t + 1) * (t + 1)) + truncated_subtr(x, y) + z;
            }
            int f(int x, int y, int z)
            {
                if (z == 0) return g(x, y);
                return h(x, y, z - 1, f(x, y, z - 1));
            }
            int fIt(int x, int y, int z)
            {
                int t = g(x, y);
                for (int i = 0; i < z; i++)
                {
                    t = h(x, y, i, t);
                }
                return t;
            }
        }
        
    }
}
