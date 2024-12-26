using System;

namespace ProjectsReset
{
    class Bullet
    {
        public static bool _solomon;
        public static int[] BulletPlayerPos
            = { Player.PlayerCorePos[0] - 1, Player.PlayerCorePos[1] };//플레이어총알 위치
        public static int[] BulletEnemyPos
            = { Enemy.EnemyCorePos[0] + 1, Enemy.EnemyCorePos[1] };//적총알 위치
        public static char _bulletPlayer = '|';//총알모양
        public static char _bulletEnemy = '*';//총알모양

        public static void FireOn()
        {
            _solomon = true;
        }
        public static void PlayerBulletShotPos()
        {
            //플레이어 총알 방향
            BulletPlayerPos[0] = Player.PlayerCorePos[0] - 1;
            BulletPlayerPos[1] = Player.PlayerCorePos[1];

            for (int i = 0; i < Map._y; i++)
            {
                for (int j = 0; j < Map._x; j++)
                {
                    if (i == BulletPlayerPos[0] && j == BulletPlayerPos[1])
                    {
                        Map._map[i, j] = _bulletPlayer;
                        Console.Write(Map._map[i,j]);
                    }
                }
            }
        }
        public static void EnemyBulletShotPos()
        {
            //몹 총알 방향
            BulletEnemyPos[0] = Enemy.EnemyCorePos[0] + 1;
            BulletEnemyPos[1] = Enemy.EnemyCorePos[1];
            for (int i = 0; i < Map._y; i++)
            {
                for (int j = 0; j < Map._x; j++)
                {
                    if (i == BulletEnemyPos[0] && j == BulletEnemyPos[1])
                    {
                        Map._map[i, j] = _bulletEnemy;
                    }
                }
            }
        }
        public static void BulltShotPlayerDelimited()
        {
            if (BulletPlayerPos[0] == Enemy.EnemyCorePos[0] && BulletPlayerPos[1] == Enemy.EnemyCorePos[1])
            {
                Map._map[BulletPlayerPos[0], BulletPlayerPos[1]] = Map._space;//적 코어랑 맞으면 총알 사라짐
            }
            else if (BulletPlayerPos[0] <= 1)//위쪽 끝에 다다르면 총알 사라짐
            {
                Map._map[BulletPlayerPos[0], BulletPlayerPos[1]] = Map._space;
                BulletPlayerPos[0] = Player.PlayerCorePos[0] - 1;
                BulletPlayerPos[1] = Player.PlayerCorePos[1];//플레이어 총알 초기화
            }
        }
        public static void BulltShotEnemyDelimited()
        {
            //일단 적 총알이 플레이어 헤드에 맞으면 총알사라짐
            if (BulletEnemyPos[0] == Player.PlayerHeadPos[0] && BulletEnemyPos[1] == Player.PlayerHeadPos[1])
            {
                Map._map[BulletEnemyPos[0], BulletEnemyPos[1]] = Map._space;
                Map._map[Player.PlayerHeadPos[0], Player.PlayerHeadPos[0]] = Map._space;
            }
            else if (BulletEnemyPos[0] >= 28)//몹 총알 밑에 끝에 다다르면 총알 초기화
            {
                Map._map[BulletEnemyPos[0], BulletEnemyPos[1]] = Map._space;
                BulletEnemyPos[0] = Enemy.EnemyCorePos[0] + 1;
                BulletEnemyPos[1] = Enemy.EnemyCorePos[1];
            }

        }
    }
}
