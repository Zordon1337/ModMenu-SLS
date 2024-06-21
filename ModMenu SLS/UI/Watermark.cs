﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ModMenu_SLS.UI
{
    internal class Watermark
    {

        public static void Render()
        {
            GUIStyle style = new GUIStyle();
            style.onNormal.textColor = Color.white;
            style.normal.textColor = Color.white;
            style.onHover.textColor = Color.white;
            style.hover.textColor = Color.white;
            style.onNormal.background = SDK.MakeTexture(2, 2, Color.red);
            style.normal.background = SDK.MakeTexture(2, 2, Color.red);
            style.onHover.background = SDK.MakeTexture(2, 2, Color.red);
            style.hover.background = SDK.MakeTexture(2, 2, Color.red);
            GUILayout.Window(420, new Rect(15, 15, 260, 25), Window, "",SDK.WindowStyle);
        }
        public static void Window(int wid)
        {


            SDK.TextStyle.normal.textColor = Color.black;
            SDK.TextStyle.alignment = TextAnchor.MiddleCenter;
            GUILayout.Label($"ModMenu SLS - {Properties.Resources.BuildDate}",SDK.TextStyle);
        }
    }
}
