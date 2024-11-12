public class RemoveNthItemInLL
{
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode current = head;
        ListNode dummy = new ListNode(0);
        ListNode temp = dummy;
        List<int> lst = new();
        while(current != null)
        {
            lst.Add(current.val);
            current = current?.next;
        }
        lst.RemoveAt(lst.Count-n);

        foreach(int item in lst)
        {
            dummy.next = new ListNode(item);
            dummy = dummy.next;
        }

        return temp.next;
    }
}