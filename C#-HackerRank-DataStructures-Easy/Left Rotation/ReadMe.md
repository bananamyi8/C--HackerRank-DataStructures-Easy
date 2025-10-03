Get the array size n = arr.Count.

Initialize a new list rotated of size n with default values.

For each index i in the original array:

Calculate the new index as:
newIndex = (i - d + n) % n

This formula ensures the index wraps around the array (using modulo).

Place arr[i] into rotated[newIndex].

Return the rotated list.