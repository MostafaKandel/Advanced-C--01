using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__01
{
    internal class FixedSizeList<T>
    {
        #region attributes
        private T[] items;
        private int count;
        private int capacity;
        #endregion

        #region Properties
        public int Count { get { return count; } }
        public int Capacity { get { return capacity; } }
        #endregion

        #region constractor
        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException(" the capacity should be positive ");
            this.capacity = capacity;
            this.items = new T[capacity];
            count = 0;
        }
        #endregion

        #region methods
        public void Add(T item)
        {
            if (count >= capacity)
                throw new IndexOutOfRangeException($"cannot add more element. the capaciy is full the capacity is {capacity}");
            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            if(index < 0 || index >= count)
                throw new ArgumentOutOfRangeException("Invalid index");
            return items[index];
        }
        #endregion


    }
}
