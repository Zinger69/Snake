using System;
using System.Collections.Generic;


namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*'); 
            p1.Draw(); 

            Point p2 = new Point(4, 5, '@');
            p2.Draw();

            List<int> numList = new List<int>(); // создание списка
            numList.Add(0);  // добваление елемента (целого числа) 0 в список numList
            numList.Add(1);  // добваление елемента (целого числа) 1 в список numList
            numList.Add(2);  // добваление елемента (целого числа) 2 в список numList

            int x = numList[0]; //нумерация начинаеться с 0
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList) // чтобы пройти по всем елементам списка
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0); //Удалить елемент с порядковым номером 0, то есть первый елемент спика 

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            Console.WriteLine();
        }
    }
}
