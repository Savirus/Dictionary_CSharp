using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.konkrete_Klassen
{
    class MultisetSortedArray : Multiset_Sorted
    {
        private int[] array = new int[20];
        int limit = 0;
        public override bool Delete(int elem)
        {

            return true;
        }

        private void fillArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 99999;
            }
            array[0] = 21;
            //array[1] = 2;
            array[1] = 3;
        }

        public override bool Insert(int elem)
        {
            int index = 0;
            if (limit == 0)
            {
                array[0] = elem;
            }
            else
            {
                index = Search(elem, 0, limit);
                if (pleft > pright)
                {
                    array[pleft] = elem;
                }
                else
                {
                    array[pright] = elem;
                }
            }
            limit++;
            //array[0] = 23;
            //array[1] = 24;
            /*fillArray();
            int index = Search(elem, 0, array.Length-1);
            Console.WriteLine("Searchindex:" + index);
            return true;*/

            
            
            Console.WriteLine("ir: " + pleft + " " + pright);
            //Console.WriteLine("insert:"+index);
            /*if (index < 0)
            {
                index *= -1;
            }*/
           /* for (int i = letztesObjekt ; i >= index; i--)
            {
                array[letztesObjekt + 1] = array[letztesObjekt];

            }*/
            //array[index] = elem;
           // letztesObjekt++;
            return true;
            
        }
        //array 0 .. array.length / letztes Element

        int pleft, pright;
        
        private int Search(int elem, int left, int right)
        {
           // Console.WriteLine(elem + " " + left + " " + right);
            
            if (left <= right)
            {
                int middle = (left + right) / 2;
                if (elem == array[middle])
                    return middle;
                else if (elem < array[middle])
                    return Search(elem, left, middle - 1);
                else
                    return Search(elem, middle + 1, right);
            }
            Console.WriteLine("l " + left + "; r " + right);
            pleft = left;
            pright = right;
            /*if (pleft < pright)
                return pleft;
            else
                return pright;*/
            return -1;
        }



        //TODO: Redundanz beseitigen!
        public override void Print()
        {
            for (int i = 0; i < array.Length && array[i] != 0; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public override bool Search(int elem)
        {
            throw new NotImplementedException();
        }

        private bool moveElements(int elem)
        {
            return true;
        }
        // 3 10 12 14
        // 3 7 10 12 14
        //TODO: Redundanz??
      /*  private int _Search(int elem)
        {
            int right = letztesObjekt;
            int left = 0;
            int i = (left + right) / 2;
            do
            {
                i = (left + right) / 2;
                if (array[i] < elem)
                    left = i + 1;
                else
                    right = i - 1;
            }
            while (array[i] != elem && left <= right);
            if (array[i] == elem)
                return i;
            else
                return -i;

        }*/
    }
}
