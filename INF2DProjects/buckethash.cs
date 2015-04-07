using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2DProjectsDLL
{
    public class BucketHash
    {
        private const int SIZE = 101;
        ArrayList[] data;
        /// <summary>
        /// Constructor for BucketHash
        /// </summary>
        public BucketHash()
        {
            data = new ArrayList[SIZE];
            for (int i = 0; i <= SIZE - 1; i++)
                data[i] = new ArrayList(4);
        }
        /// <summary>
        /// Hashes the specified string and returns the key
        /// </summary>
        /// <param name="s">String to be hashed</param>
        /// <returns>Key of the hashed string</returns>
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
        /// <summary>
        /// Inserts a string to the BucketHash
        /// </summary>
        /// <param name="item">String to be hashed and added</param>
        public void Insert(string item)
        {
            int hash_value;
            hash_value = Hash(item);

            if (data[hash_value].Contains(item))
            {
                data[hash_value].Add(item);
            }
        }
        /// <summary>
        /// Removes a string from the BucketHash
        /// </summary>
        /// <param name="item">String to remove</param>
        public void Remove(string item)
        {
            int hash_value;
            hash_value = Hash(item);

            if (data[hash_value].Contains(item))
            {
                data[hash_value].Remove(item);
            }
        }
    }
}