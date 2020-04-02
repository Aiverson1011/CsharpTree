using System;
using System.Collections.Generic;

namespace TreeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tree();
        }

        static void Tree()
        {
            // create an integer root

            #region tree construction
            Tree<int> tree = new Tree<int>(10);

            Node<int> node2 = new Node<int>(11);
            Node<int> node3 = new Node<int>(12);
            Node<int> node4 = new Node<int>(13);
            Node<int> node5 = new Node<int>(14);
            Node<int> node6 = new Node<int>(15);

            tree.Root.LeftChild = node2;
            tree.Root.RightChild = node3;

            node2.LeftChild = node4;
            node2.RightChild = node5;

            node3.LeftChild = node6;

            #endregion

            List<int> pre = tree.PreOrder(tree.Root);
            Console.WriteLine("=====");
            Console.WriteLine(String.Join(',', pre));

            Console.WriteLine("INORDER");
            List<int> inOrder = tree.InOrder(tree.Root);
            Console.WriteLine(String.Join(',', inOrder));

            Console.WriteLine("=====");
            Console.WriteLine("POSTORDER");
            List<int> postOrder =  tree.PostOrder(tree.Root);
            Console.WriteLine(String.Join(',', postOrder));




        }

    }
}
