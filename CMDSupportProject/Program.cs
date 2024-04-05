﻿using CMDGameEngine;

namespace CMDSupportProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> menuOptions = new List<string>();
            menuOptions.Add("Start Game");
            menuOptions.Add("Exit Game");

            GameMenu gameMenu = new GameMenu(menuOptions, "Game snake\nversion\n2.0", "test");

            gameMenu.Show();
        }
    }
}
