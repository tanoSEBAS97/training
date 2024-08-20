namespace LeetCode;

public class Find_the_Index_of_the_First_Occurrence_in_a_String
{
    public static int StrStr(string haystack, string needle)
    {
        char firstLetter = needle[0];

        for (int i = 0; i < haystack.Length; i++)
        {
            if (firstLetter == haystack[i])
            {
                var isContained = true;

                for (int k = 1; k < needle.Length; k++)
                {
                    if (i + k == haystack.Length)
                        return -1;

                    if (haystack[i + k] != needle[k])
                    {
                        isContained = false;
                        break;
                    }
                }

                if (isContained)
                    return i;
            }
        }


        return -1;
    }

    // public static void Main(string[] args)
    // {
    //     int result = StrStr("sadbutsad", "sad");
    // }
}