using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace linearHashTable
{
    public class linearHashTable
    {
        //initiate fields
        private static KeyValuePair<string, object>[] hashTable; //the hashtable
        private static int lastPos; //latest position

        //constructor
        public linearHashTable()
        {
            hashTable = new KeyValuePair<string, object>[10007];
            /* 
             * one important rule when choosing the size of your array for a hash table
             * (and when using a hash function such as the one we’re using here)
             * is to choose a number that is prime.
             * 
             * The size you ultimately choose will depend on your determination of the
             * number of records stored in the hash table, but a safe number seems to be
             * 10,007 (given that you’re not actually trying to store that many items in your
             * table). The number 10,007 is prime and it is not so large that enough memory
             * is used to degrade the performance of your program
             */
        }

        //add function for the hashtable
        public void add(string key, object value)
        {
            //create temporary table that is one larger than the actual hashtable
            KeyValuePair<string, object>[] tmpTable = new KeyValuePair<string, object>[hashTable.Length + 1];

            //for loop for copying the contents of the hashtable into the temporary table,
            //meaning it now holds everything from the hashtable and has a new "empty slot"
            for (int i = 0; i < hashTable.GetUpperBound(0); i++)
            {
                tmpTable[i] = hashTable[i];
            }
            hashTable = tmpTable; //the temporary table is being copied to the hashtable

            //table that holds the actual inserted... stuff
            KeyValuePair<string, object> pair = new KeyValuePair<string, object>(key, value);

            //call the simpleHash function
            simpleHash(key);


            //while loop for checking if there's an entry on lastPos already
            //in which case we check for the next position
            while (hashTable[lastPos].Key != null)
            {
                lastPos++;

                //the lastPos value is set back to 0 if the last index of our array already holds something
                if (lastPos == hashTable.GetUpperBound(0))
                {
                    lastPos = 0;
                }
            }

            //now our hashtable with as index "lastPos" will hold the value of pair
            hashTable[lastPos] = pair;
        }

        //this hash function should determine the index value of the key
        public static void simpleHash(string key)
        {
            int tot = 0;
            char[] cname = key.ToCharArray(); //store every character from the key seperately in a char array

            //in this for loop, we'll store the characters in the tot variable in ASCII format
            for (int i = 0; i < cname.GetUpperBound(0); i++)
            {
                tot += (int)cname[i];
            }

            lastPos = tot % hashTable.GetUpperBound(0);
        }

        //get the value that is paired with the given key
        public object getValue(string key)
        {
            //call the simpleHash function
            simpleHash(key);

            //here we loop through the hashtable, checking
            //if the current position holds the given key
            //if it doesn't, we'll check the next position
            while(hashTable[lastPos].Key != key)
            {
                lastPos++;
            }

            //return the value of the hashTable with the index of lastPos
            return hashTable[lastPos].Value;
        }

        //this function returns an arraylist of the indexes of our hashtable that contain something
        public ArrayList getPositions()
        {
            //here we create a new arraylist which will be returned
            ArrayList positions = new ArrayList();

            //loop through the hashtable, checking if the index holds a something,
            //and if it does we add that to the arraylist
            for (int i = 0; i < hashTable.GetUpperBound(0); i++)
            {
                if (hashTable[i].Key !=null)
                {
                    positions.Add(i);
                }
            }

            //return the arraylist!
            return positions;
        }

        //this function returns the size of the hashTable
        public int getHashTableSize()
        {
            return hashTable.Length;
        }
    }
}