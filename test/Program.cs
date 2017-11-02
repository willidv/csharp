using System;

namespace DBConnection
{
    class Program
    {
        public static void Read(){
            var Users = DbConnector.Query("SELECT * FROM USERS ");
            foreach (var x in Users)
            {
                Console.WriteLine("{0,9} {1,9}", x["first_name"],x["last_name"]);
            }
           
        }
        public static void Create(){
            string first_name = "";
            string last_name = "";
            
            Console.Write("Please enter your first name : ");
            first_name = Console.ReadLine();
            
            Console.Write("Please enter your last name : ");
            last_name = Console.ReadLine();

            string query = $"INSERT INTO users (first_name, last_name, created_at, updated_at) values ('{first_name}', '{last_name}',  NOW(), NOW())";
            DbConnector.Execute(query);
            Read();
        }
        public static void Update(){
            
            string fname = "";
            string lname = "";

            Console.Write("Which user ID would you like to update?: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the new first name? : ");
            fname = Console.ReadLine();
            Console.Write("What is the new last name? : ");
            lname = Console.ReadLine();

            string UpdateQuery = $"UPDATE users SET first_name = '{fname}', last_name = '{lname}' where id = {ID}";
            DbConnector.Execute(UpdateQuery);
            Read();
        }
        public static void Delete(){
            Console.Write("Which user ID would you like to delete?: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            string DeleteQuery = $"Delete from users where id = {ID}";
            DbConnector.Execute(DeleteQuery);
            Read();
        }
        static void Main(string[] args)
        {
           Delete();
        }
    }
}
