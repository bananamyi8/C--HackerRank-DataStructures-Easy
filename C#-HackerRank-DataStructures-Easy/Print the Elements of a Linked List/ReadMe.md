Set a pointer current to the head of the linked list.

While current is not null:

Print the data stored in the current node.

Move the pointer to the next node (current = current.next).

Repeat until the pointer reaches null, indicating the end of the list.


This algorithm traverses the linked list from the head to the end, printing each node's data in order.The algorithm for the printLinkedList function is:

Set a pointer current to the head node of the linked list.

While current is not null:

Print the value of current.data.

Move current to the next node (current = current.next).

Stop when current becomes null, indicating the end of the list.