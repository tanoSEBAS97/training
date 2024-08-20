using System.Runtime.CompilerServices;

namespace Training;

public class MinimunSwapsOrder
{
    public static int minSwaps(int[] nums)
    {
        int len = nums.Length;
        Dictionary<int, int> map
            = new Dictionary<int, int>();
        for (int i = 0; i < len; i++)
            map.Add(nums[i], i);

        Array.Sort(nums);

        // To keep track of visited elements. Initialize 
        // all elements as not visited or false. 
        bool[] visited = new bool[len];

        // Initialize result 
        int ans = 0;
        for (int i = 0; i < len; i++)
        {
            // already swapped and corrected or 
            // already present at correct pos 
            if (visited[i] || map[nums[i]] == i)
                continue;

            int j = i, cycle_size = 0;
            while (!visited[j])
            {
                visited[j] = true;

                // move to next node 
                j = map[nums[j]];
                cycle_size++;
            }

            // Update answer by adding current cycle. 
            if (cycle_size > 0)
            {
                ans += (cycle_size - 1);
            }
        }

        return ans;
    }

    /*public static void Main(string[] args)
    {
        minSwaps(new[] { 4, 3, 1, 2 });
    }*/
}