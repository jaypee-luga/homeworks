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
        
        var l1_stack = new Stack<int>();
        var l2_stack = new Stack<int>();
        var l1_value = string.Empty;
        var l2_value = string.Empty;

        // get l1 value
        while(l1.next != null)
        {
            l1_stack.Push(l1.val);
            l1 = l1.next;
        }

        //get l2 value
        while(l2.next != null)
        {
            l2_stack.Push(l2.val);
            l2 = l2.next;
        }

        foreach(var l1val in l1_stack.ToArray())
            l1_value += l1val.ToString();

        foreach(var l2val in l2_stack.ToArray())
            l2_value += l2val.ToString();

        var result = Int32.Parse(l1_value) + Int32.Parse(l2_value);
        char[] lResult = result.ToString().ToCharArray();

        Array.Reverse(lResult);

        var l3 = new ListNode();
        var tmp = new ListNode();
        for(var i=0; i<lResult.Length; i++)
        {
            if(i == lResult.Length - 1)
                l3.next = null;
            
            l3.val = lResult[i];
            l3.next = tmp;
        }
        return l3;
    }
}
