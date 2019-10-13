using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Создание простой пользовательской коллекции с использованием обобщенных интерфейсов
/// </summary>
namespace ConsoleApp2.Logic
{
    /// <summary>
    /// класс представляющий собой пользовательскую коллекцию с ковариантными интерфейсами(out)
    /// </summary>
    public class UserCollection<T> : IEnumerable<T>, IEnumerator<T>
    {
        //readonly List<User> users = new List<User>
        //{
        //    new User(name: "Dan", age: 33),
        //    new User(name: "Micky", age: 18),
        //    new User(name: "Stone", age: 45)
        //};

        readonly T[] elements = new T[4];

        public T this[int index]
        {
            get { return elements[index]; }
            set { elements[index] = value; }
        }


        int position = -1;
        object IEnumerator.Current => elements[position];

        public T Current => elements[position];

        // T IEnumerator<T>.Current => users[position];

        bool IEnumerator.MoveNext()
        {
            if (position < elements.Length - 1)
            {
                position++;
                return true;
            }
    
            return false;
        }

        void IEnumerator.Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return this;
        }

        public void Dispose()
        {
            ((IEnumerator)this).Reset();
        }
    }
}
