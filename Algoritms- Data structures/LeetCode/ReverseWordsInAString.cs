using System.Text;

namespace LeetCode;

public static class ReverseWordsInAString
{
    public static string ReverseWords(string s)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ' ')
            {
                continue;
            }

            int j = i;
            while (j >= 0 && s[j] != ' ')
            {
                j--;
            }

            if (sb.Length != 0)
            {
                sb.Append(' ');
            }

            string newWord = s.Substring(j + 1, i - j);
            sb.Append(newWord);
            i = j;
        }

        return sb.ToString();
    }

    // public static void Main(string[] args)
    // {
    //     string result = ReverseWords("  hello world  ");
    // }
}