namespace Training;

public class RansoMNote
{
    /*public static void Main(string[] args)
    {
        List<string> magazine = new List<string>() { "give", "me", "one", "grand", "today", "night" };
        List<string> note = new List<string>() { "give", "one", "grand", "today" };
        checkMagazine(magazine, note);
    }*/

    public static void checkMagazine(List<string> magazine, List<string> note)
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        int i = 0;

        while (i < magazine.Count)
        {
            if (i < note.Count)
            {
                if (dictionary.TryGetValue(note[i], out int value))
                {
                    value--;
                    dictionary[note[i]] = value;
                }
                else
                {
                    dictionary.Add(note[i], -1);
                }
            }


            if (dictionary.TryGetValue(magazine[i], out int test))
            {
                test++;
                dictionary[magazine[i]] = test;
            }
            else
            {
                dictionary.Add(magazine[i], 1);
            }

            i++;
        }

        foreach (var keyValue in dictionary)
        {
            if (keyValue.Value < 0)
            {
                Console.WriteLine("No");
                return;
            }
        }

        Console.WriteLine("Yes");
    }
}