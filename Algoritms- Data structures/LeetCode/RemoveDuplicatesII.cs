namespace LeetCode;

public class RemoveDuplicatesII
{
    public static int RemoveDuplicates(int[] nums)
    {
        int k = 0;

        bool isDuplicated = false;
        int realIndex = 0;


        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1] && !isDuplicated)
            {
                isDuplicated = true;
            }
            else if (nums[i] != nums[i - 1])
            {
                isDuplicated = false;
                nums[realIndex] = nums[i];
                k++;
            }
        }


        return k;
    }
    //
    // public static void Main(string[] args)
    // {
    //     RemoveDuplicates([1, 1, 1, 2, 2, 3]);
    // }
}