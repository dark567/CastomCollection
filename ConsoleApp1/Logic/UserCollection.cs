using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Logic
{
    // простая пользовательская коллекция
    public class UserCollection
    {
        readonly List<User> user = new List<User>
        {
            new User(name:"Tom" , age: 27),
            new User(name:"Clark", age:30),
            new User(name:"Serg", age:39)
        };

        int position = -1;

        //реализация IEnumerator
        public bool MoveNext()
        {
            if (position < user.Count-1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
        }
        public object Current
        {
            get { return user[position]; }
        }

        public UserCollection GetEnumerator()
        {
            return this;
        }
    }
}
