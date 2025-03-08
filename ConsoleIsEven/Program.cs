using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


////Определение, является ли число четным
//Структура:
//Входные данные: одно целое число number.
//Выходные данные: true, если число четное, иначе false.

namespace ConsoleIsEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число a");
            int num =int.Parse(Console.ReadLine());
            Console.WriteLine(IsEven(num));
        }
         static bool IsEven(int a)
        {
            if(a%2==0) return true;
            else return false;
        }
    }
}
