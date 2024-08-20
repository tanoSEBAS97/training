namespace LeetCode;

public class RemoveDuplicatesFromSortedArray
{
    public static int removeDuplicates(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        int[] aux = new int[nums.Length];
        int index = 0;

        foreach (var element in nums)
        {
            if (!set.TryGetValue(element, out int value))
            {
                set.Add(element);
                aux[index] = element;
                index++;
            }
        }


        for (int i = 0; i < set.Count; i++)
        {
            nums[i] = aux[i];
        }


        return set.Count;
    }

    /*public static void Main(string[] args)
    {
        removeDuplicates([1, 1, 2]);
    }*/
}