using System;
using System.Collections.Generic;
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
            Map.SetMap(29,40);
            Enemy.EnemyPosPrint(0, 20);
            Player.PlayerPosPrint(29, 20);

            Map.DrawMap();
            while (true)
            {
                Key.GetKey();
                Map.DrawMap();
            }

            Console.WriteLine("dg");
        }
    }
}
