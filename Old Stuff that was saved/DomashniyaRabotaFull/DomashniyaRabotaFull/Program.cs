using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grafik;

// Variant 2
// created by Michael on second coure


namespace DomashniyaRabotafull
{
    public class Programma
    {
        #region Data
        static int AmountOfDots = 10000000;
        static int DotsInGraph = 0;
        static Random rnd = new Random();
        static double X1 = 0;
        static double Y1 = 0;        
        #endregion

        static void Main()
        {
            var X = MyFunctionCalcProgram.FindY(1.0);
                                  
            Console.WriteLine(Programma.Calc());
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        public static double Calc()
        {
            for (int i = 0; i < AmountOfDots; i++)
            {
                double X1 = rnd.NextDouble() * 20.0 - 10.0;
                double Y1 = rnd.NextDouble() * 6.0 - 3.0;

                double Y = MyFunctionCalcProgram.FindY(X1);

                // Console.WriteLine(Y);
                // Console.WriteLine(X1);
                if (X1 <= 10 && X1 >= -10)
                {

                    if (Y1 < 0 && Y <= Y1 && Y < 0)
                    {

                        DotsInGraph++;

                    }
                    else if (Y1 >= 0 && Y >= Y1 && Y >= 0)
                    {

                        DotsInGraph++;
                    }
                }
            }
            
            Console.WriteLine("Точек попало");
            Console.WriteLine(DotsInGraph);
            Console.WriteLine("Площадь равна");  
            return (1.0 * DotsInGraph / AmountOfDots) * 120;  
        }
    }
}