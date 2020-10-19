using System;
using System.Collections.Generic; 

namespace Tries
{
    public class TNode
    {
        public TNode[] children = new TNode[26];
        public bool isWord; 

        public TNode()
        {
            isWord = false;
            for(int i = 0; i < 26; i++)
            {
                children[i] = null;
            }
        }
    }

    public class Trie
    {
        public TNode root; 

        public Trie()
        {
            root = new TNode(); 
        }

        public void Insert(String s)
        {
            TNode current = root;
            for (int i = 0; i < s.length; i++){
                if(current == null){
                    root.TNodes[s.charAt(0)] = new TNode();
            }  
            }
            
        }
    }

    // How do I insert a word into a trie
    // Ex: given the word “DOG”, how do I make sure that is properly stored in my trie?
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
