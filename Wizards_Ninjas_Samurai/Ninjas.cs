using System;

namespace Humans
{
    public class Ninja : Human
    {
        public Ninja(string ninName) : base(ninName)
        {
            dexterity = 175;
        }

        public void Steal(Human enemy)
        {
            Attack(enemy);
            health += 10;
        }
        public void Escape()
        {
            health -= 15;
        }
    }
}