using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Grafik
{
    public class MyFunctionCalcProgram
    {
        private static string FileName = @"Coords.txt"; //path Grafik/bin/Debug

        static void Main()
        {
            Krivaiya();
            Console.ReadKey();
            return;
        }

        public static void Krivaiya()
        {
            if (!File.Exists(FileName))
                File.Create(FileName);

            StreamWriter WriteToFile;
            try
            {
                WriteToFile = new StreamWriter(FileName);
            }
            catch (IOException)
            {
                Console.WriteLine("Error pls restart application, Please");
                WriteToFile = new StreamWriter(FileName);
            }

            Random rnd = new Random();
            double Tochki = 10000;            
            double X = 0;
            double Y = 0;

            for (int i = 0; i < Tochki; i++)
            {
                X = Convert.ToDouble(rnd.Next(-20, 20));
                Y = Convert.ToDouble(rnd.Next(-6, 6));

                Y = FindY(X);
                if (X <= 10 && X >= -10)
                {                    
                    Console.WriteLine("X = " + X);
                    WriteToFile.WriteLine(X);
                    Console.WriteLine("Y = " + Y);
                    WriteToFile.WriteLine(Y);
                }
                
            }
        }

        #region For finding *Y*
        public static double FindY(double X)
        {
            if (X == Double.NaN) return Double.NaN;
            if (X <= -9) return 0.0;
            if ((X > -9) && (X <= -6)) return Circle1(X);
            if ((X >= -6) && (X <= -3)) return Line1(X);
            if ((X > -3) && (X <= 0)) return Circle2(X);
            if ((X > 0) && (X <= 6)) return Line2(X);
            if ((X > 6) && (X <= 9)) return Line3(X);
            if (X > 9) return 3;

            return X;
        }

        #region Graph parts
        static private double Line1(double X)
        {
            return (X + 3);
        }
        static private double Line2(double X)
        {
            return Math.Abs((X - 6) / (-2));
        }
        static private double Line3(double X)
        {
            return (X - 6);
        }
        static private double Circle1(double X)
        {
            return -Math.Sqrt(Math.Abs(9 - Math.Pow(X + 6, 2)));
        }
        static private double Circle2(double X)
        {
            return Math.Sqrt(Math.Abs(9 - Math.Pow(X, 2)));
        }

        #endregion
        #endregion
    }

}
