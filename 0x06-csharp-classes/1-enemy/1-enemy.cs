﻿using System;

namespace Enemies
{ 
    /// <summary> Do you know the enemy? </summary>
    public class Zombie
    {        
        /// <summary> Health Points counter </summary>
        public int health;
        
        /// <summary> Do you know your enemy? </summary>
        public Zombie(int health = 0)
        {
            this.health = health;
        }

    }
}
