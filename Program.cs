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
            int result = 0;
            if (x >= 65 && x <= 72)
            {
                //"A"==65; "H"==72
                x -= 65;
                result = 1;
                return result;
            }
            else
            {
                result = 0;
                return result;
            }
        }

        static int TranslateY(ref int y)
        {
            int result = 0;
            if (y >= 49 && y <= 56)
            {
                //"1"==49; "8"==56
                y -= 49;
                result = 1;
                return result;
            }
            else
            {
                result = 0;
                return result;
            }
        }

        static void Main(string[] args)
        {
            Boolean debug;
            Boolean gameOver = false; //not used yet
            int moveCount = 0;
            string request;

            string lastMoveInfo = "";
            int oldX = 0;
            int oldY = 0;
            int newX = 0;
            int newY = 0;
            int TXOresult = 0;
            int TYOresult = 0;
            int TXNresult = 0;
            int TYNresult = 0;
                        
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
                                
                TXOresult = TranslateX(ref oldX);
                TYOresult = TranslateY(ref oldY);
                TXNresult = TranslateX(ref newX);
                TYNresult = TranslateY(ref newY);

                if (TXOresult == 1 && TYOresult == 1 && TXNresult == 1 && TYNresult == 1)
                {
                    //try
                    //{
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
                        if (Move.ValidateMove(oldX, oldY, newX, newY) == 1)
                        {
                            Table.chessTable[newX, newY] = Table.chessTable[oldX, oldY];
                            Table.chessTable[oldX, oldY] = new Figure();
                            Table.chessTable[oldX, oldY].Shape = "   ";
                        }
                        else
                        {
                            lastMoveInfo = lastMoveInfo + " Niedozwolony!";
                        }
                    //}
                    //catch (IndexOutOfRangeException)
                    //{
                    //    lastMoveInfo = "Poprzedni ruch: Niedozwolone dane wejściowe";
                    //}
                }
                else
                {
                    lastMoveInfo = "Poprzedni ruch: Niedozwolone dane wejściowe";
                }
                moveCount++;
            } while (gameOver == false);
            
            Console.ResetColor();
        }
    }
}
