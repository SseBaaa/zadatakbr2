using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatakbr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string upis = Console.ReadLine();

            Console.WriteLine(upis.Replace(' ', '_'));

            Console.ReadKey();
        }
    }
}
