using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Задание_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());
            int position = ((v * t) % 109 + 109) % 109;
            Console.WriteLine(position);
        }
    }
}