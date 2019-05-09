using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Process();
        }

        static int Fact(int n)
        {
            if (n == 1) return 1;
            else return n * Fact(n - 1);
        }

        static void Process()
        {
            Console.WriteLine("Введите число для нахождения его факториала: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Факториал числа {num} = {Fact(num)}");
            RepeatOperation();
        }

        static void RepeatOperation()
        {
            Console.WriteLine("Продолжить? (да/нет)");
            string answer = Console.ReadLine().ToLower();
            if (answer == "да" || answer == "yes") { Process(); Console.Clear(); }
            else if (answer == "нет" || answer == "no") { Console.WriteLine("Завершение работы..."); return; }
            else { Console.WriteLine("Повторите попытку..."); RepeatOperation(); }
        }
    }
}
