using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Logic
{
    class UserCollection
    {
        List<User> users = new List<User>
        {
            new User(name: "Tom", age:37),
            new User(name: "Clark", age:15),
            new User(name: "Nick", age:20),
            new User(name: "White", age:40),
            new User(name: "Smite", age:21),
        };

        int position = -1;

        public IEnumerator GetEnumerator()
        {
            //---------------- 1 вариант
            //while (true)
            //{
            //    if (position < users.Count - 1)
            //    {
            //        position++;
            //        yield return users[position];
            //    }
            //    else
            //    {
            //        Reset();
            //        yield break;
            //    }
            //}

            //---------------- 2 вариант
            //foreach (var item in users)
            //{
            //    yield return item;
            //}

            //---------------- 3 вариант
            return users.GetEnumerator();
        }

        private void Reset()
        {
            position = -1;
        }
    }
}
