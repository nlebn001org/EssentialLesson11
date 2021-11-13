using System.Collections.Generic;

namespace EssentialLesson11Task3
{
    class MyDictionary<TKey, TValue> : Dictionary<TKey, TValue>
    {
        TKey key;
        TValue value;
        public override string ToString()
        {
            return $"{key.ToString()}:{value.ToString()}";
        }
    }
}
