using System;
using System.Collections.Generic;
using System.Text;

namespace Dictonary
{
    class MyDictonary<T1,T2>
    {
        T1[] keys;
        T2[] values;
        public MyDictonary()
        {
            keys = new T1[0];
            values = new T2[0];
        }
        public void Add(T1 key,T2 value)
        {
            T1[] tempkeys = keys;
            T2[] tempvalues = values;
            keys = new T1[keys.Length + 1];
            values = new T2[values.Length + 1];
            for (int i = 0; i < tempkeys.Length; i++)
            {
                keys[i] = tempkeys[i];
                values[i] = tempvalues[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;


        }

        public int Count
        {
            get { return keys.Length; }
        

        }

    }
}

