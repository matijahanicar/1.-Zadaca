using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    public class GenericList<X> : IGenericList<X>
    {
        private X[] _internalStorage;
        private int index;
        private int initialSize;


        public GenericList()
        {
            _internalStorage = new X[4];
            index = 0;
            initialSize = 4;
        }
        public GenericList(int initialSize)
        {

            _internalStorage = new X[initialSize];
            index = 0;
            this.initialSize = initialSize;
        }

        public int Count
        {
            get
            {
                return index;
            }
        }

        public void Add(X item)
        {
            if (index == initialSize)
            {
                X[] tmp = _internalStorage;
                initialSize *= 2;
                _internalStorage = new X[initialSize];
                for (int i = 0; i < index; i++)
                {
                    _internalStorage[i] = tmp[i];
                }
            }
            _internalStorage[index] = item;
            index++;
        }

        public bool RemoveAt(int index)
        {
            if (index >= initialSize || index < 0)
                return false;
            for (int i = index + 1; i < initialSize; i++)
                _internalStorage[i - 1] = _internalStorage[i];
            return true;
        }
        public bool Remove(X item)
        {
            for (int i = 0; i < index; i++)
            {
                if (_internalStorage[i].Equals(item))
                    RemoveAt(i);
            }
            return false;
        }

        public X GetElement(int index)
        {
            if (index >= initialSize || index < 0)
                throw new IndexOutOfRangeException();
            else
                return _internalStorage[index];
        }

        public int IndexOf(X item)
        {
            for (int i = 0; i < index; i++)
            {
                if (_internalStorage[i].Equals(item))
                    return i;
            }
            return -1;
        }

        public void Clear()
        {
            _internalStorage = new X[initialSize];
            index = 0;
        }

        public bool Contains(X item)
        {
            for (int i = 0; i < index; i++)
            {
                if (_internalStorage[i].Equals(item))
                    return true;

            }
            return false;
        }

        public IEnumerator<X> GetEnumerator()
        {
            return new GenericListEnumerator<X>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

