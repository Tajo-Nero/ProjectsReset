using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsReset
{
   static class Bullet
    {
        public static int[] BulletPlayerPos 
            = { Player.PlayerCorePos[0]-1 , Player.PlayerCorePos[1] };//플레이어총알 위치
        public static int[] BulletEnemyPos
            = { Enemy.EnemyCorePos[0]+1, Enemy.EnemyCorePos[1] };//적총알 위치
        public static char _bulletPlayer = '0';//총알모양
        public static char _bulletEnemy = '0';//총알모양
        
    }
}
