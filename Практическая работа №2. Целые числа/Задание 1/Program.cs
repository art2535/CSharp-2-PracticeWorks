/* N белочек нашли K орешков и решили разделить их поровну.
 * Определите, сколько орешков достанется каждой белочке. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(k / n);
        }
    }
}