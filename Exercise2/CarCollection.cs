using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class CarCollection<T> : IEnumerable<T>
    {
        private const int DefaultLength = 10;
        private T[] _items;
        public int Length { get; private set; } = 0;
        public CarCollection()
        {
            _items = new T[DefaultLength];
        }

        public void Add(T item)
        {
            if (Length == _items.Length)
            {
                T[] temp = new T[Length * 2];
                Array.Copy(_items, temp, Length);
                _items = temp;
            }

            _items[Length++] = item;
        }

        public T this[int index] => _items[index];
        public void Clear() => _items = new T[DefaultLength];
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
