using System;

namespace ConsoleApplication1
{
	public abstract class SortedArray : Array
	{


		public SortedArray ()
		{
		}


		public override bool Delete(int elem){

			return _Delete (-(_Search(elem, 0, limit)));

		}

		//public abstract bool Insert (int elem);

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
				int index = _Search(elem, 0, limit-1);
				if (index < 0) { //Wenn es den Wert schon gibt, dann ist der Index negativ
					index = -index;
				}

				if (array [index] != 0) {
					//Verschiebe die Elemente eins nach rechts um Platz für das neue Element zu machen
					//Array.Copy (array, index, array, index + 1, limit-index);
					for (int i = limit; i > index; i--) {
						array [i] = array [i-1];
					}
				}
				array [index] = elem;
			}
			limit++;

			return true;
		}

		public override bool Search (int elem){
			int result = _Search(elem, 0, limit);
			if (result < 0) {
				return true;
			}
			return false;
		}

		private int _Search(int elem, int left, int right)
		{
			if (left <= right)
			{
				int middle = (left + right) / 2;
				if (elem == array[middle])
					return -middle; //negativ für Duplikaterkennung
				else if (elem < array[middle])
					return _Search(elem, left, middle - 1);
				else
					return _Search(elem, middle + 1, right);
			}

			return left;
		}
	}
}

