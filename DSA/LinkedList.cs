public class Node<T> where T : struct
{
    public T Data {get;set;}
    public Node<T> Next{get;set;}

    public Node(T data)
    {
        this.Data = data;
        Next = default;
    }
}

public class LinkedLst<T> where T:struct
{
    private Node<T> _head;

    public Node<T> Head => _head;
    public void Append(T data)
    {
        if(_head == null)
        {
            _head = new Node<T>(data);
            return;
        }
        Node<T> current = _head;
        while(current.Next != null)
        {
            current = current.Next;
        }
        current.Next = new Node<T>(data);
    }

    public ListNode DeleteMiddle(ListNode head) {

        if(head.next == null) return default;

        ListNode singleHop = head;
        ListNode doubleHop = head;

        while(doubleHop.next != null)
        {
            singleHop = singleHop.next;
            doubleHop = doubleHop.next?.next;
        }

        singleHop.next = singleHop.next.next;

        return head;
    }

    public void InsertAt(int index, T data)
    {
        int i = 0;

        Node<T> current = _head;
        Node<T> prev = null;
        while(current != null)
        {
            if(i == index)
            {
                Node<T> next = current.Next;
                prev.Next = new Node<T>(data);
                prev.Next.Next = current;
                current.Next = next;
                return;
            }
            i++;
            prev = current;
            current = current.Next;
        }
    }

    public void DeleteEnd()
    {
        Node<T> tempNode = _head;
        Node<T> prev = null;
        while(tempNode.Next!=null)
        {
            prev = tempNode;
            tempNode = tempNode.Next;
        }
        prev.Next = null;
    }

    public void Reverse()
    {
        Node<T> current = _head;
        Node<T> prev = default;

        while(current.Next != null)
        {
            Node<T> next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }
    }

    public void PrintAll()
    {
        Node<T> current = _head;

        while(current != null)
        {
            string arrow = string.Empty;
            if(current.Next != null)
                arrow = "->";
           Console.Write($"{current.Data}{arrow}");
           current = current.Next;
        }
    }
}