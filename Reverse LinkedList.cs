//Question Link:-https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1205/
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
    ListNode prevNode = null;
    public ListNode ReverseList(ListNode head) 
    {
        if(head == null)
        {
            return prevNode;
        }
        ListNode nextNode = head.next;
        head.next = prevNode;
        prevNode = head;
        head = nextNode;
        ReverseList(nextNode);
        return prevNode;
    }
} 
