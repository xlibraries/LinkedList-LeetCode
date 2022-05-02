//Question Link:- https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1207/
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
    public ListNode RemoveElements(ListNode head, int val) 
    {
        while(head != null && head.val == val)
            head = head.next;
        ListNode curr = head;
        while(curr != null && curr.next != null)
        {
            if(curr.next.val == val)
                curr.next = curr.next.next;
            else
                curr = curr.next;
        }
        return head;
    }
} 
