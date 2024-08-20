using System.Collections.Concurrent;
using System.Text;

namespace LeetCode;

public class SummaryRangesExer
{
    public static Task<bool> resultfromid()
    {
        return Task.FromResult(true);
    }


    public  static IList<string> SummaryRanges(int[] nums)
    {

        
        List<string> results = new List<string>();
        if (nums.Length == 0)
        {
            return results;
        }

        if (nums.Length == 1)
        {
            results.Add(nums[0].ToString());
        }

        int aux1 = nums[0];
        int aux2 = Int32.MinValue;
        bool aux2flag = false;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] == nums[i] - 1)
            {
                aux2 = nums[i];
                aux2flag = true;
            }
            else
            {
                if (aux2flag)
                {
                    results.Add($"{aux1}->{aux2}");
                }
                else
                {
                    results.Add(aux1.ToString());
                }

                aux1 = nums[i];
                aux2flag = false;
            }


            if (nums.Length - 1 == i)
            {
                if (aux2flag)
                {
                    results.Add($"{aux1}->{aux2}");
                }
                else
                {
                    results.Add(aux1.ToString());
                }
            }
        }


        return results;
    }

    /*public static void Main(string[] args)
    {
        int[] nums = { 0, 2, 3, 4, 6, 8, 9 };
        var result = SummaryRanges(nums);
    }*/
}