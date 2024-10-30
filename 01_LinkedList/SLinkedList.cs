
using Microsoft.VisualBasic;

namespace _01_LinkedList
{
    public class SLinkedList 
    {
        private SNode head;
        private SNode tail;
        private int count = 0;
        
        public SLinkedList()
        {
            head = null;
        }

        public void Add(string v)
        {
            var newNode = new SNode(v, null);
            if(head is null)
            {
                head = newNode;
                tail = head;
                count++;
                return;
            }

            tail.Next = newNode;
            tail = tail.Next;
            count++;

        }

        public string[] Values()
        {
            if(head is null)
            {
                return [];
            }

            string[] array = new string[count];
            int i = 0;
            for (var curr = head; curr != null; curr =  curr.Next ) 
            {
                array[i++] = curr.Value;
            }
            return array;
        }
    }
}