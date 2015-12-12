using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    class GenericListEnumerator<X> : IEnumerator<X>
    {
        IGenericList<X> _collection;
        int index;
        public GenericListEnumerator(IGenericList<X> collection)
        {
            _collection = collection;
            index = 0;
        }

        public bool MoveNext()
        {
            if (index < _collection.Count)
                return true;

            return false;
        }

        public X Current
        {
            get
            {
                if(MoveNext())
                {
                    return _collection.GetElement(index++);
                }
                return default(X);
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
            
        }

        public void Reset()
        {
            
        }
    }
}
