namespace Training;

public class BalancedBrackets
{
    public static string isBalanced(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (var bracket in s.ToCharArray())
        {
            if (isOpenBracket(bracket))
            {
                stack.Push(bracket);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return "NO";
                }

                char previousChar = stack.Pop();
                if (bracket is ')' && previousChar is '(')
                {
                    continue;
                }

                if (bracket is '}' && previousChar is '{')
                {
                    continue;
                }

                if (bracket is ']' && previousChar is '[')
                {
                    continue;
                }


                return "NO";
            }
        }

        return stack.Count == 0 ? "YES" : "NO";
    }

    public static bool isOpenBracket(char s)
    {
        return s is '(' or '{' or '[';
    }

    /*public static void Main(string[] args)
    {
        string result = isBalanced("[](){()}");
    }*/
}