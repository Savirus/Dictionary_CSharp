using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Namespace für konrete Klassen
using ConsoleApplication1.konkrete_Klassen;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Suche");
            int search_elem = Convert.ToInt32(Console.ReadLine());

            IDictionary mua = new MultisetUnsortedArray();
            mua.Insert(7);
            mua.Insert(12);
            mua.Insert(34);
            mua.Insert(67);
            mua.Insert(75);
            mua.Print();
            mua.Delete(67);

            mua.Print();
            Console.WriteLine(mua.Search(search_elem));

            Console.ReadKey();



        }
    }

}
