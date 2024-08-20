namespace Training;

public class SinglyLinkedListNode
{
    public int data;
    public SinglyLinkedListNode next;
}

public class FindMergeNodes
{
    static int findMergeNode(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
    {
        SinglyLinkedListNode currentNode1 = head1;
        SinglyLinkedListNode currentNode2 = head2;

        HashSet<SinglyLinkedListNode> nodes = new HashSet<SinglyLinkedListNode>();

        do
        {
            if (currentNode1 != null)
            {
                bool result = nodes.Add(currentNode1);
                if (!result)
                {
                    Console.WriteLine(currentNode1.data);
                    return currentNode1.data;
                }

                currentNode1 = currentNode1.next;
            }

            if (currentNode2 != null)
            {
                bool result = nodes.Add(currentNode2);
                if (!result)
                {
                    Console.WriteLine(currentNode2.data);
                    return currentNode2.data;
                }

                currentNode2 = currentNode2.next;
            }
        } while (currentNode1 != null || currentNode2 != null);


        return 0;
    }
}