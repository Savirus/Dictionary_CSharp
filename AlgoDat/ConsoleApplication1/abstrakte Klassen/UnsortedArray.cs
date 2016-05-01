using System;

namespace ConsoleApplication1
{
	public abstract class UnsortedArray : Array
	{

		public bool _Insert(int elem)
		{
			array[limit] = elem;
			limit++;
			return true;

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

		public override bool Delete(int elem){
			return _Delete (elem, _Search (elem));

		}
		/*public abstract bool Insert (int elem);
		public abstract bool Delete (int elem);

		public abstract bool Search (int elem);*/
	}
}

