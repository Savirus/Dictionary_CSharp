using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.konkrete_Klassen
{
    class MultisetSortedArray : Multiset_Sorted
    {
        public override bool Delete(int elem)
        {
            return true;
        }

        public override bool Insert(int elem)
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }

        public override bool Search(int elem)
        {
            throw new NotImplementedException();
        }
    }
}
