using System;

namespace ProjectsReset
{
    class Map
    {
        
       public static int _y;//세로길이 행

       public static int _x;//가로길이 열

        public static char[,] _map;  

       public static char _wall = '|';
       public static char _space = ' ';
        public static void SetMap(int y, int x)
        {
            _x = x;
            _y = y;
            _map = new char[_y, _x];
        }
        public static void DrawMap()
        {
            Console.Clear();
                    Player player = new Player(28,19);
            _map = new char[_y,_x];    
            //맵구현
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
                    //Enemy enemy = new Enemy();
                    //enemy.EnemyPosPrint();
                    //player.PlayerPosPrin();
                    Console.Write(_map[i, j]);
                }
                Console.WriteLine();
            }
        }
        
    }
        
}

