namespace LeetCode;

public class SearchInsertPosition
{
    public static int SearchInsert(int[] nums, int target)
    {

        if (nums[0] > target)
        {
            return 0;
        }
        
        int left = 0;
        int right = nums.Length - 1;
        int mid = 0;

        while (left <= right)
        {
            mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }

            if (nums[mid] > target)
            {
                right = mid - 1;
            }

            else
            {
                left = mid + 1;
            }
        }

        if (nums.Length == 2&&nums[0]>target)
        {
            return 1;
        }
        
        if (nums.Length == 2&&nums[1]<target)
        {
            return 2;
        }

        return mid+1;
    }

    public static void Main(string[] args)
    {
        SearchInsert([1, 3, 5, 6], 5);
    }
}