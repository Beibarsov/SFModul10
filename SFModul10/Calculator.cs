using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFModul10
{
     class Calculator : ICalculator
    {
        public ILogger Logger { get; }
        public int A { get; set; }
        public int B { get; set; }

        public Calculator(ILogger logger)
        {
            A = 0;
            B = 0;
            Logger = logger;
        }

        public Calculator(int a, int b, ILogger logger)
        {
            A = a;
            B = b;
            Logger = logger;
        }

        public void SetInt()
        {
            Logger.Event("Начало ввода данных");
            Thread.Sleep(1000);
            Console.WriteLine("Ввод новых значений в переменные");
            try
            {
                Console.WriteLine("Введите число A:");
                A = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите число B:");
                B = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {

                Logger.Error($"Ошибка при вводе данных: {ex.Message}");
            }
            
        }
        public int Summ()
        {
            Logger.Event("Результат получен");
            return A + B;
        }
    }
}
