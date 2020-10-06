using System; 

namespace Algorithms
{
    public class LinkedList
    {
        public Node head; 
        public class Node
        {
            //Our nodes attributes
            public int data {get; set;}
            public Node next {get; set;}

            // Creates an instance of a Node with a set value and a .next pointing to null
            public Node (int data){
                this.data = data; 
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
            Node runner = head; 
            while (runner != head){
                Console.WriteLine(runner.data + " ");
                runner = runner.next;
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

        public bool LoopDetection(Node first){
            if (first == null){
                return false; 
            }
            Node slow, fast;
            slow = first;
            fast = first; 

            while(true){
                slow = slow.next;
                if(fast.next != null){
                    fast = fast.next.next;
                } else {
                    return false; 
                }
                if (slow == null || fast == null){
                    return false;
                }
                if (slow == fast){
                    return true; 
                }
            } 
        }
    }
}