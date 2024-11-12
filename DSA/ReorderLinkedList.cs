public class ReorderLinkedList
{
    public void ReorderList(ListNode head) {
        if(head == null || head.next == null) return;

        Stack<int> reverseStk = new();
        ListNode current = head;
        ListNode newLL = new ListNode(0);
        ListNode dummy = newLL;
        while(current != null)
        {
            reverseStk.Push(current.val);
            current = current.next;
        }
        Stack<int> stk = new(reverseStk);

        int i = 0;
        int count = stk.Count/2;
        for(i = 0; i < count; i++)
        {
            newLL.next = new ListNode(stk.Pop());
            newLL = newLL.next;
            newLL.next = new ListNode(reverseStk.Pop());
            newLL = newLL.next;
        }
        newLL.next = new ListNode(reverseStk.Pop());
        // List<int> lst = new();
        // ListNode current = head;
        // ListNode newLL = new ListNode(0);
        // ListNode dummy = newLL;
        // while(current != null)
        // {
        //     lst.Add(current.val);
        //     current = current.next;
        // }
        // List<int> reverseLst = new List<int>(lst);
        // reverseLst.Reverse();
        // List<int> resultLst = new();

        // int i = 0;
        // for(i = 0; i < lst.Count/2; i++)
        // {
        //     resultLst.Add(lst[i]);
        //     resultLst.Add(reverseLst[i]);
        // }

        // if(resultLst.Count < lst.Count)
        // {
        //     resultLst.Add(reverseLst[i]);
        // }

        // foreach(int val in resultLst)
        // {
        //     newLL.next = new ListNode(val);
        //     newLL = newLL.next;
        // }

        head = dummy.next;
    }
}