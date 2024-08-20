namespace Training;

public class TheMaximunSubArray
{
    /*public static void Main(string[] args)
    {
    }*/

    public static List<int> maxSubarray(List<int> arr)
    {
        int maxSubSequence = Int32.MinValue;
        int maxSubArray = Int32.MinValue;
        int tempMaxSubArray = 0;
        foreach (var current in arr)
        {
            
            //subsequence part
            
            if (current > 0)
            {
                maxSubSequence = maxSubSequence < 0 ? current : maxSubSequence + current;
            }
            else
            {
                // maxSubSequences= -5
                
                // current= -1
                
                maxSubSequence = Math.Max(maxSubSequence, current);
            }
            
            // subArray part

            tempMaxSubArray += current;
            if (tempMaxSubArray > maxSubArray)
            {
                maxSubArray = tempMaxSubArray;
            }

            if (tempMaxSubArray < 0)
            {
                tempMaxSubArray = 0;
            }
        }

        return new List<int>() { maxSubArray, maxSubSequence };
    }
}