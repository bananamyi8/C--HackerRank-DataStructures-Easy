   static int findMergeNode(SinglyLinkedListNode head1, SinglyLinkedListNode head2) 
   {
       SinglyLinkedListNode a = head1;
       SinglyLinkedListNode b = head2;
   
       while (a != b)
       {
           a = (a == null) ? head2 : a.next;
           b = (b == null) ? head1 : b.next;
       }
   
       return a.data;
   }