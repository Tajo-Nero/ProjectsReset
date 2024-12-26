using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsReset
{
    class Key : Program
    {
        public static void GetKey()
        {
            ConsoleKeyInfo isKey;
            while (true)
            {
                isKey = Console.ReadKey(true);
                SwitchKey(isKey);
            }

        }
        static void SwitchKey(ConsoleKeyInfo input)
        {
            if (input.Key == ConsoleKey.A)
            {
                Player.PlayerCorePos[1]--;
                Player.PlayerLeftPos[1]--;
                Player.PlayerRightPos[1]--;
                Player.PlayerHeadPos[1]--;
            }
            else if (input.Key == ConsoleKey.D)
            {
                Player.PlayerCorePos[1]++;
                Player.PlayerLeftPos[1]++;
                Player.PlayerRightPos[1]++;
                Player.PlayerHeadPos[1]++;
            }
            //공격 종료키도 입력해줄꺼임

        }
    }
}
