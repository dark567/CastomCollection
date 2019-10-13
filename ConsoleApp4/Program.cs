using ConsoleApp4.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            var users = new UserCollection<User>();

            users[0] = new User(name: "Tom", age: 15);
            users[1] = new User(name: "Clark", age: 35);
            users[2] = new User(name: "Jone", age: 40);
            users[3] = new User(name: "Whilson", age: 20);


            foreach (User item in users)
            {
                Console.WriteLine($"{item.Id},\t{item.Name},\t{item.Age}");
            }

            Console.ReadKey();
        }
    }
}
