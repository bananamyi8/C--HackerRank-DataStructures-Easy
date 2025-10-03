Set two pointers, current1 and current2, to the heads of the two linked lists.

While both pointers are not null:

If the data in the nodes pointed to by current1 and current2 are not equal, return false.

Move both pointers to their respective next nodes.

After the loop, check if both pointers are null (end of both lists reached at the same time):

If yes, return true (lists are identical in both data and length).

If not, return false (lists differ in length).