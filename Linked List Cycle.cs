//Question link:- https://leetcode.com/explore/learn/card/linked-list/214/two-pointer-technique/1212/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution 
{
    public bool HasCycle(ListNode head) 
    {
        
        HashSet<ListNode> set = new HashSet<ListNode>();
        while(head != null)
        {
            if(set.Contains(head))
            {
                return true;
                break;
            }
            set.Add(head);
            head = head.next;
        }
        return false;
    }
}
