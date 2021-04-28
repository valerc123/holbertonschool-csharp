﻿using System;

namespace Enemies
{
    /// <summary> Represents a Zombie </summary>
    public class Zombie
    {
        /// <summary> Represents the health of the Zombie object.</summary>
        private int health;
        /// <summary>Initializes a new instance of the <see cref="Zombie"/>
        /// class and takes <paramref name="value"/></summary>
        public Zombie(int value = 0){
            if (value >= 0){
                this.health = value;
            }else{
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }

        /// <summary> Gets the value of health of the Zombie object </summary>
        /// <returns> health of zombie</returns>
        public int GetHealth() {
            return this.health;
        }
    }
}