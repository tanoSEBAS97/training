using System.Collections;

namespace LeetCode;

public class GroupAnagramsCla
{
    /**
     * Given an array of strings strs, group the anagrams together. You can return the answer in any order.
     * An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
     * This will order the words in the dictionary and then group them by the ordered word.
     */
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

        IList<IList<string>> result = new List<IList<string>>();

        foreach (string word in strs)
        {
            char[] characters = word.ToArray();
            Array.Sort(characters);
            string orderedWord = new string(characters);
            if (dictionary.TryGetValue(orderedWord, out List<string> value))
            {
                // If the key already exists, we just add the word to the list
                // it means, there were previous words that are anagrams of the current word
                value.Add(word);
            }
            else
            {
                // This means it is the first word that is an anagram of itself
                dictionary.Add(orderedWord, new List<string> { word });
            }
        }

        foreach (var VARIABLE in dictionary.Keys)
        {
            result.Add(dictionary[VARIABLE]);
        }

        return result;
    }

    // public static void Main(string[] args)
    // {
    //     GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]);
    // }
}