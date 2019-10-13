using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Logic
{
    class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name, int age)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Age = age;
        }
    }
}
