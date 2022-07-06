﻿using Microsoft.Xna.Framework;
using StardewValley.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicReflections.Framework.Models
{
    internal class Mirror
    {
        public Point TilePosition { get { return _tilePosition; } set { _tilePosition = value; WorldPosition = new Vector2(value.X, value.Y) * 64f; } }
        internal Point _tilePosition;
        public Vector2 WorldPosition { get; set; }
        public Rectangle Dimensions { get; set; }
        public float ReflectionScale { get; set; }
        public Color ReflectionOverlay { get; set; }
        public Vector2 ReflectionOffset { get; set; }

        public bool IsEnabled { get; set; }
        public Vector2 PlayerReflectionPosition { get; set; }
        public Furniture? FurnitureLink { get; set; }
    }
}
