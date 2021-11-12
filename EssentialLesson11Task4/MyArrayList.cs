using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson11Task4
{
    class MyArrayList : IEnumerable
    {

        List<object> list = new List<object>();

        public int Cont => list.Count;
        public object this[int index] => list[index];
        public void Add(object o) => list.Add(o);
        public void Clear() => list.Clear();
        public void AllElToConsole() => list.ForEach(item => Console.WriteLine(item));

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyEnumerator(list);
        }
    }
}
