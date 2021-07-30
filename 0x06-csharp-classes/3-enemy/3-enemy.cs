using System;

namespace Enemies
{ 
    /// <summary> Do you know the enemy? </summary>
    public class Zombie
    {        
        /// <summary> Health Points counter </summary>
        public int health;
        
        /// <summary> Do you know your enemy? </summary>
        public Zombie(int? value = 0)
        {
            if (value < 0 || value.HasValue != false)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            this.health = value.GetValueOrDefault;
        }

        /// <summary> Health Point count retriever </summary>
        public int GetHealth()
        {
            return this.health;
        }

    }
}
