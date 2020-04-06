using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public void Draw()  //Вместо того чтобы писать функцию в коде , можем прописать ее в классе.
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
