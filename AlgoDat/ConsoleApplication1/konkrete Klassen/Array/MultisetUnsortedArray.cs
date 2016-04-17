using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.konkrete_Klassen
{
    class MultisetUnsortedArray : Multiset_Unsorted
    {

        private int naechsteFreieStelle = 0;
        private int[] array = new int[20];

        public override bool Delete(int elem)
        {
            int index = _Search(elem);
            if (index >= 0)
            {
                if (index == array.Length)
                {
                    array[index] = 0;
                    naechsteFreieStelle--;
                    return true;
                }
                else
                {
                    for (int i = index; i < array.Length - 1; i++)
                    {
                        array[i] = array[i + 1];
                    }
                    naechsteFreieStelle--;
                    return true;
                }
            }
            else
                return false;
        }

        public override bool Insert(int elem)
        {
            array[naechsteFreieStelle] = elem;
            naechsteFreieStelle++;
            return true;

        }

        public override void Print()
        {
            for (int i = 0; i < array.Length && array[i] != 0; i++)
            {
                Console.Write(array[i] + " " );
            }
            Console.WriteLine();
        }

        public override bool Search(int elem)
        {
            if (_Search(elem) >= 0)
            {
                return true;
            }

            return false;
        }

        private int _Search(int elem)
        {

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elem)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
