namespace Training;

public class Pairs
{
    public static int pairs(int k, List<int> arr)
    {
        int pairs = 0;
        arr.Sort();
        for (int i = 0; i < arr.Count; i++)
        {
            int search = arr[i] - k;
            int result = arr.BinarySearch(search);
            if (result >= 0)
            {
                pairs++;
            }
        }


        return pairs;
    }

    /*public static void Main(string[] args)
    {
        pairs(1, new List<int>() { 1, 2, 3, 4 });
    }*/
}