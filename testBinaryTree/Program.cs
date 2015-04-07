using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INF2DProjectsDLL;

namespace testBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int testID = 0;
            if (testID == 0)
            {
                BinaryTree<int> intBinary = new BinaryTree<int>();

                intBinary.Insert(18);
                intBinary.Insert(4);
                intBinary.Insert(48);
                intBinary.Insert(51);
                intBinary.Insert(23);
                intBinary.Insert(41);
                intBinary.Insert(78);
                intBinary.Insert(61);
                intBinary.Insert(2);
                intBinary.Insert(39);

                Console.WriteLine("Inorder traversal: ");
                intBinary.InOrder(intBinary.root);
                Console.WriteLine("\nPreorder traversal: ");
                intBinary.PreOrder(intBinary.root);
                Console.WriteLine("\nPostorder traversal: ");
                intBinary.PostOrder(intBinary.root);
                Console.WriteLine("\nDelete node, inorder traversal: ");
                intBinary.Delete(20);
                intBinary.InOrder(intBinary.root);

                Console.ReadLine();
            }
            if (testID == 1)
            {
                BinaryTree<String> stringBinary = new BinaryTree<String>();

                stringBinary.Insert("hoi");
                stringBinary.Insert("doei");
                stringBinary.Insert("hallo");
                stringBinary.Insert("later");
                stringBinary.Insert("morgen");
                stringBinary.Insert("bonjour");

                Console.WriteLine("Inorder traversal: ");
                stringBinary.InOrder(stringBinary.root);
                Console.WriteLine("\nPreorder traversal: ");
                stringBinary.PreOrder(stringBinary.root);
                Console.WriteLine("\nPostorder traversal: ");
                stringBinary.PostOrder(stringBinary.root);
                Console.WriteLine("\nDelete node, inorder traversal: ");
                stringBinary.Delete("morgen");
                stringBinary.InOrder(stringBinary.root);

                Console.ReadLine();
            }
        }
    }
}
