namespace LeetCode;

public class RotateArray
{
    public static int[] Rotate(int[] nums, int k)
    {
        k = k % nums.Length;
        if (nums.Length == 1)
        {
            return nums;
        }

        int[] aux = new int[nums.Length];

        int j = 0;
        int index = k;

        while (index < nums.Length)
        {
            aux[index] = nums[j];
            index++;
            j++;
        }


        int i = nums.Length - k;
        int l = 0;
        while (l < k)
        {
            aux[l] = nums[i];
            l++;
            i++;
        }


        for (int m = 0; m < nums.Length; m++)
        {
            nums[m] = aux[m];
        }

        return nums;
    }

    // public static void Main(string[] args)
    // {
    //     var testing = Rotate([1, 2], 3);
    //
    //     int length = testing.Length;
    // }
}