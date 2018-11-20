/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            ListNode final = null;
            ListNode cur = null;
            while(l1 != null || l2 != null)
            {
                if (l1 == null)
                {
                    l1 = new ListNode(0);
                }
                if (l2 == null)
                {
                    l2 = new ListNode(0);
                }
                int sum = l1.val + l2.val;
                while (sum > 9)
                {
                    sum -= 10;
                    if(l1.next != null)
                    {
                        l1.next.val += 1;
                    }
                    else if(l2.next != null)
                    {
                        l2.next.val += 1;
                    } else
                    {
                        l1.next = new ListNode(1);
                    }
                }
                if(final == null)
                {
                    final = new ListNode(sum);
                    cur = final;
                }
                else
                {
                    cur.next = new ListNode(sum);
                    cur = cur.next;
                }
                l1 = l1.next;
                l2 = l2.next;
            }
            return final;
        }
}
