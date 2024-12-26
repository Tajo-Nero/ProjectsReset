using System;

namespace ProjectsReset
{
    class Map
    {
        
       public static int _y =0;//세로길이 행

       public static int _x =0;//가로길이 열

        public static char[,] _map;  

        static char _wall = 'ㅁ';
        static char _space = ' ';
        public static void SetMap(int x, int y)
        {
            _x = y;
            _y = x;
            _map = new char[_y, _x];
        }
        public static void DrawMap()
        {
            Console.Clear();

            _map = new char[_y,_x];
            //적이 벽에 닿으면 위치 고정
            if (Enemy.EnemyLPos[1] <= _x - _x)//왼벽에 적 왼날개 닿으면
            {
                Enemy.EnemyLPos[1] = _x + 1;
                Enemy.EnemyCorePos[1] = _x + (_x + 1);
            }
            if (Enemy.EnemyRPos[1] >= _x)//오른벽에 적오른날개 닿으면
            {
                Enemy.EnemyRPos[1] = _x - 1;
                Enemy.EnemyCorePos[1] = _x - (_x -1);
            }
            
        
            //플레이어가 벽에 닿으면 위치 고정
            if (Player.PlayerLeftPos[1] <= _x - _x)//왼벽에 플레이어 왼날개 닿으면
            {
                Player.PlayerLeftPos[1] = _x + 1;
                Player.PlayerCorePos[1] = _x + (_x + 1);
                Player.PlayerHeadPos[0] = _x + (_x + 1);
            }
            if (Player.PlayerRightPos[1] >= _x)//오른벽에 플레이어 오른날개 닿으면
            {
                Player.PlayerRightPos[1] = _x - 1;
                Player.PlayerCorePos[1] = _x - (_x - 1);
                Player.PlayerHeadPos[0] = _x - (_x - 1);
            }
            
            Player.PlayerPosPrint(29, 20);
            Enemy.EnemyPosPrint(0, 20);
        
            for (int i = 0; i < _y; i++)
            {

                for (int j = 0; j < _x; j++)
                {
                                 
                    if (j == 0 || j == _x - 1)
                    { _map[i,j] = _wall; }
                    else
                    { _map[i, j] = _space; }
                }
            }
            //출력하는 반복문
            for (int i = 0; i < _y; i++)
            {
                for (int j = 0; j < _x; j++)
                {
                    Console.Write(_map[i, j]);
                }
                Console.WriteLine();
            }
        }
        
    }
        
}

