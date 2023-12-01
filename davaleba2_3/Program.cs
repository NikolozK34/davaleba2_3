using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("sheiyvane ricxvi: ");

            int m = int.Parse(Console.ReadLine());

            int n;

            if(m > 0)
            {
                n = 1;
            }else if (m < 0)
            {
                n = -1;
            }else 
            { 
                n = 0; 
            }

            Console.WriteLine($"n = {n}");
        }
    }
}
