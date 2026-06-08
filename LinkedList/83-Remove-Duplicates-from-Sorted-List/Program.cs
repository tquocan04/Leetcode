public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode dummy = new (-101);
        ListNode current = dummy;

        while (head != null)
        {
            if (current.val != head.val)
            {
                current.next = head;
                current = head;
            }
            
            head = head.next;
        }
        
        current.next = null;

        return dummy.next;
    }
}