﻿using System;

namespace _3.GameEngine
{
    public abstract class GameObject
    {
        protected GameObject(string id)
        {
            this.Id = id;
        }

        public string Id { get; private set; }
    }
}
