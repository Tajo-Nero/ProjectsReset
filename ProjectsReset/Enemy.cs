using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsReset
{
    class Enemy
    {
        Bullet Bullet = new Bullet();
        public static int[] EnemyCorePos = { 0, 0 };//적 위치
        public static int[] EnemyLPos = { 0, 0 };
        public static int[] EnemyRPos = { 0, 0 };

        public static char _enemyCore = '0';//적모양
        public static char _enemyLefe = '(';
        public static char _enemyRight = ')';

        public Enemy(int y, int x)
        {
            EnemyCorePos[0] = y; EnemyCorePos[1] = x;
            EnemyLPos[0] = y; EnemyLPos[1] = x - 1;
            EnemyRPos[0] = y; EnemyRPos[1] = x + 1;

            for (int i = 0; i < Map._y; i++)
            {
                for (int j = 0; j < Map._x; j++)
                {
                    if (i == EnemyLPos[0] && j == EnemyLPos[1])
                    {
                        Map._map[i, j] = _enemyLefe;
                    }
                    else if (i == EnemyCorePos[0] && j == EnemyCorePos[1])
                    {
                        Map._map[i, j] = _enemyCore;
                    }
                    else if (i == EnemyRPos[0] && j == EnemyRPos[1])
                    {
                        Map._map[i, j] = _enemyRight;
                    }
                }
            }

            if (EnemyLPos[1] <= Map._x - Map._x)//왼벽에 적 왼날개 닿으면
            {
                EnemyLPos[1] = Map._x + 1;
                EnemyCorePos[1] = Map._x + (Map._x + 1);
            }
            if (EnemyRPos[1] >= Map._x)//오른벽에 적오른날개 닿으면
            {
                EnemyRPos[1] = Map._x - 1;
                EnemyCorePos[1] = Map._x - (Map._x - 1);
            }

        }
        public static void EnemyShot()
        {
            
            for (int i = 0; i < Map._y; i++)
            {
                for (int j = 0; j < Map._x; j++)
                {
                   
                }
            }
        }
    }
}    