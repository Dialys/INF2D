using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2DProjectsDLL
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public BinaryNode<T> root;
 
        /// Constructor for BinaryTree
        public BinaryTree()
        {
            root = null;
        }

        /// Inserts a new BinaryNode into the BinaryTree
        public void Insert(T i)
        {
            BinaryNode<T> newNode = new BinaryNode<T>();
            newNode.Data = i;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                BinaryNode<T> current = root;
                BinaryNode<T> parent;
                while (true)
                {
                    parent = current;
                    if (newNode.CompareTo(current) < 0)
                    {
                        current = current.left;

                        if (current == null)
                        {
                            parent.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        /// Traverses the BinaryTree InOrder, printing the data of the passed BinaryNodes in the Console
        public void InOrder(BinaryNode<T> theRoot)
        {
            if (!(theRoot == null))
            {
                InOrder(theRoot.left);
                theRoot.DisplayNode();
                InOrder(theRoot.right);
            }
        }

        /// Traverses the BinaryTree PreOrder, printing the data of the passed BinaryNodes in the Console
        public void PreOrder(BinaryNode<T> theRoot)
        {
            if (!(theRoot == null))
            {
                theRoot.DisplayNode();
                PreOrder(theRoot.left);
                PreOrder(theRoot.right);
            }
        }

        /// Traverses the BinaryTree PostOrder, printing the data of the passed BinaryNodes in the Console
        public void PostOrder(BinaryNode<T> theRoot)
        {
            if (!(theRoot == null))
            {
                PostOrder(theRoot.left);
                PostOrder(theRoot.right);
                theRoot.DisplayNode();
            }

        }

        /// Finds the lowest valued data in the BinaryTree
        public T FindMin()
        {
            BinaryNode<T> current = root;
            while (!(current.left == null))
            {
                current = current.left;
            }
            return current.Data;
        }


        /// Finds the highest valued data in the BinaryTree
        public T FindMax()
        {
            BinaryNode<T> current = root;
            while (!(current.right == null))
            {
                current = current.right;
            }
            return current.Data;
        }

        /// Finds the BinaryNode matching the specified data and return it
        public BinaryNode<T> Find(T key)
        {
            BinaryNode<T> current = root;
            while (key.CompareTo(current.Data) != 0)
            {
                if (key.CompareTo(current.Data) < 0)
                {
                    current = current.left;
                }
                else
                {
                    current = current.right;
                }
                if (current == null)
                {
                    return null;
                }
            }
            return current;
        }

        /// Gets the successor BinaryNode, only used by the Delete method
        public BinaryNode<T> GetSuccessor(BinaryNode<T> delNode)
        {
            BinaryNode<T> successorParent = delNode;
            BinaryNode<T> successor = delNode;
            BinaryNode<T> current = delNode.right;
            while (!(current == null))
            {
                successorParent = current;
                successor = current;
                current = current.left;
            }
            if (!(successor == delNode.right))
            {
                successorParent.left = successor.right;
                successor.right = delNode.right;
            }
            return successor;
        }

        /// Deletes a BinaryNode by matching the data of the BinaryNode from the BinaryTree
        public Boolean Delete(T key)
        {
            BinaryNode<T> current = root;
            BinaryNode<T> parent = root;
            bool isLeftChild = true;

            while (key.CompareTo(current.Data) != 0)
            {
                parent = current;
                if (key.CompareTo(current.Data) < 0)
                {
                    isLeftChild = true;
                    current = current.right;
                }
                else
                {
                    isLeftChild = false;
                    current = current.right;
                }
                if (current == null)
                {
                    return false;
                }
            }
            if ((current.left == null) && (current.right == null))
            {
                if (current == root)
                {
                    root = null;
                }
                else if (isLeftChild)
                {
                    parent.left = null;
                }
                else
                {
                    parent.right = null;
                }
            }
            else if (current.right == null)
            {
                if (current == root)
                {
                    root = current.left;
                }
                else if (isLeftChild)
                {
                    parent.left = current.left;
                }
                else
                {
                    parent.right = current.right;
                }
            }
            else if (current.left == null)
            {
                if (current == root)
                {
                    root = current.right;
                }
                else if (isLeftChild)
                {
                    parent.left = parent.right;
                }
                else
                {
                    parent.right = current.right;
                }
            }
            else
            {
                BinaryNode<T> successor = GetSuccessor(current);
                if (current == root)
                {
                    root = successor;
                }
                else if (isLeftChild)
                {
                    parent.left = successor;
                }
                else
                {
                    parent.right = successor;
                }
                successor.left = current.left;
            }
            return true;
        }
    }

    public class BinaryNode<T> : IComparable<BinaryNode<T>> where T : IComparable<T>
    {
        public T Data;
        public BinaryNode<T> left;
        public BinaryNode<T> right;

        /// Prints the data to Console
        public void DisplayNode()
        {
            Console.Write(Data + " ");
        }

        /// Compares this BinaryNode to another BinaryNode using the data
        public int CompareTo(BinaryNode<T> other)
        {
            if (other == null) return 1;

            if (other != null)
            {
                return this.Data.CompareTo(other.Data);
            }
            else
            {
                throw new ArgumentException("Object is not a BinaryNode!");
            }
        }
    }
}
