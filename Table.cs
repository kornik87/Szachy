using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy
{
    public class Table
    {
        public static Figure[,] chessTable = new Figure[8, 8];

        public static void InitialPositions()
        {
            for (int i = 0; i < 8; i++) //iterate column
            {
                for (int j = 0; j < 8; j++) //iterate row
                {
                    chessTable[i, j] = new Figure();
                }
            }
            
            chessTable[0, 7].Shape = "|\"|";
            chessTable[1, 7].Shape = " % ";
            chessTable[2, 7].Shape = "/-\\";
            chessTable[3, 7].Shape = "I*I";
            chessTable[4, 7].Shape = "/*\\";
            chessTable[5, 7].Shape = "/-\\";
            chessTable[6, 7].Shape = " % ";
            chessTable[7, 7].Shape = "|\"|";
            chessTable[0, 6].Shape = " i ";
            chessTable[1, 6].Shape = " i ";
            chessTable[2, 6].Shape = " i ";
            chessTable[3, 6].Shape = " i ";
            chessTable[4, 6].Shape = " i ";
            chessTable[5, 6].Shape = " i ";
            chessTable[6, 6].Shape = " i ";
            chessTable[7, 6].Shape = " i ";

            chessTable[0, 7].Color = "White";
            chessTable[1, 7].Color = "White";
            chessTable[2, 7].Color = "White";
            chessTable[3, 7].Color = "White";
            chessTable[4, 7].Color = "White";
            chessTable[5, 7].Color = "White";
            chessTable[6, 7].Color = "White";
            chessTable[7, 7].Color = "White";
            chessTable[0, 6].Color = "White";
            chessTable[1, 6].Color = "White";
            chessTable[2, 6].Color = "White";
            chessTable[3, 6].Color = "White";
            chessTable[4, 6].Color = "White";
            chessTable[5, 6].Color = "White";
            chessTable[6, 6].Color = "White";
            chessTable[7, 6].Color = "White";

            chessTable[0, 1].Shape = " i ";
            chessTable[1, 1].Shape = " i ";
            chessTable[2, 1].Shape = " i ";
            chessTable[3, 1].Shape = " i ";
            chessTable[4, 1].Shape = " i ";
            chessTable[5, 1].Shape = " i ";
            chessTable[6, 1].Shape = " i ";
            chessTable[7, 1].Shape = " i ";
            chessTable[0, 0].Shape = "|\"|";
            chessTable[1, 0].Shape = " % ";
            chessTable[2, 0].Shape = "/-\\";
            chessTable[3, 0].Shape = "I*I";
            chessTable[4, 0].Shape = "/*\\";
            chessTable[5, 0].Shape = "/-\\";
            chessTable[6, 0].Shape = " % ";
            chessTable[7, 0].Shape = "|\"|";

            chessTable[0, 1].Color = "Black";
            chessTable[1, 1].Color = "Black";
            chessTable[2, 1].Color = "Black";
            chessTable[3, 1].Color = "Black";
            chessTable[4, 1].Color = "Black";
            chessTable[5, 1].Color = "Black";
            chessTable[6, 1].Color = "Black";
            chessTable[7, 1].Color = "Black";
            chessTable[0, 0].Color = "Black";
            chessTable[1, 0].Color = "Black";
            chessTable[2, 0].Color = "Black";
            chessTable[3, 0].Color = "Black";
            chessTable[4, 0].Color = "Black";
            chessTable[5, 0].Color = "Black";
            chessTable[6, 0].Color = "Black";
            chessTable[7, 0].Color = "Black";

            for (int i = 0; i < 8; i++) //iterate column
            {
                for (int j = 0; j < 8; j++) //iterate row
                {
                    if (chessTable[i, j].Shape == null)
                        chessTable[i, j].Shape = "   ";
                }
            }
        }

        public static void DrawTable(bool debug)
        {
            int[] axisY = { 1, 2, 3, 4, 5, 6, 7, 8 };
            string[] axisX = { " * ", " A ", " B ", " C ", " D ", " E ", " F ", " G ", " H ", " * " };

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(axisX[0] + axisX[1] + axisX[2] + axisX[3] + axisX[4] + axisX[5] + axisX[6] + axisX[7] + axisX[8] + axisX[9]);
            Console.WriteLine(); //EOL

            for (int j = 7; j >= 0; j--) //iterate row
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Write(" " + axisY[j] + " ");

                if (j % 2 == 0) //iterate even row (starting from 0)
                {
                    for (int i = 0; i < 8; i++) //iterate column
                    {
                        if (i % 2 == 0) //iterate even column (starting from 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.White;
                            if (debug == true)
                            {
                                Console.Write("{0},{1}", i, j); //debug
                            }
                            else
                            {
                                if (chessTable[i, j].Color == "White")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }
                                else if (chessTable[i, j].Color == "Black")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                }
                                Console.Write(chessTable[i, j].Shape);
                            }
                        }
                        else //iterate odd column (starting from 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.Black;
                            if (debug == true)
                            {
                                Console.Write("{0},{1}", i, j); //debug
                            }
                            else
                            {
                                if (chessTable[i, j].Color == "White")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }
                                else if (chessTable[i, j].Color == "Black")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                }
                                Console.Write(chessTable[i, j].Shape);
                            }
                        }
                    }
                }
                else //iterate odd row
                {
                    for (int i = 0; i < 8; i++) //iterate column
                    {
                        if (i % 2 == 0) //iterate through even column (starting from 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.Black;
                            if (debug == true)
                            {
                                Console.Write("{0},{1}", i, j); //debug
                            }
                            else
                            {
                                if (chessTable[i, j].Color == "White")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }
                                else if (chessTable[i, j].Color == "Black")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                }
                                Console.Write(chessTable[i, j].Shape);
                            }
                        }
                        else //iterate through odd column (starting from 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.White;
                            if (debug == true)
                            {
                                Console.Write("{0},{1}", i, j); //debug
                            }
                            else
                            {
                                if (chessTable[i, j].Color == "White")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }
                                else if (chessTable[i, j].Color == "Black")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                }
                                Console.Write(chessTable[i, j].Shape);
                            }
                        }
                    }
                }

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Write(" " + axisY[j] + " ");
                Console.WriteLine(); //EOL
            }

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(axisX[0] + axisX[1] + axisX[2] + axisX[3] + axisX[4] + axisX[5] + axisX[6] + axisX[7] + axisX[8] + axisX[9]);
            Console.WriteLine(); //EOL
        }

        public static void PrintLegend()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            //king/krol -    I*I
            //queen/krolowa - /*\
            //rock/wierza -  |"|
            //knight/kon -     .%.
            //bishop/goniec -  /-\
            //pawn/pion -     i

            Console.WriteLine();
            Console.WriteLine("Legenda:");
            Console.WriteLine();
            Console.WriteLine("krol -    I*I");
            Console.WriteLine("krolowa - /*\\");
            Console.WriteLine("wierza -  |\"|");
            Console.WriteLine("kon -     .%.");
            Console.WriteLine("goniec -  /-\\");
            Console.WriteLine("pion -     i");

            Console.WriteLine();
        }

    }
}
