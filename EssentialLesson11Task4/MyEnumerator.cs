using System.Collections;
using System.Collections.Generic;

namespace EssentialLesson11Task4
{
    class MyEnumerator : IEnumerator
    {

        int index = -1;
        List<object> list;

        public MyEnumerator(List<object> list) => this.list = list;

        public object Current => list[index];

        public bool MoveNext()
        {
            index++;
            return (index >= list.Count) ? false : true;
        }

        public void Reset() => index = -1;
    }
}
