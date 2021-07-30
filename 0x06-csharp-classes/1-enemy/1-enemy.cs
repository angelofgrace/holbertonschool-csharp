using System;

namespace Enemies
{ 
    /// <summary> Do you know the enemy? </summary>
    public class Zombie
    {
        /// <summary> Do you know your enemy? </summary>
        public Zombie(int health)
        {
            this.health = 0;
        }
        /// <summary> Health Points counter </summary>
        public int health;
    }
}
