using ConsoleApp2.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new UserCollection<User>();

            users[0] = new User(name: "Tom", age: 37);
            users[1] = new User(name: "Clark", age: 15);
            users[2] = new User(name: "Micki", age: 40);
            users[3] = new User(name: "Jone", age: 10);

            Console.WriteLine("foreach");

            foreach (User item in users)
            {
                Console.WriteLine($"{item.Id},\t{item.Name},\t{item.Age}");
            }

            Console.WriteLine("for");

            for (int i = 0; i < users.Count(); i++)
            {
                Console.WriteLine($"{users[i].Id},\t{users[i].Name},\t{users[i].Age}");
            }

            Console.ReadKey();
        }
    }
}
