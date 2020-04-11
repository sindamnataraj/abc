using System;

namespace Kasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 3, 2, 12, 9, 0, -1 };
            BinaryTree bt = new BinaryTree();
            bt.insert(5);
            bt.insert(3);
            bt.insert(7);
            bt.insert(1);
            bt.insert(4);
            bt.insert(6);
            bt.insert(9);

            bt.preorder();


            Console.ReadLine();
        }
    }
}

