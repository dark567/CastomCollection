using ConsoleApp3.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new UserCollection();

            foreach (User item in users)
            {
                Console.WriteLine($"{item.Id},\t{item.Name},\t{item.Age}");
            }

            Console.ReadLine();
        }
    }
}
