using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy
{    
    //test commit in feature branch
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
            int moveCount;
            string request;
            string lastMoveInfo;
            int oldX;
            int oldY;
            int newX;
            int newY;
            
            // temp definitions
            gameOver = false; //not used yet
            moveCount = 0;
            lastMoveInfo = "";
            oldX = 0;
            oldY = 0;
            newX = 0;
            newY = 0;
            
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

                if (debug == true)
                {
                    //adress after convert
                    Console.WriteLine("[{0},{1}] -> [{2},{3}]", oldX, oldY, newX, newY);
                }

                if (moveCount != 0)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine(lastMoveInfo);
                    Console.WriteLine("--------------------");
                }

                Console.WriteLine("Wprowadz obecna i docelowa pozycje (np. A1A2)");
                request = Convert.ToString(Console.ReadLine());

                oldX = request[0];
                oldY = request[1];
                newX = request[2];
                newY = request[3];
                
                TranslateX(ref oldX);
                TranslateY(ref oldY);
                TranslateX(ref newX);
                TranslateY(ref newY);
                
                lastMoveInfo = "Poprzedni ruch: "
                    + Table.chessTable[oldX, oldY].Name + "(" + request[0] + request[1] + ")"
                    + " na "
                    + Table.chessTable[newX, newY].Name + "(" + request[2] + request[3] + ")";

                if (debug == true)
                {
                    //adress after convert
                    Console.WriteLine("[{0},{1}] -> [{2},{3}]", oldX, oldY, newX, newY);
                }
                                
                //move!
                Table.chessTable[newX, newY] = Table.chessTable[oldX, oldY];
                Table.chessTable[oldX, oldY] = new Figure();
                Table.chessTable[oldX, oldY].Shape = "   ";

                moveCount++;
            } while (gameOver == false);
            
            Console.ResetColor();
        }
    }
}
