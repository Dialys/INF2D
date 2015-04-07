using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INF2DProjectsDLL;

namespace testLinearHash
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a linearhash
            LinearHash linearHash = new LinearHash();

            //Add data to the linearHash
            linearHash.add("test0", "test12");
            linearHash.add("test1", "test13");
            linearHash.add("test2", "test14");
            linearHash.add("test3", "test15");

            //Get the posistions array of the linearHash
            linearHash.getPositions();

            //Check if the getValue method works
            Console.WriteLine(linearHash.getValue("test1"));

            //Check if the getHashTableSize method works
            Console.WriteLine(linearHash.getHashTableSize());
            Console.ReadLine();


        }
    }
}
