using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class ArrayList
    {
        private const int DefaultLength = 10;
        private object[] _items;
        private int _size;
        public ArrayList()
        {
            _items = new object[DefaultLength];
        }

        public int Count() => _size;
        public int Capacity() => _items.Length;

        public int Add(object obj)
        {
            if (_size == _items.Length)
            {
                object[] temp = new object[_size * 2];
                Array.Copy(_items, temp, _size);
                _items = temp;
            }
            _items[_size] = obj;
            return _size++;
        }

        public object this[int index] => _items[index];
    }
}
