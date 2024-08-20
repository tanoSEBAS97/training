namespace LeetCode;

public class Minimum_Size_Subarray_Sum
{
    public static int MinSubArrayLen(int target, int[] nums)
    {
        int minLength = int.MaxValue;

        int size = 0;
        int leftPosition = 0;
        int rigthPosition = 1;
        int sum = 0;

        while (rigthPosition < nums.Length)
        {
            sum = nums[leftPosition];
            if (sum == target)
            {
                return 1;
            }

            size++;
            while (sum < target && rigthPosition < nums.Length)
            {
                sum += nums[rigthPosition];
                size++;
                rigthPosition++;
                if (rigthPosition == nums.Length - 1 && minLength == int.MaxValue)
                {
                    return 0;
                }
            }

            minLength = Math.Min(minLength, size);
            size = 0;
            leftPosition++;
        }

        return minLength;
    }

    /*public static void Main(string[] args)
    {
        int result = MinSubArrayLen(4, [1, 4, 4]
        );
    }*/
}