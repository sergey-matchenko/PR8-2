using System;

namespace PR_8
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Console.Title = "Практическая работа № 8."; // заголовок
            Console.BackgroundColor = ConsoleColor.Yellow; // цвет фона
            Console.ForegroundColor = ConsoleColor.Black; // цвет текста
            Console.Clear(); // очистка консоли
            try
            {
                int left, fixLeft, right, sum = 0;
                Console.Write("Здравствуйте!\nВведите границы диапазона [a,b] для расчета.\n");
                Console.Write("\ta = ");
                left = Int32.Parse(Console.ReadLine());
                fixLeft = left; // сохранение значения
                Console.Write("\tb = ");
                right = Int32.Parse(Console.ReadLine());
                do // цикл с постусловием
                {
                    sum += left; // накопление суммы
                    left++; // изменение шага, инкремент
                } while (left <= right);
                Console.WriteLine($"Сумма чисел в диапазоне [{fixLeft},{right}] равна {sum}.");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Что-то пошло не так. Ошибка: {ex.Message}.");
            }
            Console.ReadKey();
        }
    }
}
