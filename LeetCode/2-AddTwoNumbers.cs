using Common;

class Solution_AddTwoNumber {
    public static void Start () {
        ListNode l_1_head = new ListNode (2);
        ListNode l_1_1 = new ListNode (4);
        ListNode l_1_2 = new ListNode (3);
        l_1_head.next = l_1_1;
        l_1_1.next = l_1_2;

        ListNode l_2_head = new ListNode (5);
        ListNode l_2_1 = new ListNode (6);
        ListNode l_2_2 = new ListNode (4);
        l_2_head.next = l_2_1;
        l_2_1.next = l_2_2;

        ListNode ret = AddTwoNumbers (l_1_head, l_2_head);
        PrintUtil.PrintListNode (ret);
    }

    public static ListNode AddTwoNumbers (ListNode l1, ListNode l2) {
        ListNode dummyHead = new ListNode (0);
        ListNode p = l1, q = l2, curr = dummyHead;
        int carry = 0;
        while (p != null || q != null) {
            int x = (p != null) ? p.val : 0;
            int y = (q != null) ? q.val : 0;
            int sum = carry + x + y;
            carry = sum / 10;
            curr.next = new ListNode (sum % 10);
            curr = curr.next;
            if (p != null) p = p.next;
            if (q != null) q = q.next;
        }

        if (carry > 0)
            curr.next = new ListNode (carry);

        return dummyHead.next;
    }
}