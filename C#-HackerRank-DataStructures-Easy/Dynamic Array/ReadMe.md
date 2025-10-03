Initialize an empty list lastAnswers to store the results of query type 2.

Initialize a list seqList of n empty lists.

Set lastAns to 0.

For each query in queries:

Extract type, x, and y.

Calculate seqIndex = (x XOR lastAns) % n.

If type is 1, append y to the sequence at seqList[seqIndex].

If type is 2 and the sequence at seqList[seqIndex] is not empty:

Find the element at index y % size_of_seqList[seqIndex] in the sequence.

Assign this value to lastAns.

Append lastAns to lastAnswers.

After processing all queries, return the list lastAnswers.

This algorithm uses bitwise XOR and modular arithmetic to dynamically manage sequences and efficiently retrieve values, returning the results of specific queries in sequence.