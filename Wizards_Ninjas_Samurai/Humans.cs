using System;
namespace Humans
{
    public class Human
    {
        public string name { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public int health { get; set; }


        public Human(string person)
        {
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        public Human(string person, int str, int intel, int dex = 3, int hp = 100)
        {
            name = person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }

        public void Attack(object obj)
        {
            Human enemy = obj as Human;
            if (enemy == null)
            {
                Console.WriteLine("Swing and a miss");
            }
            else
            {
                enemy.health -= strength * 5;
            }
        }
    }
}