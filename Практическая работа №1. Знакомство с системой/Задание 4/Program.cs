using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            if (numbers.Length == 2)
            {
                if (int.TryParse(numbers[0], out int A) && int.TryParse(numbers[1], out int B))
                    Console.WriteLine(A + B);
            }
        }
    }
}