using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Bullet._solomon = false;
            Map map=new Map();
            Player player;
            Enemy enemy;
            Map.SetMap(29,40);
            ConsoleKeyInfo isKey;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //Enemy.EnemyPosPrint(0, 20);
            //Player.PlayerPosPrint(29, 20);


            while (true)
            {
                if (Console.KeyAvailable)
                {
                    isKey = Console.ReadKey(true);
                    if (isKey.Key == ConsoleKey.Spacebar)
                    {
                        
                        Player.PlayerBullShot();
                    }
                    else if (isKey.Key == ConsoleKey.A)
                    {
                        Player.MoveLeft();
                    }
                    else if (isKey.Key == ConsoleKey.D)
                    {
                        Player.MoveRight();
                    }

                }
                if (stopwatch.ElapsedMilliseconds > 100)
                {
                    
                  stopwatch.Restart();
                }
                    Map.DrawMap();






            }

            
        }
    }
}
