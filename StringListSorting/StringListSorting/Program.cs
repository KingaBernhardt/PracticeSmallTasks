using System;
using System.Collections.Generic;

namespace StringListSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringsToSort = new List<string>();
            stringsToSort.Add("bcbb");
            stringsToSort.Add("abc");
            stringsToSort.Add("bbaa");
            stringsToSort.Add("aa");

            foreach (var item in stringsToSort)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("After sorting: ");
            foreach(var item in SortTheStringList(stringsToSort))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static List<string> SortTheStringList(List<string> li)
        {
            string temp = "";
            for (int i = 0; i< li.Count; i++)
            {
                for (int j = 0; j < li.Count; j++)
                {
                    if (string.Compare(li[i], li[j])< 0)
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
