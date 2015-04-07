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
            BucketHash bucketHash = new BucketHash();
            bucketHash.Insert("test1");
            bucketHash.Insert("test2");
            bucketHash.Insert("test3");
            bucketHash.Insert("test4");
            Console.WriteLine(bucketHash.ToString());
            bucketHash.Remove("test2");
    
            Console.ReadLine();


        }
    }
}
