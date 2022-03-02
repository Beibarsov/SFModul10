using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFModul10
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            ICalculator calculator = new Calculator(Logger);
            calculator.SetInt();
            Console.WriteLine($"Результат: {calculator.Summ()}");
        }
    }
}