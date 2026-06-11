public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode Partition(ListNode head, int x) {
        ListNode dummy = new (0);
        ListNode dummy2 = new (0);
        
        ListNode less = dummy;
        ListNode greater = dummy2;
        
        while (head != null) {
            if (head.val < x) {
                less.next = head;
                less = head;
            }
            else {
                greater.next = head;
                greater = head;
            }
            head = head.next;
        }
        greater.next = null;

        less.next = dummy2.next;

        return dummy.next;
    }
}