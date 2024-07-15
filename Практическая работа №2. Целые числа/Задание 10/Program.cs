using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Задание_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int H = Convert.ToInt32(Console.ReadLine());
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int day = 0, climbed = 0;
            while (climbed < H)
            {
                day++;
                climbed += A;
                if (climbed >= H)
                    break;
                climbed -= B;
            }
            Console.WriteLine(day);
        }
    }
}