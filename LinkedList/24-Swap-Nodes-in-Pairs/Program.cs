/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

 public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode SwapPairs(ListNode head) {
        if (head == null)
            return null;

        if (head.next == null)
            return head;
        
        // Create a dummy node to simplify edge cases and initialize pointers.
        ListNode dummyNode = new();
        dummyNode.next = head;
        ListNode prevNode = dummyNode;

        while (head != null && head.next != null)
        {
            ListNode firstNode = head;
            ListNode secondNode = head.next;

            // Swapping
            prevNode.next = secondNode;
            firstNode.next = secondNode.next;
            secondNode.next = firstNode;

            // Reiniting tthe poiters for next swap
            prevNode = firstNode;
            head = firstNode.next;
        }

        Console.WriteLine($"Dummy next: {dummyNode.next.val}");
        
        return dummyNode.next;
    }
}

class Program {
    static void Main(string[] args) {
        // 1. Tạo danh sách liên kết mẫu: 1 -> 2 -> 3 -> 4
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(3);
        head.next.next.next = new ListNode(4);

        Console.WriteLine("Danh sach ban dau:");
        PrintList(head);

        // 2. Gọi hàm hoán đổi các cặp node
        Solution solution = new Solution();
        ListNode newHead = solution.SwapPairs(head);

        Console.WriteLine("\nDanh sach sau khi swap theo cap:");
        PrintList(newHead);
    }

    // Hàm bổ trợ để in danh sách liên kết ra màn hình
    static void PrintList(ListNode head) {
        Console.WriteLine($"New Head: {head.val}");
        ListNode current = head;
        while (current != null) {
            Console.Write(current.val);
            if (current.next != null) {
                Console.Write(" -> ");
            }
            current = current.next;
        }
        Console.WriteLine();
    }
}