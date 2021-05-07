﻿using System;
using StarWing.Framework;
using StarWing.GameObjects.Implementations;
using StarWing.GameObjects.Items;

namespace StarWing.GameObjectModel
{
    public class ShipModel : GameObjectModel
    {
        public float Velocity { get; }
        public int Health { get; }
        public ProjectileFactory ProjectileFactory { get; }
        public TimeSpan CoolDown { get; }

        public ShipModel(Sprite sprite, float velocity, int health, ProjectileFactory projectileFactory, TimeSpan coolDown) : base(sprite)
        {
            Health = health;
            Velocity = velocity;
            ProjectileFactory = projectileFactory;
            CoolDown = coolDown;
        }
    }
}