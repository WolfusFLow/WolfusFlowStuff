using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   // for creating tasks(how obvious...)    try, catch, flag(mb)

// variant 2
// created by Michael 2 course

//file coords in bin consol app

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main()
        {
            Graph.GenerateRandPoints();   //for generating file

            Console.WriteLine("Площадь равна");
			Console.WriteLine(Graph.Calc());

			
            Console.WriteLine("Press any key to exit");
			Console.ReadKey();
        }

    }
}