using System;

namespace Enemies
{
    /// <summary> Represents a Zombie </summary>
    public class Zombie
    {
        /// <summary> Represents the health of the Zombie object.</summary>
        private int health;
        /// <summary> Represents the name of the Zombie.</summary>

        private string name = "(No name)";
        /// <summary>Initializes a new instance of the <see cref="Zombie"/>
        /// class and takes <paramref name="value"/></summary>
        public Zombie(int value = 0){
            if (value >= 0){
                this.health = value;
            }else{
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }

        /// <summary> Getter and setter the name of the Zombie </summary>
        public string Name
        {
            get => this.name;
            set => this.name = value;
        }
        /// <summary> Gets the value of health of the Zombie object </summary>
        /// <returns> health of zombie</returns>
        public int GetHealth() {
            return this.health;
        }
        /// <summary> override ToString method </summary>
        public override string ToString(){
            return "Zombie Name: " + this.name + " / Total Health: " + this.health;
        }  
    }
}

