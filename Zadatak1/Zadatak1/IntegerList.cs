using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int index;
        private int initialSize;
       

        public IntegerList()
        {
            _internalStorage = new int[4];
            index = 0;
            initialSize = 4;
        }
        public IntegerList(int initialSize)
        {

            _internalStorage = new int[initialSize];
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

        public void Add(int item)
        {
            if(index==initialSize)
            {
                int[] tmp = _internalStorage;
                initialSize *= 2;
                _internalStorage = new int[initialSize];
                for(int i=0; i<index; i++)
                {
                    _internalStorage[i] = tmp[i];
                }
            }
            _internalStorage[index] = item;
            index++;
        }

        public bool RemoveAt(int index)
        {
            if (index >= this.index || index < 0)
                return false;
            for (int i = index + 1; i < initialSize; i++)
                _internalStorage[i - 1] = _internalStorage[i];

            this.index--;
            return true;
        }
        public bool Remove(int item)
        {
            for(int i=0; i < index; i++)
            {
                if (_internalStorage[i] == item)
                    RemoveAt(i);
            }
            return false;
        }

        public int GetElement(int index)
        {
            if (index >= initialSize || index < 0)
                throw new IndexOutOfRangeException();
            else
                return _internalStorage[index];
        }

        public int IndexOf(int item)
        {
            for(int i=0; i<index; i++)
            {
                if (_internalStorage[i] == item)
                    return i;
            }
            return -1;
        }

        public void Clear()
        {
            _internalStorage = new int[initialSize];
            index = 0;
        }

        public bool Contains(int item)
        {
            for(int i=0; i<index; i++)
            {
                if (_internalStorage[i] == item)
                    return true;
                
            }
            return false;
        }

        
    }
}
