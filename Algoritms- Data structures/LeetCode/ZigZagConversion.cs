namespace LeetCode;

public class ZigZagConversion
{
    static void printZigZagConcat(string str,
        int n)
    {
        // Corner Case (Only one row)
        if (n == 1)
        {
            Console.Write(str);
            return;
        }

        char[] str1 = str.ToCharArray();

        // Find length of string
        int len = str.Length;

        // Create an array of
        // strings for all n rows
        string[] arr = new string[n];

        // Initialize index for
        // array of strings arr[]
        int row = 0;
        bool down = true; // True if we are moving 
        // down in rows, else false

        // Traverse through
        // given string
        for (int i = 0; i < len; ++i)
        {
            // append current character
            // to current row
            arr[row] += (str1[i]);

            // If last row is reached,
            // change direction to 'up'
            if (row == n - 1)
                down = false;

            // If 1st row is reached, 
            // change direction to 'down'
            else if (row == 0)
                down = true;

            // If direction is down, 
            // increment, else decrement
            if (down)
                row++;
            else
                row--;
        }

        // Print concatenation
        // of all rows
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i]);
    }

    /*public static void Main(string[] args)
    {
        printZigZagConcat("PAYPALISHIRING", 3);
    }*/
}