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
            Console.ReadLine();
        }
    }
}
