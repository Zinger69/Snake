using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;        // Переменные места куда ставим по х
            int y1 = 3;        // Переменные места куда ставим по у
            char sym1 = '*';   // Переменные которой задаем что ставим в ''

            Draw(x1, y1, sym1);

            int x2 = 4;
            int y2 = 5;
            char sym2 = '@';

            Draw(x2, y2, sym2);

            Console.WriteLine();
        }
        static void Draw(int x, int y, char sym) // Функция вывода на экран
        {
            Console.SetCursorPosition(x, y);       
            Console.Write(sym);
        }
    }
}
