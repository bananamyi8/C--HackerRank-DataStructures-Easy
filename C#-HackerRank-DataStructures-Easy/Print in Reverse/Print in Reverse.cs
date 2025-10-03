class Result
{

    /*
     * Complete the 'reversePrint' function below.
     *
     * The function accepts INTEGER_SINGLY_LINKED_LIST llist as parameter.
     */

    /*
     * For your reference:
     *
     * SinglyLinkedListNode
     * {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */

    public static void reversePrint(SinglyLinkedListNode llist)
    {
        Stack<int> stack = new Stack<int>();
        while (llist != null)
        {
            stack.Push(llist.data);
            llist = llist.next;
        }
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
    }

}