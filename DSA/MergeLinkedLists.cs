public class MergeLinkedLists {
    public ListNode MergeKLists(ListNode[] lists) {
        List<int> list = new List<int>();

        foreach(ListNode lst in lists)
        {
            ListNode head1 = lst;
            while(head1!=null)
            {
                list.Add(head1.val);
                head1 = head1.next;
            }
        }
        
        list.Sort();

        ListNode head = new ListNode(-1); //= 
        ListNode temp = head;

        foreach(int nodeVal in list)
        {
            temp.next = new ListNode(nodeVal);
            temp = temp.next;
        }
        // ListNode head = new ListNode(list[0]);
        // ListNode temp = head;

        // for(int i = 1; i < list.Count; i++)
        // {
        //     head.next = new ListNode(list[i]);
        //     head = head.next;
        // }

        return head.next;
    }
}


  //Definition for singly-linked list.
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }