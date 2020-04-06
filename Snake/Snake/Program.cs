using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();   // чтобы не писать много строчек, создали класс и обявили его тут 
            p1.x = 1;                          //(Вместо ****А***** написали только это) 
            p1.y = 3;
            p1.sym = '*';
            p1.Draw(); // Вместо Draw(x1, y1, sym1);


            /* ****А*****
            int x1 = 1;        // Переменные места куда ставим по х
            int y1 = 3;        // Переменные места куда ставим по у
            char sym1 = '*';   // Переменные которой задаем что ставим в ''
            */

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '@';
            p2.Draw();

            Console.WriteLine();
        }
    }
}
