namespace Training;

public class SherlockAndTheValidString
{
    public static string isValid(string s)
    {
        Dictionary<char, int> elements = new Dictionary<char, int>();

        Char[] array = s.ToCharArray();

        foreach (var element in array)
        {
            if (elements.TryGetValue(element, out int number))
            {
                number++;
                elements[element] = number;
            }
            else
            {
                elements.Add(element, 1);
            }
        }


        int aux = elements[array[0]];

        bool cartigredeUsed = false;

        var values = elements.Values;
        bool cartigredUsed = false;
        foreach (var VARIABLE in values)
        {
            if (VARIABLE != aux)
            {
                if (VARIABLE == 1 && !cartigredeUsed)
                {
                    cartigredeUsed = true;
                    continue;
                }
                
                if (Math.Abs(aux - VARIABLE) > 1)
                {
                    return "NO";
                }

                if (!cartigredeUsed)
                {
                    cartigredeUsed = true;
                    continue;
                }

                return "NO";
            }
        }

        return "YES";
    }

    /*public static void Main(string[] args)
    {
        isValid("ibfdgaeadiaefgbhbdghhhbgdfgeiccbiehhfcggchgghadhdhagfbahhddgghbdehidbibaeaagaeeigffcebfbaieggabcfbiiedcabfihchdfabifahcbhagccbdfifhghcadfiadeeaheeddddiecaicbgigccageicehfdhdgafaddhffadigfhhcaedcedecafeacbdacgfgfeeibgaiffdehigebhhehiaahfidibccdcdagifgaihacihadecgifihbebffebdfbchbgigeccahgihbcbcaggebaaafgfedbfgagfediddghdgbgehhhifhgcedechahidcbchebheihaadbbbiaiccededchdagfhccfdefigfibifabeiaccghcegfbcghaefifbachebaacbhbfgfddeceababbacgffbagidebeadfihaefefegbghgddbbgddeehgfbhafbccidebgehifafgbghafacgfdccgifdcbbbidfifhdaibgigebigaedeaaiadegfefbhacgddhchgcbgcaeaieiegiffchbgbebgbehbbfcebciiagacaiechdigbgbghefcahgbhfibhedaeeiffebdiabcifgccdefabccdghehfibfiifdaicfedagahhdcbhbicdgibgcedieihcichadgchgbdcdagaihebbabhibcihicadgadfcihdheefbhffiageddhgahaidfdhhdbgciiaciegchiiebfbcbhaeagccfhbfhaddagnfieihghfbaggiffbbfbecgaiiidccdceadbbdfgigibgcgchafccdchgifdeieicbaididhfcfdedbhaadedfageigfdehgcdaecaebebebfcieaecfagfdieaefdiedbcadchabhebgehiidfcgahcdhcdhgchhiiheffiifeegcfdgbdeffhgeghdfhbfbifgidcafbfcd");
    }*/
}