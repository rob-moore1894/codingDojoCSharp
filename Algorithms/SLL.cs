using System; 

namespace Algorithms
{
    class LinkedList
    {
        Node head; 
        public class Node
        {
            //Our nodes attributes
            public int val {get; set;}
            public Node next {get; set;}

            // Creates an instance of a Node with a set value and a .next pointing to null
            public Node (int val){
                this.val = val; 
                this.next = null; 
            }
        }

        public void AddNode(Node node){
            if (head == node){
                head = node;
            } else {
                Node temp = head; 
                while(temp != null) {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        public void PrintList(){
            Node current = head; 
            while (current != head){
                Console.WriteLine(current.val + " ");
                current = current.next;
            }
            Console.WriteLine();
        }

        // Function to Reverse the List
        public void ReverseList(){
            Node prev = null, current = head, next = null; 
            while (current != null){
                next = current.next;
                current.next = prev;
                prev = current;
                current = next; 
            }
            head = prev; 
        }
    }
}