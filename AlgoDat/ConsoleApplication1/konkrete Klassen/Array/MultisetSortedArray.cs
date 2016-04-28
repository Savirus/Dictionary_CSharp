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


        public override bool Insert(int elem)
        {
			if (limit == array.Length) {
				Console.WriteLine ("Insert von " + elem + " fehlgeschlagen. Array ist voll!");
				return false;
			}

			if (elem < 1) {
				Console.WriteLine ("Nur positive Zahlen erlaubt!");
				return false;
			}

			if (limit == 0)
			{
				array[0] = elem;
			}
			else
			{
				int index = Search(elem, 0, limit-1);
				if (index < 0) { //Wenn es den Wert schon gibt, dann ist der Index negativ
					index = -index;
				}

				if (array [index] != 0) {
					//Verschiebe die Elemente eins nach rechts um Platz für das neue Element zu machen
					Array.Copy (array, index, array, index + 1, limit-index);
				}
				array [index] = elem;
			}
			limit++;

			return true;
        }

        
        private int Search(int elem, int left, int right)
        {
			if (left <= right)
			{
				int middle = (left + right) / 2;
				if (elem == array[middle])
					return -middle; //negativ für Duplikaterkennung
				else if (elem < array[middle])
					return Search(elem, left, middle - 1);
				else
					return Search(elem, middle + 1, right);
			}

			return left;
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
