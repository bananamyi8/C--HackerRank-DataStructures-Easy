Initialize a variable maxSum to the smallest possible integer value to track the maximum hourglass sum found.

Loop through the rows from 0 to 3 (since the hourglass spans 3 rows and the array has 6 rows).

Within each row, loop through the columns from 0 to 3 (since the hourglass spans 3 columns and the array has 6 columns).

For each position (i, j), calculate the hourglass sum:

Sum the values of the top row of the hourglass: arr[i][j] + arr[i][j+1] + arr[i][j+2]

Add the middle of the hourglass: arr[i+1][j+1]

Add the bottom row of the hourglass: arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2]

Update maxSum if the currentSum is greater than the current maxSum.

After all iterations, return the maxSum as the maximum hourglass sum found in the 2D array.