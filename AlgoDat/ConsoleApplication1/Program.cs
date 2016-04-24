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
            IDictionary sua = new SetUnsortedArray();
            IDictionary mss = new MultisetSortedArray();
            //mua.Insert(7);
            //mua.Insert(12);
            //mua.Insert(34);
            //mua.Insert(67);
            //mua.Insert(75);
            //mua.Print();
            //mua.Delete(67);


            //mua.Print();

            //Console.WriteLine(mua.Search(search_elem));

            //sua.Insert(12);
            //sua.Insert(45);
            //sua.Insert(35);
            //sua.Insert(567);
            //sua.Insert(1);
            //sua.Insert(45);
            //sua.Print();
            //sua.Delete(45);
            //sua.Print();

            //Console.WriteLine(sua.Search(search_elem));

            mss.Insert(7);
            mss.Insert(2);
            mss.Insert(23);
            mss.Insert(1);
            mss.Print();


            Console.ReadKey();



        }
    }

}
