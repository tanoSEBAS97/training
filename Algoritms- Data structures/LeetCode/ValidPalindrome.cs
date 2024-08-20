using System.Text;

namespace LeetCode;

public class ValidPalindrome
{
    public static bool IsPalindrome(string s)
    {
        StringBuilder stringBuilder = new StringBuilder();

        foreach (var VARIABLE in s.ToCharArray())
        {
            ;
            if (Char.IsLetterOrDigit(VARIABLE))
            {
                stringBuilder.Append(Char.ToLower(VARIABLE));
            }
        }

        if (stringBuilder.Length == 0)
        {
            return true;
        }

        int i = 0;
        int j = stringBuilder.Length - 1;
        while (i != j)
        {
            if (stringBuilder[i] != stringBuilder[j])
            {
                return false;
            }

            if (i == j - 1)
            {
                return true;
            }


            i++;
            j--;
        }


        return true;
    }

    /*public static void Main(string[] args)
    {
        bool result = IsPalindrome("aa");
    }*/
}