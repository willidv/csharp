namespace Humans{
    public class Human{
        public string name {get; set;}
        public int strength {get; set;}
        public int intelligence {get; set;}
        public int dexterity {get; set;}
        public int health {get; set;}

        public Human(string a, int b = 3, int c =3, int d = 3, int e = 100){
            name = a;
            strength = b;
            intelligence = c;
            dexterity = d;
            health = e;
        }
        
        public void Attack(Human instance){
            instance.health -= strength * 5;
        
            
        }
    }
        
}