using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    public class MyDictionary<TKey , SValue>
    {
        TKey[] key;
        SValue[] value;

        public MyDictionary()
        {
            key = new TKey[0];
            value = new SValue[0];

        }
        public void Add(TKey Key,SValue Value)
        {
            TKey[] tempkey = key;
            SValue[] tempvalue = value;
            key = new TKey[key.Length + 1];
            value = new SValue[value.Length + 1];

            for (int i = 0; i < tempkey.Length; i++)
            {
                key[i] = tempkey[i];
            }
            for (int i = 0; i < tempvalue.Length; i++)
            {
                value[i] = tempvalue[i];
            }

            key[key.Length - 1] = Key;
            value[value.Length - 1] = Value;

        }
        public int Length
        {
            get { return key.Length; }
        }
        public TKey[] _Key
        {
            get { return key; }
        }
     


    }
}
