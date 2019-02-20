using System;
using System.Collections.Generic;

namespace MemoryList
{
    public class MemoryList<T>
    {
        public MemoryList()
        {

        }

        private List<T> mine = new List<T>();
        public void Add(T value)
        {
            mine.Add(value);
        }

        public void Remove(T value)
        {
            mine.Remove(value);
        }

        public bool Contains(T value)
        {
            return mine.Contains(value);
        }
    }
}
