namespace Leetcode.Solution;

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        ListNode? head = null;
        ListNode prev, curr;
        int m = 0, sum;
        
        prev = head;

        while (l1 is not null || l2 is not null) 
        {   
            sum = (l1?.val ?? 0) + (l2?.val ?? 0) + m;
            m = sum >= 10 ? 1 : 0;
            
            if (head is null) 
            {
                head = new() 
                {
                    val = sum % 10
                };

                prev = head;
            } else 
            {
                curr = new ListNode() 
                {
                    val = sum % 10
                };

                prev.next = curr;
                prev = curr;
            }
            
            l1 = l1?.next;
            l2 = l2?.next;

            if (l1 is null && l2 is null && m == 1) 
            {
                prev.next = new()
                {
                    val = m,
                    next = null
                };
            }
        }

        return head;
    }
}

