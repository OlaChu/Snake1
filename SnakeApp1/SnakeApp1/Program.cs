using System;
using System.Collections.Generic;

namespace SnakeApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine(Console.LargestWindowWidth);
            Console.WriteLine(Console.LargestWindowHeight);
            

            //Console.SetBufferSize(214, 51);

            

            // Отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0,'+');
            VerticalLine rightLine = new VerticalLine(0, 24, 0, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();


            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            p.Draw();

            Emploee e = new Emploee();
            e.age = 42;
            e.pay = 30000;
        }

    }
}
