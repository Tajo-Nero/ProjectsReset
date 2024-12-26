using System;

namespace ProjectsReset
{
    class Player
    {
        public static int[] PlayerCorePos = { 0, 0 };//플레이어 위치
        public static int[] PlayerLeftPos = { 0, 0 };
        public static int[] PlayerRightPos = { 0, 0 };
        public static int[] PlayerHeadPos = { 0, 0 };
        //{상하,좌우}
        public static char _playerCore = '0';//플레이어모양
        public static char _playerLefe = '<';
        public static char _playerRight = '>';
        public static char _playerHead = '1';

       public static Bullet _bullet;
        public Player(int y, int x)
        {
            //플레이어 위치
            PlayerCorePos[1] = x; PlayerCorePos[0] = y;
            PlayerLeftPos[1] = x - 1; PlayerLeftPos[0] = y;
            PlayerRightPos[1] = x + 1; PlayerRightPos[0] = y;
            PlayerHeadPos[1] = x; PlayerHeadPos[0] = y - 1;


            //배열에위치값넣기
            for (int i = 0; i < Map._y; i++)
            {
                for (int j = 0; j < Map._x; j++)
                {
                    if (i == PlayerLeftPos[0] && j == PlayerLeftPos[1])
                    {
                        Map._map[i, j] = _playerLefe;
                    }
                    else if (i == PlayerCorePos[0] && j == PlayerCorePos[1])
                    {
                        Map._map[i, j] = _playerCore;
                    }
                    else if (i == PlayerRightPos[0] && j == PlayerRightPos[1])
                    {
                        Map._map[i, j] = _playerRight;
                    }
                    else if (i == PlayerHeadPos[0] && j == PlayerHeadPos[1])
                    {
                        Map._map[i, j] = _playerHead;
                    }
                }
            }
            
        }
        public static void MoveLeft()
        {
            PlayerCorePos[1] --;
            PlayerLeftPos[1] --;
            PlayerRightPos[1] --;
            PlayerHeadPos[1] --;
            //플레이어가 벽에 닿으면 위치 고정
            if (PlayerLeftPos[1] <= Map._x - Map._x)//왼벽에 플레이어 왼날개 닿으면
            {
                PlayerLeftPos[1] = Map._x + 1;
                PlayerCorePos[1] = Map._x + (Map._x + 1);
                PlayerRightPos[1] = Map._x + (Map._x + 2);
                PlayerHeadPos[0] = Map._x + (Map._x + 1);
            }
        }
        public static void MoveRight()
        {
            PlayerCorePos[1]++;
            PlayerLeftPos[1]++;
            PlayerRightPos[1]++;
            PlayerHeadPos[1]++;

            if (PlayerRightPos[1] >= Map._x)//오른벽에 플레이어 오른날개 닿으면
            {
                PlayerRightPos[1] = Map._x - 1;//오른날개고정
                PlayerCorePos[1] = Map._x - (Map._x - 1);//코어고정
                PlayerLeftPos[1] = Map._x - (Map._x - 2);
                PlayerHeadPos[0] = Map._x - (Map._x - 1);//머리고정
            }
        }
        public static void PlayerBullShot()
        {
            new Bullet();
            Bullet.FireOn();
            Bullet.PlayerBulletShotPos();
            
        }
        
        //public static void PlayerPosPrint(int y, int x)
        //{
        //    PlayerCorePos[1] = x; PlayerCorePos[0] = y;
        //    PlayerLeftPos[1] = x-1; PlayerLeftPos[0] = y;
        //    PlayerRightPos[1] = x+1; PlayerRightPos[0] = y ;
        //    PlayerHeadPos[1] = x; PlayerHeadPos[0] = y-1;
        //
        //    for (int i = 0; i < Map._y; i++)
        //    {
        //        for (int j = 0; j <Map._x; j++)
        //        {
        //            if (i == PlayerLeftPos[0] && j == PlayerLeftPos[1])
        //            {
        //                Map._map[i, j] = _playerLefe;                        
        //            }
        //            else if (i == PlayerCorePos[0] && j == PlayerCorePos[1])
        //            {
        //                Map._map[i, j] = _playerCore;                        
        //            }
        //            else if (i == PlayerRightPos[0] && j == PlayerRightPos[1])
        //            {
        //                Map._map[i, j] = _playerRight;                        
        //            }
        //            else if(i == PlayerHeadPos[0] && j == PlayerHeadPos[1])
        //            {
        //                Map._map[i, j] = _playerHead;                        
        //            }
        //        }
        //    }
        //}
        

    }
}
