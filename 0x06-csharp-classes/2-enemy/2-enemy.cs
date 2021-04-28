using System;

namespace Enemies
{
    /// <summary> Represents a Zombie </summary>
    public class Zombie
    {
        /// <summary> Represents the health of the Zombie object.</summary>
        public int health;
        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class</summary>
        /// class and takes <paramref name="value"/></summary>
        public Zombie(int value = 0){
            if (value >= 0){
                this.health = value;
            }else{
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }
    }
}

