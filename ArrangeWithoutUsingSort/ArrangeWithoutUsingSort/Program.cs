using System;
using System.Collections.Generic;

namespace ArrangeWithoutUsingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(4);
            li.Add(1);
            li.Add(3);
            li.Add(2);

            foreach(var item in li)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("After sorting: ");
         
            foreach (var item in SortFunction(li))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static List<int> SortFunction(List<int> li)
        {
            int temp;
            for (int i = 0; i < li.Count; i++)
            {
                for (int j = 0; j < li.Count; j++)
                {
                    if (li[i] < li[j])
                    {
                        temp = li[i];
                        li[i] = li[j];
                        li[j] = temp;
                    }
                }
            }
            return li;
        }
    }
}
