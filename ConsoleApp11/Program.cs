using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Unit_10._5
{
    internal class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            myCalc myCalc = new myCalc(Logger);
            NumReader numReader = new NumReader();

            int a = 0;
            int b = 0;
            int i = 1;
            while (true && i > 0)
            {
                try
                {
                    Console.WriteLine("Значение a");
                    a = numReader.KeyRead();
                    i--;
                    Logger.Event($"значение a равно {a}");

                }
                catch (Exception ex)
                {
                    Logger.Error(ex);


                }
            }
            i++;
            while (true && i > 0)
            {
                try
                {
                    Console.WriteLine("Значение b");
                    b = numReader.KeyRead();
                    i--;
                    Logger.Event($"значение b равно {b}");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            string s = myCalc.Sum(a, b).ToString();
            Logger.Event($"Результатом является {s}");

        }
    }
}