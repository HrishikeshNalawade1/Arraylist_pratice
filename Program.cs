using System;
using System.Collections;

namespace arrayListtt
{
    class Program
    {
        static void Main(string[] args)
        {
           ArrayList  mylist = new ArrayList();
            Console.WriteLine("Length of ArrayList is: "+mylist.Capacity);
            mylist.Add(10);
            mylist.Add(20);
            mylist.Add(30);
            mylist.Add(40);
            
            foreach(object aa in mylist)
            {
                Console.Write(aa+" ");
            }
            Console.WriteLine("\nLength of ArrayList is: " + mylist.Capacity);

            Console.WriteLine("\ninsert element 11");
            mylist.Insert(1, 11);
            foreach (object aa in mylist)
            {
                Console.Write(aa + " ");
            }
            Console.WriteLine("\nLength of ArrayList is: " + mylist.Capacity);
            mylist.Remove(11);
            Console.WriteLine("\nAfter removing 11");
            foreach (object aa in mylist)
            {
                Console.Write(aa + " ");
            }

        }
    }
}
