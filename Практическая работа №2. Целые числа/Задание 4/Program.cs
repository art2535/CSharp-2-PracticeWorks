/* Пирожок в столовой стоит A рублей и B копеек. 
 * Определите, сколько рублей и копеек нужно заплатить за N пирожков. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int totalCost = N * (100 * A + B);
            int rubles = totalCost / 100;
            int kopecks = totalCost % 100;
            Console.WriteLine(rubles + " " + kopecks);
        }
    }
}