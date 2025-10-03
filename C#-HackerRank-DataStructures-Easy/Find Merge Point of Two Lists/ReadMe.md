Initialize two pointers, a and b, to the heads of the two linked lists.

Traverse both lists simultaneously:

If a and b are not the same node, move each pointer to its next node.

If a pointer reaches the end of its list (null), redirect it to the head of the other list.

Continue this process until a and b point to the same node (the merge point).

Return the data value of the merge node.