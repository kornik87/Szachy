using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy
{    
    class Program
    {           
        static int TranslateX(ref int x)
        {
            if (x > 64 && x < 73)
            {
                //"A"==65; "H"==72
                x -= 65;
                return x;
            }
            else
            {
                Console.WriteLine("Bład: Nieprawidłowa wartosc pozioma");
                return x;
            }
        }

        static int TranslateY(ref int y)
        {
            if (y > 48 && y < 57)
            {
                //"1"==48; "8"==55
                y -= 49;
                return y;
            }
            else
            {
                Console.WriteLine("Bład: Nieprawidłowa wartosc pionowa");
                return y;
            }
        }

        static void Main(string[] args)
        {
            Boolean debug;
            Boolean gameOver;
            string request;
            int oldX;
            int oldY;
            int newX;
            int newY;

            gameOver = false;
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Pokazac adresy pol? (true or false)");
            debug = Convert.ToBoolean(Console.ReadLine());

            Table.InitialPositions();

            do
            {
                Console.Clear(); 
                Table.DrawTable(debug);
                Table.PrintLegend();

                Console.WriteLine("Wprowadz obecna i docelowa pozycje (A1A2)");
                request = Convert.ToString(Console.ReadLine());

                oldX = request[0];
                oldY = request[1];
                newX = request[2];
                newY = request[3];

                TranslateX(ref oldX);
                TranslateY(ref oldY);
                TranslateX(ref newX);
                TranslateY(ref newY);

                if (debug == true)
                {
                    //adress after convert
                    Console.WriteLine("[{0},{1}] -> [{2},{3}]", oldX, oldY, newX, newY);
                    break;
                }

                Table.chessTable[newX, newY] = Table.chessTable[oldX, oldY];
                Table.chessTable[oldX, oldY] = null;


            } while (gameOver == false);
            
            Console.ResetColor();
        }
    }
}
