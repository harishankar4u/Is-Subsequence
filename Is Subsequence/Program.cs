public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(IsSubsequence("b","abc"));// true;
        Console.WriteLine(IsSubsequence("abc", "acxbzdc")); //true;
        Console.WriteLine(IsSubsequence("axc", "abcdfe")); //false;
        Console.WriteLine(IsSubsequence("", "abc")); //true;
    }
    public static bool IsSubsequence(string s, string t)
    {
        if (s == "")
        {
            return true;
        }
        int count = 0;
        for (int i = 0; i < t.Length; i++)
        {
            var c1 = s[count];
            if (c1 == t[i])
            {
                count++;
                if(s.Length== count)
                {
                    return true;
                }
            }

        }
        return false;
    }
}