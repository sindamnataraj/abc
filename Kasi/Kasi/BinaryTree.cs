using System;
using System.Collections.Generic;
using System.Text;

namespace Kasi
{
    public class BinaryTreeNode
    {
        public int val;
        public BinaryTreeNode left;
        public BinaryTreeNode right;
        public BinaryTreeNode(int v)
        {
            left = null;
            right = null;
            val = v;
        }
    }
    public class BinaryTree
    {
        private BinaryTreeNode head;
        public BinaryTree()
        {
            head = null;
        }

        public void inorder()
        {
            inorder(head);
            Console.WriteLine();
            inorder_nonrecur(head);
        }

        private static void inorder(BinaryTreeNode head)
        {
            if (head == null) return;
            inorder(head.left);
            Console.Write("{0} ",head.val);
            inorder(head.right);
        }

        public void insert(int value)
        {
            head = insert(head, value);
        }

        private static BinaryTreeNode insert(BinaryTreeNode head, int value)
        {
            if (head == null)
            {
                head = new BinaryTreeNode(value);
                return head;
            }
            else if (value < head.val)
            {
                head.left = insert(head.left, value);
                return head;
            }
            else
            {
                head.right = insert(head.right, value);
                return head;
            }
        }

        private static void inorder_nonrecur(BinaryTreeNode head)
        {
            if (head == null) return;
            Stack<BinaryTreeNode> s = new Stack<BinaryTreeNode>();
            
            BinaryTreeNode temp = head;
            
            while (temp != null || s.Count > 0)
            {
                if (temp != null)
                {
                    s.Push(temp);
                    temp = temp.left;
                }
                else
                {
                    temp = s.Pop();
                    Console.Write("{0} ",temp.val);
                    temp = temp.right;
                }
            }
        }

        public void preorder()
        {
            preorder(this.head);

            Console.WriteLine();

            preorder_nonrecur(head);
        }

        private static void preorder(BinaryTreeNode head)
        {
            if (head == null) return;
            Console.Write("{0} ",head.val);
            preorder(head.left);
            preorder(head.right);
        }

        private static void preorder_nonrecur(BinaryTreeNode head)
        {
            if (head == null) return;
            Stack<BinaryTreeNode> s = new Stack<BinaryTreeNode>();
            BinaryTreeNode temp = head;
            while (temp != null || s.Count > 0)
            {
                if (temp != null)
                {
                    Console.Write("{0} ", temp.val);
                    s.Push(temp);
                    temp = temp.left;
                }
                else {
                    temp = s.Pop();
                    temp = temp.right;
                }
            }
        }


        public void postorder()
        {
            postorder(head);
        }

        private static void postorder(BinaryTreeNode head)
        {
            if (head == null) return;
            postorder(head.left);
            postorder(head.right);
            Console.Write("{0} ",head.val);
        }

        private static void postorder_nonrecur(BinaryTreeNode head)
        {
            if (head == null) return;
            Stack<BinaryTreeNode> s = new Stack<BinaryTreeNode>();
            BinaryTreeNode temp = head;

            while (temp != null || s.Count > 0)
            {
                if (temp != null)
                {
                    if (temp.right != null) s.Push(temp.right);
                    s.Push(temp);
                    temp = temp.left;
                }
                else {
                    temp = s.Pop();
                    if (s.Count > 0 && s.Peek() == temp.right)
                    {
                        BinaryTreeNode temp1 = s.Pop();
                        s.Push(temp);
                        temp = temp1;
                    }
                    else
                    {
                        Console.Write("{0} ",temp.val);
                        temp = null;
                    }
                }
            }
        }

    }
}
