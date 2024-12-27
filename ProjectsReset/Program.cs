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
            Map.SetMap(29,40);
            Enemy enemy=new Enemy(0,19);
            Player player =new Player(28,19);
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
                        Player.PlayerUpDate();
                        Enemy.EnemyShot();
                    }
                    else if (isKey.Key == ConsoleKey.A)
                    {
                        player.MoveLeft();
                    }
                    else if (isKey.Key == ConsoleKey.D)
                    {
                        player.MoveRight();
                    }

                }
                if (stopwatch.ElapsedMilliseconds > 100)
                {
                  Map.DrawMap();
                 // player.PlayerPosPrint();
                  enemy.EnemyPosPrint();
                  stopwatch.Restart();
                }






            }

            
        }
    }
}
