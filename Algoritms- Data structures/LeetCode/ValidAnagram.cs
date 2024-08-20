namespace LeetCode;

public class ValidAnagram
{
    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length)
            return false;
        
        
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        for (int i = 0; i < t.Length; i++)
        {
            if (dictionary.TryGetValue(t[i], out int value))
            {
                dictionary[t[i]] = value + 1;
            }
            else
            {
                dictionary.Add(t[i], 1);
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (dictionary.TryGetValue(s[i], out int value))
            {
                if (value == 1)
                {
                    dictionary.Remove(s[i]);
                }
                else
                {
                    dictionary[s[i]] = value - 1;
                }
            }
            else
            {
                return false;
            }
        }

        return dictionary.Count == 0;
    }
}