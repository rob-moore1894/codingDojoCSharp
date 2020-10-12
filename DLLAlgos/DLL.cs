using System;

namespace DLLAlgos
{
    public class DNode
    {
        public int val {get; set;}
        public DNode next {get; set;}
        public DNode prev {get; set;}

        public DNode (int value)
        {
            val = value;
            next = null;
            prev = null;
        }
    }

    public class DLL
    {
        public DNode head {get; set;}
        public DNode tail {get;set;}
        public DLL()
        {
            head = null;
            tail = null;
        }
        
    //Add a value to the back of a DLL
    public void AddBack(DLL doublyLL, int data){
        DNode newNode = new DNode(data);
        if(doublyLL.head == null){
            newNode.prev = null;
            doublyLL.head = newNode; 
        } 
    }

    //Add a value to the front of a DLL
    public void AddFront(DLL doublyLL, int data){
        DNode newNode = new DNode(data);
        newNode.next = doublyLL.head;
        newNode.prev = null;
        if (doublyLL.head != null){
            doublyLL.head.prev = newNode;
        }
        doublyLL.head = newNode;
    }

    //Remove a given value from the list, or return false if not found

    //Insert a new node after a given value, or return false if the value was not found
    }

}