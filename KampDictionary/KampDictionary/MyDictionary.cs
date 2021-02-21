using System;
using System.Collections.Generic;
using System.Text;

namespace KampDictionary
{
        class MyDictionary<K, V>
        {
            K[] _keys;
            K[] _tempKeys;

            V[] _values; // V tipinde array
            V[] _tempValues; //V tipinde gecici array

            public MyDictionary()
            {
                //0 elemanlı arraylerimizi oluşturduk
                _keys = new K[0];
                _values = new V[0];
            }

            public void Add(K key, V value)
            {
                _tempKeys = _keys;
                _tempValues = _values;
                _keys = new K[_keys.Length + 1];
                _values = new V[_values.Length + 1];

                for (int i = 0; i < _tempKeys.Length; i++)
                {
                    _keys[i] = _tempKeys[i];       //_keys ve _values elemanlarını geçici dizilere attık
                    _values[i] = _tempValues[i];
                }

                _keys[_keys.Length - 1] = key;       // _keys in son elemanı = yeni eklenen item
                _values[_values.Length - 1] = value; // _values in son elemanı = yeni eklenen item
            }
            public void Liste()
            {
                for (int i = 0; i < _keys.Length; i++)
                {
                    Console.WriteLine(_keys[i] + " " + _values[i]); //_keys ve _values değerleri listelendi
                }
            }



        }
}
