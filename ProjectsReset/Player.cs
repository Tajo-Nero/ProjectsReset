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

        public static void PlayerPosPrint(int x, int y)
        {
            PlayerCorePos[1] = x; PlayerCorePos[0] = y;
            PlayerLeftPos[1] = y; PlayerLeftPos[0] = x - 1;
            PlayerRightPos[1] = y; PlayerRightPos[0] = x + 1;
            PlayerHeadPos[1] = y - 1; PlayerHeadPos[0] = x;

            for (int i = 0; i < Map._y; i++)
            {
                for (int j = 0; j <Map._x; j++)
                {
                    if (i == PlayerLeftPos[0] && j == PlayerLeftPos[1])
                    {
                        Map._map[j, i] = _playerLefe;
                        Console.Write(Map._map[i,j]);
                    }
                    else if (i == PlayerCorePos[0] || j == PlayerCorePos[1])
                    {
                        Map._map[j, i] = _playerCore;
                        Console.Write(Map._map[j,i]);
                    }
                    else if (i == PlayerRightPos[0] || j == PlayerRightPos[1])
                    {
                        Map._map[j, i] = _playerRight;
                        Console.Write(Map._map[j, i]);
                    }
                    else if(i == PlayerHeadPos[0] || j == PlayerHeadPos[1])
                    {
                        Map._map[j, i] = _playerHead;
                        Console.Write(Map._map[j, i]);
                    }

                }

            }

        }
    }
}
