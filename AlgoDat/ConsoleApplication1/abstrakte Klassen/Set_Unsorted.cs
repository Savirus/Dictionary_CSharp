using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Set_Unsorted : IDictionary
    {
        abstract public bool Delete(int elem);
        abstract public bool Insert(int elem);
        abstract public void Print();
        abstract public bool Search(int elem);
    }
}
