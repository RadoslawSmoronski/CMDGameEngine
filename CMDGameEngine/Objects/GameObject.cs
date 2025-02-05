﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMDGameEngine.Objects.VisualMap;

// Game Object class, objects used directly in the game, such as background, obstacles or something.

namespace CMDGameEngine.Objects
{
    public class GameObject
    {
        public int X { get; set; }
        public int Y { get; set; }

        public VisualMap.VisualMap? VisualMap { get; private set; }

        public GameObject(int x, int y, VisualMap.VisualMap? visualMap = null)
        {
            X = x;
            Y = y;

            if(visualMap != null)
            {
                VisualMap = visualMap;
            }

            GameObjects.AddObject(this); // Adding object to static GameObjects list
        }

        public void Move(int x, int y)
        {
            X = X + x;
            Y = Y + y;
        }

        public void SetPosition(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void ChangeVisualMap(VisualMap.VisualMap? visualMap)
        {
            VisualMap = visualMap;
        }

    }
}
