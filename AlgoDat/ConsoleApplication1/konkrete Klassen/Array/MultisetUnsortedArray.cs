using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.konkrete_Klassen
{
    class MultisetUnsortedArray : UnsortedArray
    {
		public override bool Insert (int elem){
			return _Insert (elem);
		}

    }
}
