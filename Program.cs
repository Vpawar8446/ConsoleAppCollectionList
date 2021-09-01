using System;
using System.Collections;

namespace ConsoleAppCollectionList
{
    class Program
    {
        static void Main(string[] args)
        {
            int countli, num;
            Console.WriteLine("ArrayList 1 :");

            ArrayList list1 = new ArrayList();
            list1.Add(100);
            list1.Add(200);
            list1.Add(600);

            foreach (object i in list1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("ArrayList 2 :");

            ArrayList list2 = new ArrayList();
            list2.Add(300);
            list2.Add(400);
            list2.Add(500);

            foreach (object ob in list2)
            {
                Console.WriteLine(ob);
            }


            list1.InsertRange(2, list2);
            countli = list1.Count;
           
            Console.WriteLine("Count of element in array list : " + countli);
            Console.WriteLine("Capacity of array list {0} ", list1.Capacity);
            Console.WriteLine("Elements in array list : ");

            foreach (object k in list1)
            {
              Console.Write("\t" + k);
            }
        }
    }
}

