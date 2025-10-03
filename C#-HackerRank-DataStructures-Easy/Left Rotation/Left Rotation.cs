class Result
{

    /*
     * Complete the 'rotateLeft' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER d
     *  2. INTEGER_ARRAY arr
     */

    public static List<int> rotateLeft(int d, List<int> arr)
    {
        int n = arr.Count;
        List<int> rotated = new List<int>(new int[n]);

        for (int i = 0; i < n; i++)
        {
            int newIndex = (i - d + n) % n;
            rotated[newIndex] = arr[i];
        }

        return rotated;
    }

    }
