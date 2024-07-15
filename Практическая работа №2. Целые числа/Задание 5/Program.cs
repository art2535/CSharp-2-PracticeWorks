/* На вход дается натуральное число N. Необходимо определить следующее за ним четное число. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Задание_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n + 2 - n % 2);
        }
    }
}