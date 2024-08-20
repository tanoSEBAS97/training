namespace LeetCode;

public class RemoveElementProblem
{
    public static int RemoveElement(int[] nums, int val)
    {
        int[] auxArray = new int[nums.Length];
        int numberOfElements = 0;
        int indexAuxArray = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (val == nums[i])
            {
                numberOfElements++;
            }
            else
            {
                auxArray[indexAuxArray] = nums[i];
                indexAuxArray++;
            }
        }

        nums = auxArray;
        return numberOfElements;
    }


    // public static void Main(string[] args)
    // {
    //     RemoveElement(new int[] { 3, 2, 2, 3 }, 3);
    // }
}