//Question Link:-   https://leetcode.com/explore/learn/card/linked-list/214/two-pointer-technique/1296/
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
public class Solution 
{
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        if(head.next == null)
        {
            return null;
        }
        ListNode front = head;
        ListNode back = head;
        while(front.next != null)
        {
            if(n == 0)
            {
                front = front.next;
                back = back.next;
            }
            else
            {
                front = front.next;
                n--;
            }
        }
        if(n > 0)
        {
            head = head.next;
        }
        else
            back.next = back.next.next;
        return head;
    }
}
