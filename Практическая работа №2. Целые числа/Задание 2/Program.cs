// Дано натуральное число N, не превышающее 10^9. Выведите его последнюю цифру.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int last = n % 10;
            Console.WriteLine(last);
        }
    }
}