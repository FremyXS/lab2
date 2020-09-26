using System;
using System.Data;

namespace lab02_ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите шахматную фигуру:");
            int ShahFig;
            Console.WriteLine("Король - 1, Ферзь - 2, Ладья - 3, Слон - 4, Конь - 5, Пешка - 6 ");
            do
            {
                ShahFig = Convert.ToInt32(Console.ReadLine());
                if (ShahFig < 1 || ShahFig > 6)
                    Console.WriteLine("Нет такой фигуры. Попробуйте ещё раз");
                else
                    break;
            } while (ShahFig < 1 || ShahFig > 6);
            Console.WriteLine("Введите начальные координаты:\nПо горизонтали - ABCDEFGH\nПо вертикали - 12345678\nПример C5");
            int StartVert = 0;
            int StartHoriz = 0;
            ChekKoord(ref StartHoriz, ref StartVert);
            Console.WriteLine("Введите конечные координаты:\nПо горизонтали - ABCDEFGH\nПо вертикали - 12345678\nПример C5");
            int EndHoriz = 0;
            int EndVert = 0;
            ChekKoord(ref EndHoriz, ref EndVert);
            if (ShahFig == 1)
                Korol(StartHoriz, EndHoriz, StartVert, EndVert);
            else if (ShahFig == 2)
                Ferz(StartHoriz, EndHoriz, StartVert, EndVert);
            else if (ShahFig == 3)
                Lad(StartHoriz, EndHoriz, StartVert, EndVert);
            else if (ShahFig == 4)
                Slon(StartHoriz, EndHoriz, StartVert, EndVert);
            else if (ShahFig == 5)
                Kon(StartHoriz, EndHoriz, StartVert, EndVert);
            else if (ShahFig == 6)
                Peshka(StartHoriz, EndHoriz, StartVert, EndVert);
        }
        static void ChekKoord(ref int x, ref int y) //x - StartHoriz, y - StartVert
        {
            string Koord;
            int goriz;
            int vert;
            do
            {
                Koord = Console.ReadLine();
                goriz = Convert.ToInt16(Koord[0]);
                vert = Convert.ToInt32(Convert.ToString(Koord[1]));
                if (goriz < 65 || goriz > 72 || vert < 1 || vert > 8)
                    Console.WriteLine("Не верно. Попробуй ещё раз.");
                else
                {
                    x += goriz;
                    y += vert;
                    break;
                }
            } while (goriz < 65 || goriz > 72 || vert < 1 || vert > 8);
        }
        static void Korol(int x1, int x2, int y1, int y2) //x1 - StartHoriz, x2 -EndHoriz, y1 - StartVert, y2 - EndVert
        {
            int razngor = Math.Abs(x1 - x2);
            int raznver = Math.Abs(y1 - y2);
            if (razngor == 1 && raznver == 1)
                Console.WriteLine("Верно");
            else if (razngor == 0 && raznver == 1)
                Console.WriteLine("Верно");
            else if (razngor == 1 && raznver == 0)
                Console.WriteLine("Верно");
            else
                Console.WriteLine("Не верно");
        }
        static void Kon(int x1, int x2, int y1, int y2) //x1 - StartHoriz, x2 -EndHoriz, y1 - StartVert, y2 - EndVert
        {
            int razngor = Math.Abs(x1 - x2);
            int raznver = Math.Abs(y1 - y2);
            if (razngor == 1 && raznver == 2)
                Console.WriteLine("Верно");
            else if (razngor == 2 && raznver == 1)
                Console.WriteLine("Верно");
            else
                Console.WriteLine("Не верно");
        }
        static void Ferz(int x1, int x2, int y1, int y2) //x1 - StartHoriz, x2 -EndHoriz, y1 - StartVert, y2 - EndVert
        {
            int razngor = Math.Abs(x1 - x2);
            int raznver = Math.Abs(y1 - y2);
            if (razngor == 0 && raznver > 0)
                Console.WriteLine("Верно");
            else if (raznver == 0 && razngor > 0)
                Console.WriteLine("Верно");
            else if (razngor != 0 && raznver != 0 && razngor == raznver)
                Console.WriteLine("Верно");
            else
                Console.WriteLine("Не верно");
        }
        static void Lad(int x1, int x2, int y1, int y2) //x1 - StartHoriz, x2 -EndHoriz, y1 - StartVert, y2 - EndVert
        {
            int razngor = Math.Abs(x1 - x2);
            int raznver = Math.Abs(y1 - y2);
            if (razngor == raznver && raznver != 0 && razngor != 0)
                Console.WriteLine("Верно");
            else
                Console.WriteLine("Не верно");
        }
        static void Slon(int x1, int x2, int y1, int y2) //x1 - StartHoriz, x2 -EndHoriz, y1 - StartVert, y2 - EndVert
        {
            int razngor = Math.Abs(x1 - x2);
            int raznver = Math.Abs(y1 - y2);
            if (razngor == 0 && raznver > 0)
                Console.WriteLine("Верно");
            else if (razngor > 0 && raznver == 0)
                Console.WriteLine("Верно");
            else
                Console.WriteLine("Не верно");
        }
        static void Peshka(int x1, int x2, int y1, int y2) //x1 - StartHoriz, x2 -EndHoriz, y1 - StartVert, y2 - EndVert
        {
            int razngor = Math.Abs(x1 - x2);
            int raznver = Math.Abs(y1 - y2);
            if (y1 == 2)
            {
                if (razngor == 0 && raznver == 2)
                    Console.WriteLine("Верно");
                else if (razngor == 0 && raznver == 1)
                    Console.WriteLine("Верно");
                else
                    Console.WriteLine("Не верно");
            }
            else if (y1 == 1)
                Console.WriteLine($"Не верные начальные координаты");
            else
            {
                if (razngor == 0 && raznver == 1)
                    Console.WriteLine("Верно");
                else
                    Console.WriteLine("Не верно");
            }
        }
    }
}
