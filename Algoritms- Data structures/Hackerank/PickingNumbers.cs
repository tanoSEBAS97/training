namespace Training;

public class PickingNumbers
{
    /*public static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 1, 2, 2, 3, 1, 2 };

        int result = pickingNumbers(numbers);
    }*/

    public static int pickingNumbers(List<int> a)
    {
        a.Sort();
        int longest = 0;
        int temporal = 0;

        List<int> allowedNumbers = new List<int>();
        int i = 0;
        do
        {
            if (temporal == 0)
            {
                allowedNumbers = new List<int>() { a[i], a[i] - 1, a[i] + 1 };
                temporal++;
                i++;
                continue;
            }


            if (allowedNumbers.Contains(a[i]))
            {
                temporal++;
                i++;
            }
            else
            {
                temporal = 0;
            }

            if (temporal > longest)
            {
                longest = temporal;
            }
        } while (i < a.Count);


        return longest;
    }
}