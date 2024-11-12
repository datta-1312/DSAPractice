public class OddEvenLinkedList
{
    public ListNode OddEvenList(ListNode head) {
        int count = 1;
        List<int> oddLst = new(){head.val};
        List<int> evenLst = new();
        ListNode current = head;
        while(current.next != null)
        {
            current = current.next;
            count++;
            if(count % 2 == 0)
            {
                evenLst.Add(current.val);
                continue;
            }
            oddLst.Add(current.val);
        }

        evenLst.AddRange(oddLst);

        head = new ListNode(-1);
        ListNode temp = head;
        foreach(int item in evenLst)
        {
            temp.next = new ListNode(item);
            temp = temp.next;
        }

        return head.next;
    }      
}