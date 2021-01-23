using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<H_Key,H_Value>
    {
        H_Key[] _keys;    //dizileri tanımlıyoruz.
        H_Key[] _tempKeys;
        H_Value[] _values;
        H_Value[] _tempValues;

        public MyDictionary()
        {
            _keys = new H_Key[0];  // yeni bir dizi oluşturulduğunda dizinin eleman sayısı 0 olarak ayarlanır.
            _values = new H_Value[0];
        }

        public void Add(H_Key key, H_Value value)
        {
            _tempKeys = _keys; //oluşturduğumuz ilk diziyi kaybolmaması için _tempKeyse atarız.
            _tempValues = _values;

           //key anahtarı için
            _keys = new H_Key[_keys.Length + 1]; //yeni dizi oluşturulur ve eleman sayısı 1 arttırılır.

            for (int i = 0; i < _tempKeys.Length; i++)
            {
                _keys[i] = _tempKeys[i]; //tempdeki elemanlar diziye aktarılır.
            }

            _keys[_keys.Length - 1] = key; // eklenen eleman son eleman olarak atılır.

            //values için
            for (int i = 0; i < _tempValues.Length; i++)
            {
                _values[i] = _tempValues[i];
            }
            _values[_values.Length - 1] = value;

        }

        public H_Key[] Keys
        {
            get { return _keys; }
        }
        public H_Value[] Values
        {
            get { return _values; }
        }


    }

    }

