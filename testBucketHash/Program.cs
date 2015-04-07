using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INF2DProjectsDLL;

namespace testBucketHash
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a buckethash
            BucketHash bucketHash = new BucketHash();
            
            //Add data to the buckethash
            bucketHash.Insert("test1");
            bucketHash.Insert("test2");
            bucketHash.Insert("test3");
            bucketHash.Insert("test4");

            //Test the ToString method
            Console.WriteLine(bucketHash.ToString());
            
            //Test if the remove method works
            bucketHash.Remove("test2");
    
            Console.ReadLine();


        }
    }
}
