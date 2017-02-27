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
                allowed = QueenMove(oX, oY, nX, nY);
            }
            else if (figureName == "wierza")
            {
                allowed = RockMove(oX, oY, nX, nY);
            }
            else if (figureName == "kon")
            {
                allowed = KnightMove(oX, oY, nX, nY);
            }
            else if (figureName == "goniec")
            {
                allowed = BishopMove(oX, oY, nX, nY);
            }
            else if (figureName == "pion")
            {
                allowed = PawnMove(oX, oY, nX, nY);
            }
            else
            {
                allowed = 0;
            }
            
            return allowed;
        }

        public static int KingMove(int oX, int oY, int nX, int nY)
        {
            //to do:
            //1. roszada
            //2. szach
            //3. zablokowac ruch w to samo miejsce
            //3. sojusznik
            //4. przeszkoda z sojusznika

            //"A"==65; "H"==72
            //"1"==48; "8"==55

            if (
                ((nX - oX) >= -1) && 
                ((nX - oX) <= 1)
                )
            {
                if (
                    ((nY - oY) >= -1) && 
                    ((nY - oY) <= 1)
                    )
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

        public static int QueenMove(int oX, int oY, int nX, int nY)
        {
            //to do:
            //1. sojusznik
            //2. przeszkoda z sojusznika
            //3. zablokowac ruch w to samo miejsce

            //"A"==65; "H"==72
            //"1"==48; "8"==55

            if (
                ((nX > oX) && (nY > oY)) ||
                ((nX < oX) && (nY < oY)) ||
                ((nX > oX) && (nY < oY)) ||
                ((nX < oX) && (nY > oY)) ||
                ((nX - oX) == 0) ||
                ((nY - oY) == 0)
                )
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int RockMove(int oX, int oY, int nX, int nY)
        {
            //to do:
            //1. sojusznik
            //2. przeszkoda z sojusznika
            //3. zablokowac ruch w to samo miejsce

            //"A"==65; "H"==72
            //"1"==48; "8"==55

            if (
                ((nX - oX) == 0) || 
                ((nY - oY) == 0)
                )
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int KnightMove(int oX, int oY, int nX, int nY)
        {
            //to do
            return 1;
        }

        public static int BishopMove(int oX, int oY, int nX, int nY)
        {
            //to do:
            //1. sojusznik
            //2. przeszkoda z sojusznika
            //3. zablokowac ruch w to samo miejsce

            //"A"==65; "H"==72
            //"1"==48; "8"==55

            if (
                ((nX > oX) && (nY > oY)) ||
                ((nX < oX) && (nY < oY)) ||
                ((nX > oX) && (nY < oY)) ||
                ((nX < oX) && (nY > oY))
                )
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int PawnMove(int oX, int oY, int nX, int nY)
        {
            //to do:
            //- bicie
            //- bicie w locie
            //- zablokowac ruch w to samo miejsce
            //- sojusznik
            //- przeszkoda z sojusznika

            //"A"==65; "H"==72
            //"1"==48; "8"==55

            if (
                ((nY - oY) == 1)
                // ((nX - oX) == -1) || ((nX - oX) == 1)) //bicie
                )
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
