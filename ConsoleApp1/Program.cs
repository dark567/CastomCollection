using ConsoleApp1.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// Реализация кастомной коллекции без IEnumerable и IEmumerator
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var users = new UserCollection();

            foreach (User item in users)
            {
                Console.WriteLine($"{item.Id}\t{item.Name}\t{item.Age}");
            }
            Console.ReadKey();
        }
    }
}
