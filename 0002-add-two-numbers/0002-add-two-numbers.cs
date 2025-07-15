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
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode newList = new ListNode(0); // צומת דמה
        ListNode current = newList;
        int solu = 0, temp = 0;

        while (l1 != null || l2 != null) {
            solu = (l1 != null) ? l1.val : 0;
            solu += (l2 != null) ? l2.val : 0;
            solu += temp;
            temp = solu / 10;

            current.next = new ListNode(solu % 10);
            current = current.next;

            l1 = (l1 != null) ? l1.next : null;
            l2 = (l2 != null) ? l2.next : null;
        }

        if (temp > 0) {
            current.next = new ListNode(temp);
        }

        return newList.next; // מחזיר את הרשימה בלי הצומת הדמה
    }
}