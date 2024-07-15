/* Дано натуральное число N, определите число десятков в нем (предпоследнюю цифру числа). 
 * Если предпоследней цифры нет, то можно считать, что число десятков равно нулю. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dec = (n / 10) % 10;
            Console.WriteLine(dec);
        }
    }
}