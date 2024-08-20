namespace LeetCode;

public class LongestSequence
{
    public static int LongestConsecutive(int[] nums)
    {
        if(nums.Length == 0)
            return 0;

        HashSet<int> set = new HashSet<int>(nums);

        if (set.Count == 1)
        {
            return 1;
        }
        long longestSequence = 1;

        foreach (var key in set)
        {
            if (set.Contains(key + 1) && !set.Contains(key - 1))
            {
                long currentSequence = 2;

                int i = key + 2;

                while (true)
                {
                    if (set.Contains(i))
                    {
                        currentSequence++;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }

                longestSequence = Math.Max(longestSequence, currentSequence);
            }
        }

        return (int)longestSequence;
    }

    /*public static void Main(string[] args)
    {
        LongestConsecutive(]);
    }*/
}