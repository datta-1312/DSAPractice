
using System.Text;

public class AddTwoLL
{
    public Node<char> AddTwoNumbers(Node<char> l1, Node<char> l2) {
        //Reverse the linked lists
        Node<char> ll1 = ReverseLinkedList(l1);
        Node<char> ll2 = ReverseLinkedList(l2);
        //Traverse them
        //Add numbers
        int sum = TraverseLinkedList(ll1) + TraverseLinkedList(ll2);
        //Create a linked list
        Node<char> root = CreateLinkedList(sum);
        //Reverse
        ReverseLinkedList(root);

        return root;
    }

    private Node<char> ReverseLinkedList(Node<char> ll)
    {
        Node<char> current = ll;
        Node<char> prev = default;
        while(current != null)
        {
            Node<char> nextNode = current.Next;
            current.Next = prev;
            prev = current;
            current = nextNode;
        }
        return prev;
    }

    private int TraverseLinkedList(Node<char> root)
    {
        Node<char> current = root;
        StringBuilder result = new StringBuilder();

        while(current != null)
        {
            result.Append(current.Data.ToString());
            current = current.Next;
        }

        return Convert.ToInt32(result.ToString());
    }

    private Node<char> CreateLinkedList(int sum)
    {
        string strSum = sum.ToString();
        Node<char> root = new Node<char>(strSum[0]);
        Node<char> current = root;
        for(int i = 1; i < strSum.Length; i++)
        {
            current.Next = new Node<char>(strSum[i]);
            current = current.Next;
        }
        return root;
    }
}