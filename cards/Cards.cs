namespace cards{
    public class Card{
        public string stringVal {get; set;}
        public string suit {get; set;}
        public int val{get; set;} 
    
    public Card(string a, string b, int c){
        stringVal = a;
        suit = b;
        val = c;
    }
    }
}