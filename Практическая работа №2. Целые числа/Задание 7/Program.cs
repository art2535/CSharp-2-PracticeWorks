using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Задание_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int L = Convert.ToInt32(Console.ReadLine());
            int W = Convert.ToInt32(Console.ReadLine());
            int H = Convert.ToInt32(Console.ReadLine());
            double S = Math.Ceiling((double)L / 2) + Math.Ceiling((double)W / 2) + Math.Ceiling((double)H / 2);
            Console.WriteLine(S);
        }
    }
}