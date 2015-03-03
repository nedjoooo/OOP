using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GenericList
{
    [Version(1, 0)]
    public class GenericList<T> where T : IComparable<T>
    {
        const uint DefaultCapacity = 16;
        
        private T[] elements;
        private uint count = 0;

        public GenericList(uint capacity = DefaultCapacity)
        {
            elements = new T[capacity];
        }
        public uint Count
        {
            get
            {
                return this.count;
            }
        }
        public void Add(T element)
        {
            if(this.elements.Length <= this.count)
            {
                ResizeArray();
            }
            this.elements[count++] = element;
        }
        public T Access(uint index)
        {
            if(index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index {0}", index));
            }
            return this.elements[index];
        }

        public void Remove(uint index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index {0}", index));
            }
            T[] removingIndexArray = new T[this.elements.Length];
            for (uint i = index; i < this.elements.Length - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.elements[this.count] = default(T);
            this.count--;
        }

        public void Insert(uint index, T value)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index {0}", index));
            }
            if (this.elements.Length <= this.count)
            {
                ResizeArray();
            }
            this.count++;
            for (uint i = this.count; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }
            this.elements[index] = value;
        }

        public void Clear()
        {
            this.elements = new T[this.elements.Length];
            this.count = 0;
        }

        public int FindIndexByValue(T value)
        {
            int indexOf = -1;
            for (int i = 0; i < this.count; i++)
            {
                if(value.Equals(this.elements[i]))
                {
                    indexOf = i;
                    break;
                }
            }
            return indexOf;
        }
        public bool Contains(T value)
        {
            return this.FindIndexByValue(value) == -1 ? false : true;
        }

        public T Max()
        {          
            if (this.count == 0)
            {
                throw new InvalidOperationException("The GenericList is empty");
            }
            T max = this.elements[0];
            for (int i = 1; i < this.count; i++)
            {
                if(this.elements[i].CompareTo(max) > 0)
                {
                    max = this.elements[i];
                }
            }
            return max;
        }

        public T Min()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("The GenericList is empty");
            }
            T min = this.elements[0];
            for (int i = 1; i < this.count; i++)
            {
                if (this.elements[i].CompareTo(min) < 0)
                {
                    min = this.elements[i];
                }
            }
            return min;
        }

        private void ResizeArray()
        {
            T[] resizedArray = new T[this.elements.Length * 2];
            for (int i = 0; i < this.elements.Length; i++)
            {
                resizedArray[i] = this.elements[i];
            }
            this.elements = resizedArray;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < this.count; i++)
            {
                output.AppendLine(String.Format("{0} -> {1}", i, this.elements[i]));
            }
            return output.ToString();
        }
    }
}
