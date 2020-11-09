using System;

namespace обработка_исключений
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = int.Parse(Console.ReadLine()); // 1 ситуация 
                int y = 1 / x; // 2 ситуация
                Console.WriteLine("y = {0}", y);
                Console.WriteLine("Блок try выполнился успешно");
            }
            catch (FormatException) // обработка 1 ситуации
            {
                Console.WriteLine("Ошибка. Введено не числовое значение!");
            }
            catch (DivideByZeroException) // обработка 2 ситуации
            {
                Console.WriteLine("Ошибка. Деление на 0!");
            }
            Console.WriteLine("Конец программы");
        }
    }
}
