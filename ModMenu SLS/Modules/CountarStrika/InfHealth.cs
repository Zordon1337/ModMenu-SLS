﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ModMenu_SLS.Modules.CountarStrika
{
    internal class InfHealth
    {
        public static void Run()
        {

            if (SDK.CountarStrika != null && SDK.InfHealth)
            {
                if (SDK.CountarStrika.csPlayer == null)
                    return;

                var CPlayer = SDK.CountarStrika.csPlayer;
                if (CPlayer.kalash == null)
                    return;
                var weapons = SDK.weapons;
                
                CPlayer.health = 420;
                /*foreach(var bot in GameObject.FindObjectsOfType<CounterAi>())
                {
                    if(bot.health == 420)
                    {
                        bot.health = 0;
                    }
                }*/
            }
        }
    }
}
