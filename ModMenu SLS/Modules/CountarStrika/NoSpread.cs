﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModMenu_SLS.Modules.CountarStrika
{
    internal class NoSpread
    {
        public static void Run()
        {

            if (SDK.CountarStrika != null && SDK.NoSpread)
            {
                if (SDK.CountarStrika.csPlayer == null)
                    return;

                var CPlayer = SDK.CountarStrika.csPlayer;
                if (CPlayer.kalash == null)
                    return;
                var weapons = SDK.weapons;
                foreach (var wp in weapons)
                {
                    wp.recoilForge = 0;

                }
            }
        }
    }
}
