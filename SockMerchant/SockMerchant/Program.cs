using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SockMerchant
{
    class Program
    {
        /*
          John works at a clothing store. He has a large pile of socks that he must pair by color for sale. Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.

        For example, there are  socks with colors . There is one pair of color  and one of color . There are three odd socks left, one of each color. The number of pairs is .

        Complete the sockMerchant function in the editor below. It must return an integer representing the number of matching pairs of socks that are available.

        sockMerchant has the following parameter(s):

        n: the number of socks in the pile
        ar: the colors of each sock
         */
        class Solution
        {

            // Complete the sockMerchant function below.
            static int SockMerchant(int n, int[] ar)
            {
                return ar.GroupBy(a => a).Sum(a => a.Count() / 2);
            }

            static int SockMerchant2(int n, int[] ar)
            {
                Dictionary<int, int> socks = new Dictionary<int, int>();
                int counter = 0;
                foreach (int sock in ar)
                {
                    if (!socks.ContainsKey(sock))
                    {
                        socks.Add(sock, 1);
                    }
                    else
                    {
                        socks[sock]++;
                        if (socks[sock] % 2 == 0)
                        {
                            counter++;
                        }
                    }
                }
                return counter;
            }

            static void Main(string[] args)
            {
                TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                int n = Convert.ToInt32(Console.ReadLine());

                int[] ar = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), arTemp => Convert.ToInt32(arTemp))
                ;
                int result = sockMerchant(n, ar);

                textWriter.WriteLine(result);

                textWriter.Flush();
                textWriter.Close();
            }
        }
    }
}
