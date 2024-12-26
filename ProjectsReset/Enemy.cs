using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsReset
{
   static class Enemy
    {
        public static int[] EnemyCorePos = {0,0};//적 위치
        public static int[] EnemyLPos = { 0, 0 };
        public static int[] EnemyRPos = { 0, 0 };

        public static char _enemyCore = 'z';//적모양
        public static char _enemyLefe = 'x';
        public static char _enemyRight = 'c';

        public static void EnemyPosPrint(int x, int y)
        {
            EnemyCorePos[0] = y; EnemyCorePos[1] = x;
            EnemyLPos[0] = y; EnemyLPos[1] = x-1;
            EnemyRPos[0] = y; EnemyRPos[1] = x+1;

            for (int i = 0; i < Map._y; i++)
            {
                for (int j = 0; j < Map._x; j++)
                {
                    if (i == EnemyLPos[0] && j == EnemyLPos[1])
                    {
                        Map._map[j,i] = _enemyLefe;
                        Console.Write(Map._map[j, i]);
                    }
                    else if (i == EnemyCorePos[0] && j == EnemyCorePos[1])
                    {
                        Map._map[j, i] = _enemyCore;
                        Console.Write(Map._map[j, i]);
                    }
                    else if (i == EnemyRPos[0] && j == EnemyRPos[1])
                    {
                        Map._map[j, i] = _enemyRight;
                        Console.Write(Map._map[j, i]);
                    }
                }
            }

        }
    }
}
