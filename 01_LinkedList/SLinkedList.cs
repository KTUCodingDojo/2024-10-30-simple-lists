
using Microsoft.VisualBasic;

namespace _01_LinkedList
{
    public class SLinkedList 
    {
        private SNode head;
        private SNode tail;
        
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
                return;
            }

            tail.Next = newNode;
            tail = tail.Next;

        }

        public void Delete(SNode node)
        {
            if (node == head)
            {
                head = head.Next;
                return;
            }
             
            SNode prev = head;
            for (var curr = head.Next; curr != null; curr = curr.Next)
            {
                if (curr == node)
                {
                    prev.Next = curr.Next;
                    if(curr == tail)
                    {
                        tail = prev;
                    }
                    return;
                }
                prev = prev.Next;
            }
        }

        public SNode Find(string value)
        {
            for (var curr = head; curr != null; curr = curr.Next)
            {
                if(curr.Value == value)
                {
                    return curr;
                }
            }

            return null;
        }

        public string[] Values()
        {
            if(head is null)
            {
                return [];
            }

            return ValuesInternal().ToArray();
        }

        private IEnumerable<string> ValuesInternal()
        {
            for (var curr = head; curr != null; curr = curr.Next)
            {
                yield return curr.Value;
            }
        }
    }
}