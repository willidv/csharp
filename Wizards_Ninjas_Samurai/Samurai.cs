using System;
namespace Humans
{
    public class Samurai : Human
    {
        public Samurai(string SamName) : base(SamName)
        {
            health = 200;

        }
        public void death_blow(Human enemy)
        {
            Attack(enemy);
            int harm = 50;
            enemy.health -= harm;
        }
        public void meditate()
        {
            health = 200;
        }
    }

}