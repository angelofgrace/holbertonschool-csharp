using System;

namespace Enemies
{ 
    /// <summary> Do you know the enemy? </summary>
    public class Zombie
    {        
        /// <summary> Health Points counter </summary>
        public int health;
        
        /// <summary> Do you know your enemy? </summary>
        public Zombie(int value)
        {
            if (value < 0 && value != null)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            this.health = value;
        }

    }
}
