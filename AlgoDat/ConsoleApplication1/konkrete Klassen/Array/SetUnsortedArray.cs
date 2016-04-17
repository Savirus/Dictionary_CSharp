using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.konkrete_Klassen
{

    class SetUnsortedArray : Set_Unsorted
    {
        MultisetUnsortedArray mua = new MultisetUnsortedArray();
        public override bool Delete(int elem)
        {
            //Gleich wie MultisetUnsorted
            throw new NotImplementedException();
        }

        public override bool Insert(int elem)
        {
            if (!mua.Search(elem))
            {
                return mua.Insert(elem);
            }
            return false;
            //Vorherige Suche ob objekt vorhanden.
        }

        public override void Print()
        {
            //Gleich wie MultisetUnsorted
            throw new NotImplementedException();
        }

        public override bool Search(int elem)
        {
            
            //Gleich wie MultisetUnsorted
            throw new NotImplementedException();
        }
    }
}
