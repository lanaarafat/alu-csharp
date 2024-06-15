using System;

namespace Enemies
{
    class Zombie
    {
        private int health;
        public Zombie()
        {
            health = 0;
        }
        public Zombie(int value)
        {
            if (value >= 0)
                this.health = value;
            else if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
        }
        private string name = "(No name)";
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int GetHealth()
        {
            return(this.health);
        }
    }
}