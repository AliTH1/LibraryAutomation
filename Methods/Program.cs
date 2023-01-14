using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите цыфру для проверки :");
            int a = Convert.ToInt32(Console.ReadLine());

            chek(a);
            Console.ReadLine();
        }

        static void chek(int a) 
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Это число является чётным");
            }
            else
            {
                Console.WriteLine("Это число не является чётным");
            }
        }
    }
}
