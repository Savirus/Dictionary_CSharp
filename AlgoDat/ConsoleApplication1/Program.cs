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
            //int search_elem = Convert.ToInt32(Console.ReadLine());

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
            /*Random a = new Random();
            for (int i = 0; i < 20; i++)
            {
                int n = a.Next(1000);
                Console.WriteLine("num" + n);
                mss.Insert(a.Next(n));
            }*/
             mss.Insert(22);
            mss.Print();
            mss.Insert(6);
            mss.Print();
            mss.Insert(5);
            mss.Print();
            mss.Insert(6);
            mss.Print();
            mss.Insert(1);
            /*mss.Insert(100);
            mss.Insert(50);
            mss.Insert(60);
            mss.Insert(70);
            mss.Insert(40);
            mss.Insert(20);
            mss.Insert(30);
            mss.Insert(56);
            mss.Insert(23);
            mss.Insert(34);
            mss.Insert(22);
            mss.Insert(11);*/

            mss.Print();


            Console.ReadKey();



        }
    }

}
