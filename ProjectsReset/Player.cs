﻿using System;

namespace ProjectsReset
{
    class Player
    {
        int x;
        int y;
        public static int[] PlayerCorePos = { 28, 19 };//플레이어 위치
        public static int[] PlayerLeftPos = { 28, 18 };
        public static int[] PlayerRightPos = { 28,20  };
        public static int[] PlayerHeadPos = { 27, 19};
        //{상하,좌우}
        public static char _playerCore = 'H';//플레이어모양
        public static char _playerLeft = ')';
        public static char _playerRight = '(';
        public static char _playerHead = '^';

       public static Bullet _bullet;
        public Player(int y,int x)
        {
            this.y = y;
            this.x = x;
            //플레이어 위치
            PlayerCorePos[1] = x; PlayerCorePos[0] = y;
            PlayerLeftPos[1] = x - 1; PlayerLeftPos[0] = y;
            PlayerRightPos[1] = x + 1; PlayerRightPos[0] = y;
            PlayerHeadPos[1] = x; PlayerHeadPos[0] = y - 1;


            //위치에 모양넣기
            for (int i = 0; i < Map._y; i++)
            {
                for (int j = 0; j < Map._x; j++)
                {
                    if (i == PlayerLeftPos[0] && j == PlayerLeftPos[1])
                    {
                        Map._map[i, j] = _playerLeft;
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
        public void MoveLeft()
        {
            
            PlayerPosPrint();
            //PlayerPosPrint();
            //플레이어가 벽에 닿으면 위치 고정
            if (PlayerLeftPos[1] <= Map._x - Map._x)//왼벽에 플레이어 왼날개 닿으면
            {
                PlayerLeftPos[1] = Map._x + 1;
                PlayerCorePos[1] = Map._x + (Map._x + 1);
                PlayerRightPos[1] = Map._x + (Map._x + 2);
                PlayerHeadPos[0] = Map._x + (Map._x + 1);
            }
        }
        public void MoveRight()
        {
            
            PlayerPosPrint();
            if (PlayerRightPos[1] >= Map._x)//오른벽에 플레이어 오른날개 닿으면
            {
                PlayerRightPos[1] = Map._x - 1;//오른날개고정
                PlayerCorePos[1] = Map._x - (Map._x - 1);//코어고정
                PlayerLeftPos[1] = Map._x - (Map._x - 2);
                PlayerHeadPos[0] = Map._x - (Map._x - 1);//머리고정
            }
        }
        public static void PlayerUpDate()
        { 
            Console.Clear();
            _bullet = new Bullet();
            for (int i = 0; i < Map._y; i++)
            {
                   
                if (_bullet.BulletPlayerPos[1] >= 1)//위쪽 끝에 닿으면 총알 사라짐
                {
                    Console.SetCursorPosition(_bullet.BulletPlayerPos[0], _bullet.BulletPlayerPos[1] -= 1);
                    Console.WriteLine(_bullet._bulletPlayer);
                }
                else
                {
                    continue;
                }
                 _bullet.BulltShotPlayerDelimited();
            }
        }

        public void PlayerPosPrint()
        {
            Console.SetCursorPosition(PlayerLeftPos[0]=x-1, PlayerLeftPos[1]=y);
            Console.Write(_playerLeft);
            Console.SetCursorPosition(PlayerCorePos[0] = x, PlayerCorePos[1]=y);
            Console.Write(_playerCore);
            Console.SetCursorPosition(PlayerRightPos[0]=x+1, PlayerRightPos[1]=y);
            Console.Write(_playerRight);
            Console.SetCursorPosition(PlayerHeadPos[0]=x, PlayerHeadPos[1]=y-1);
            Console.Write(_playerHead);


        }      
    }
}
