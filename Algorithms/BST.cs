using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class BST
    {
        public class Node
        {
            public int data;
            public Node left, right; 

        public Node(int item)
        {
            data = item;
            left = null;
            right = null;
        }
        
        }

        Node root; 
        BST()
        {
            root = null; 
        }

        void deleteKey(int key)
        {
            root = remove(root, key)
        }

        public Node remove(Node root, int key)
        {
            //If the BST is empty return root
            if(root == null)
            return root; 

            //If the key has no children -> remove the Node (Set the reference of its parent/root to null)
            //If the key has one child -> make the child a child of its parent/root 
        }
    }
}