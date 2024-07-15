/* На отделении "Информационных технологий" в колледже висят электронные часы, показывающие время в формате 
h:mm:ss (от 0:00:00 до 23:59:59), то есть сначала записывается количество часов 
(однозначное или двузначное число), потом обязательно двузначное количество минут, затем обязательно 
двузначное количество секунд. Количество минут и секунд при необходимости дополняются до двузначного 
числа нулями.
С начала суток прошло N секунд. Выведите, что покажут часы. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Задание_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int hours = (input / 3600) % 24;
            int minutes = (input / 60) % 60;
            int seconds = input % 60;
            Console.WriteLine($"{hours}:{minutes:00}:{seconds:00}");
        }
    }
}