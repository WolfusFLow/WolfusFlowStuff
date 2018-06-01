using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 #region GovnoNeShoditsiya>_<
public static class Graph        // Why we still here?..
{
	private static string FileName = @"coords.txt";  // file
	public static int AmountOfDots = 1000;	// how many coords will generate & use

	public static void GenerateCoords()
	{
		#region Data
		Random rnd = new Random();
		double X = 0;

		#endregion

		if (!File.Exists(FileName))			// Creating file (exeprions below)
			File.Create(FileName);

		StreamWriter WriteToFile;
		try
		{
			WriteToFile = new StreamWriter(FileName);
		}
		catch (IOException)	//  Will catch it at first debug because @File.Create(FileName)@ doesn`t close file
		{
            Console.WriteLine("Error pls restart application, Please");
            WriteToFile = new StreamWriter(FileName);
		}

		for (int i = 0; i < AmountOfDots; i++)
		{
			X = Convert.ToDouble(rnd.Next(-10000, 10000)) / 1000;
			WriteToFile.WriteLine(X);
			WriteToFile.WriteLine(FindY(X));
		}
		WriteToFile.Close();

	}

	public static void GenerateRandPoints()
	{
		Random rnd = new Random();

		if (!File.Exists(FileName))			// Creation of file
			File.Create(FileName);

		StreamWriter WriteToFile;
		try
		{
			WriteToFile = new StreamWriter(FileName);
		}
		catch (IOException)	// ловит ошибку в создании файлика Will catch it at first debug because @File.Create(FileName)@ doesn`t close file
		{
            Console.WriteLine("Error, Restart application, Please");
            WriteToFile = new StreamWriter(FileName);
		}

        
		for (int i = 0; i < AmountOfDots; i++)
		{
			WriteToFile.WriteLine(Convert.ToDouble(rnd.Next(-10000, 10000)) / 1000);
			WriteToFile.WriteLine(Convert.ToDouble(rnd.Next(-3000, 3000)) / 1000);
		}
		WriteToFile.Close(); //end write down to file

	}

    private static void ReadCords(Point[] WhereToSave)
    {
        if (File.Exists(FileName))
        {
            StreamReader Read = new StreamReader(FileName);
            for (int i = 0; i < AmountOfDots; i++)
            {
                WhereToSave[i].X = Convert.ToDouble(Read.ReadLine());
                WhereToSave[i].Y = Convert.ToDouble(Read.ReadLine());
            }
            Read.Close();
        }
    }

	public static double Calc()
	{
		Point []DotsArray = new Point[AmountOfDots];
		for (int i = 0; i < DotsArray.Length; i++)
			DotsArray[i] = new Point();

		ReadCords(DotsArray);


		

		int DotsInGraph = 0;

		for (int i = 0; i < AmountOfDots; i++)
		{
			if(DotsArray[i].Y < 0)
				DotsArray[i].Y = Math.Abs(DotsArray[i].Y);

			if (DotsArray[i].Y <= FindY(DotsArray[i].X))
				DotsInGraph++;
		}
		//35.13   ??????   what am i doing wrong?

        return (1.0 * DotsInGraph / AmountOfDots) * 54;
	}

    
	#region For finding *Y*
	public static double FindY(double X)
	{
		if (X == Double.NaN) return Double.NaN;
		if (X <= -9) return 0.0;
		if ((X > -9) && (X <= -6))  return Circle1(X);
		if ((X >= -6) && (X <= -3)) return Line1(X);
		if ((X > -3) && (X <= 0))   return Circle2(X);
		if ((X > 0) && (X <= 6))    return Line2(X);
		if ((X > 6) && (X <= 9))    return Line3(X);
		if (X > 9)   return 3;
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

public class Point
{
	public double X = 0, Y = 0;  //zeroing of variables
	public Point()
	{

	}
}
#endregion