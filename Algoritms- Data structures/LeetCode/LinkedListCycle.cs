namespace LeetCode;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}

public class LinkedListCycle
{
    public bool HasCycle(ListNode head)
    {
        HashSet<ListNode> nodes = new HashSet<ListNode>();
        while (head != null)
        {
            if (nodes.Add(head))
            {
                head = head.next;
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}