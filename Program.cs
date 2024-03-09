using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet2_7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rok : ");
            int rok = Int32.Parse(Console.ReadLine());

            if (rok % 4 == 0)
            { Console.WriteLine("Podany rok jest rokiem przestępnym");
            
            }
            else
            { Console.WriteLine("Podany rok nie jest rokiem przestępnym");
            
            }
            Console.ReadLine();

        }
    }
}
