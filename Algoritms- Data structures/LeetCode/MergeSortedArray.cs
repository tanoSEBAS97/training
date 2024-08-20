namespace LeetCode;

public class MergeSortedArray
{
    /*public static void Main(string[] args)
    {
        int[] nums1 = {-1,-1,0,0,0,0 };
        int[] nums2 = { -1,0 };

        Merge(nums1, 4, nums2, 2);
    }*/

    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (m == 0)
        {
            for (int j = 0; j < nums2.Length; j++)
            {
                nums1[j] = nums2[j];
            }
            return;
        }
        
        int i = 0;
        int[] tempArray =new int[m+n];
        Array.Copy(nums1, tempArray, nums1.Length);
        
        int aux = 0;
        int currentPosition = 0;

        while (i < m)
        {
            while (aux < n && nums2[aux] <= tempArray[i])
            {
                nums1[currentPosition] = nums2[aux];
                currentPosition++;
                aux++;
            }

            nums1[currentPosition] = tempArray[i];
            currentPosition++;
            i++;
        }

        while (aux < n)
        {
            nums1[currentPosition] = nums2[aux];
            currentPosition++;

            aux++;
        }
    }
}