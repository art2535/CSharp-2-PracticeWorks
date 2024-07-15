using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Задание_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int wallArea = h * (l + w);
            int paintCans = (int)Math.Ceiling((double)wallArea / 8);
            Console.WriteLine(paintCans);
        }
    }
}
