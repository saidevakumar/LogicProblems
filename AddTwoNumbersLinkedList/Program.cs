ListNode listNode1 = null;
ListNode listNode2 = null;
ListNode listNode3;
ListNode ptr;

listNode1 = new ListNode(2, null);
ptr = listNode1;
ptr.next = new ListNode(4,null);
ptr = ptr.next;
ptr.next = new ListNode(3, null);
ptr = ptr.next;

listNode2 = new ListNode(5, null);
ptr = listNode2;
ptr.next = new ListNode(6, null);
ptr = ptr.next;
ptr.next = new ListNode(4, null);
ptr = ptr.next;

Solution solution = new Solution();
listNode3 = solution.AddTwoNumbers(listNode1, listNode2);

ptr = listNode3;
while (ptr.next != null)
{
    Console.WriteLine(ptr.val);
    ptr = ptr.next;
}
Console.WriteLine(ptr.val);

/**
 * Definition for singly-linked list.
 */

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode newList = new ListNode(0);
        ListNode curr = newList;

        int newValue = 0;
        int newValueReminder = 0;

        while (l1 != null || l2 != null || newValueReminder != 0)
        {
            int l1Value = (l1 != null ? l1.val : 0);
            int l2Value = (l2 != null ? l2.val : 0);
            newValue = l1Value + l2Value + newValueReminder;

            newValueReminder = newValue / 10;

            curr.next = new ListNode(newValue % 10);
            curr = curr.next;

            if (l1 != null)
            {
                l1 = l1.next;
            }

            if (l2 != null)
            {
                l2 = l2.next;
            }   
        }
        return newList.next;
    }
}