using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<H_Key,H_Value>
    {
        H_Key[] _keys;    //dizileri tanımlıyoruz.
        H_Value[] _values;
        
        
        public MyDictionary()
        {
            _keys = new H_Key[0];  // yeni bir dizi oluşturulduğunda dizinin eleman sayısı 0 olarak ayarlanır.
            _values = new H_Value[0];
        }

        public void Add(H_Key key, H_Value value)
        {
            H_Value[] _tempValues=_values;//oluşturduğumuz ilk diziyi kaybolmaması için _tempe atarız.
            H_Key[] _tempKeys= _keys;       

           
            _keys = new H_Key[_keys.Length + 1]; //yeni dizi oluşturulur ve eleman sayısı 1 arttırılır.
            _values = new H_Value[_values.Length + 1];
           
            for (int i = 0; i < _tempKeys.Length; i++)
            {
                _keys[i] = _tempKeys[i]; //tempdeki elemanlar diziye aktarılır.
                _values[i] = _tempValues[i];
            }

            _keys[_keys.Length - 1] = key; // eklenen eleman son eleman olarak atılır.
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

