using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2DProjectsDLL
{
    class Buckethash
    {
        private const int SIZE = 101;
        ArrayList[] data;

        public Buckethash()
        {
            data = new ArrayList[SIZE];
            for (int i = 0; i <= SIZE - 1; i++)
                data[i] = new ArrayList(4);
        }

        public int Hash(string s)
        {
            long tot = 0;
            char[] charray;
            charray = s.ToCharArray();

            for (int i = 0; i <= s.Length - 1; i++)
            {
                tot += 37 * tot + (int)charray[i];
            }

            tot = tot % data.GetUpperBound(0);

            if (tot < 0)
            {
                tot += data.GetUpperBound(0);
            }
            return (int)tot;
        }

        public void Insert(string item)
        {
            int hash_value;
            hash_value = Hash(item);

            if (data[hash_value].Contains(item))
            {
                data[hash_value].Add(item);
            }
        }

        //Method to remove a string from the buckethash
        public void Remove(string item)
        {
            int hash_value;
            hash_value = Hash(item);

            if (data[hash_value].Contains(item))
            {
                data[hash_value].Remove(item);
            }
        }

        public static void ShowDistrib(string[] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                if (arr[i] != null)
                {
                    Console.WriteLine(i + " " + arr[i]);
                }
            }
        }
    }
}