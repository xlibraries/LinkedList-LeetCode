//Question Link:- https://leetcode.com/explore/learn/card/linked-list/214/two-pointer-technique/1215/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution 
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) 
    {
        if(headA == null || headB == null)
            return null;
        HashSet<ListNode> intersectAt = new HashSet<ListNode>();
        while(headA != null)
        {
            intersectAt.Add(headA);
            headA = headA.next;
        }
        while(!intersectAt.Contains(headB))
        {
            headB = headB.next;
            if(headB == null)
            {
                return headB;
                break;
            }
        }
        return headB;
    }
}
