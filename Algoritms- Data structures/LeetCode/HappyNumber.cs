namespace LeetCode;

public class HappyNumber
{
    public static bool IsHappy(int n)
    {
        HashSet<int> set = new HashSet<int>();
        int sum = calculateExponential(n);

        while (set.Add(sum))
        {
            sum = calculateExponential(sum);

            if (sum == 1)
            {
                return true;
            }
        }

        return false;
    }

    public static int calculateExponential(int n)
    {
        List<int> digits = getDigits(n);
        int k = 0;
        digits.ForEach(digit => k += digit * digit);
        return k;
    }

    public static List<int> getDigits(int n)
    {
        List<int> digits = new List<int>();
        while (n > 0)
        {
            digits.Add(n % 10);
            n /= 10;
        }

        return digits;
    }

    // public static void Main(string[] args)
    // {
    //     bool isHappy = IsHappy(19);
    // }
}