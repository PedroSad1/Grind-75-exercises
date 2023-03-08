using System.Collections;

public class ValidParenthesis
{
    public static void Main(string[] args)
    {
        string s = "()";
        Console.WriteLine(IsValid(s));
    }
    public static bool IsValid(string s)
    {
        Stack<char> openBracketStack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' ||
                s[i] == '{' ||
                s[i] == '[')
            {
                openBracketStack.Push(s[i]);
            }
            else
            {
                if (openBracketStack.Count == 0)
                    return false;

                char openBracket = openBracketStack.Pop();

                if (s[i] == '}' && openBracket == '{' ||
                    s[i] == ')' && openBracket == '(' ||
                    s[i] == ']' && openBracket == '[')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

        }

        if (openBracketStack.Count != 0)
            return false;

        return true;
    }

}


