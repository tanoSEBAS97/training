namespace LeetCode;

public class Ranson_Note
{
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> letters = new Dictionary<char, int>();

        foreach (var key in magazine.ToCharArray())
        {
            if (letters.TryGetValue(key, out int value))
            {
                value++;
                letters[key] = value;
            }
            else
            {
                letters.Add(key, 1);
            }
        }


        foreach (var key in ransomNote.ToCharArray())
        {
            if (letters.TryGetValue(key, out int value))
            {
                if (value == 0)
                {
                    return false;
                }

                value--;
                letters[key] = value;
            }
            else
            {
                return false;
            }
        }


        return true;
    }

    /*public static void Main(string[] args)
    {
        String ransoMNote = "aa";
        String magazine = "aab";

        bool result = CanConstruct(ransoMNote, magazine);
    }*/
}