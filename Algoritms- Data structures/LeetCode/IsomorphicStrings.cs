namespace LeetCode;

public class IsomorphicStrings
{
    public static bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, char> map = new Dictionary<char, char>();
        HashSet<char> usedChars = new HashSet<char>();

        for (int i = 0; i < s.Length; i++)
        {
            
            char currentLetter = s[i];
            if (map.TryGetValue(currentLetter, out char value))
            {
                if (t[i] != value)
                {
                    return false;
                }
            }
            else
            {
                if (!usedChars.Contains(t[i]))
                {
                    map.Add(currentLetter, t[i]);
                    usedChars.Add(t[i]);
                }
                else
                {
                    return false;
                }
            }
        }


        return true;
    }


    /*public static void Main(string[] args)
    {
        IsIsomorphic("badc", "baba");
    }*/
}