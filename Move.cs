using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy
{
    public class Move
    {
        //king/krol -    I*I
        //queen/krolowa - /*\
        //rock/wierza -  |"|
        //knight/kon -     .%.
        //bishop/goniec -  /-\
        //pawn/pion -     i


        public static int ValidateMove(int oX, int oY, int nX, int nY)
        {
            //"A"==65; "H"==72
            //"1"==48; "8"==55

            int allowed = 1;
            string figureName = Table.chessTable[oX, oY].Name;

            if (figureName == "krol")
            {
                allowed = KingMove(oX, oY, nX, nY);
            }
            else if (figureName == "krolowa")
            {
                QueenMove();
            }
            else if (figureName == "wierza")
            {
                RockMove();
            }
            else if (figureName == "kon")
            {
                KnightMove();
            }
            else if (figureName == "goniec")
            {
                BishopMove();
            }
            else if (figureName == "pion")
            {
                PawnMove();
            }
            else
            {
                allowed = 0;
            }
            
            return allowed;
        }

        public static int KingMove(int nX, int nY, int oX, int oY)
        {
            //to do

            //"A"==65; "H"==72
            //"1"==48; "8"==55

            if (nX == oX + 1 || nX == oX || nX == oX - 1)
            {
                if (nY == oY + 1 || nY == oY || nY == oY - 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        public static void QueenMove()
        {
            //to do
        }

        public static void RockMove()
        {
            //to do
        }

        public static void KnightMove()
        {
            //to do
        }

        public static void BishopMove()
        {
            //to do
        }

        public static void PawnMove()
        {
            //to do
        }
    }
}
