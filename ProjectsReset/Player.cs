using System;

namespace ProjectsReset
{
    class Player
    {
        public static int[] PlayerCorePos = { 0 , 0};//플레이어 위치
        public static int[] PlayerLeftPos = { 0, 0 };
        public static int[] PlayerRightPos= { 0, 0 };
        public static int[] PlayerHeadPos= { 0, 0 };
        //{상하,좌우}
        public static char _playerCore = 'a';//플레이어모양
        public static char _playerLefe = 'b';
        public static char _playerRight = 'c';
        public static char _playerHead = 'd';

        public static void PlayerPosPrint(int y, int x)
        {
            PlayerCorePos[1] = x; PlayerCorePos[0] = y;
            PlayerLeftPos[1] = x-1; PlayerLeftPos[0] = y;
            PlayerRightPos[1] = x+1; PlayerRightPos[0] = y ;
            PlayerHeadPos[1] = x; PlayerHeadPos[0] = y-1;

            for (int i = 0; i < Map._y; i++)
            {
                for (int j = 0; j <Map._x; j++)
                {
                    if (i == PlayerLeftPos[0] && j == PlayerLeftPos[1])
                    {
                        Map._map[i, j] = _playerLefe;
                        
                    }
                    else if (i == PlayerCorePos[0] || j == PlayerCorePos[1])
                    {
                        Map._map[i, j] = _playerCore;
                        
                    }
                    else if (i == PlayerRightPos[0] || j == PlayerRightPos[1])
                    {
                        Map._map[i, j] = _playerRight;
                        
                    }
                    else if(i == PlayerHeadPos[0] || j == PlayerHeadPos[1])
                    {
                        Map._map[i, j] = _playerHead;
                        
                    }

                }

            }

        }
    }
}
