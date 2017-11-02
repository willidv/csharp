using System;

namespace Humans
{
    public class Wizards : Human
    {
        public Wizards(string WizName) : base(WizName)
        {
            health = 50;
            intelligence = 25;
        }
        public void Fireball(object obj)
        {
            Human enemy = obj as Human;
            Random rand = new Random();
            int harm = rand.Next(20, 50);
            enemy.health -= harm;
        }
        public void heal()
        {
            intelligence += 10;
        }
    }
}