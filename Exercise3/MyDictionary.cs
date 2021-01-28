using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class MyDictionary<TKey, TValue>
    {
        private Entity[] _entities;
        public int Length { get; private set; } = 0;

        public MyDictionary()
        {
            _entities = new Entity[10];
        }

        public TValue this[TKey key]
        {
            get
            {
                TValue result = default;
                for (int i = 0; i < Length; i++)
                {
                    if (key.Equals(_entities[i].Key))
                    {
                        result = _entities[i].Value;
                    }
                }

                return result;
            }
        }

        public void Add(TKey key, TValue value)
        {
            if (Length == _entities.Length)
            {
                Entity[] temp = new Entity[_entities.Length * 2];
                Array.Copy(_entities, temp, _entities.Length);
                _entities = temp;
            }

            _entities[Length++] = new Entity { Key = key, Value = value };
        }

        private class Entity
        {
            public TKey Key;
            public TValue Value;
        }
    }
}