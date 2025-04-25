namespace codingtest;

public static class Reverse
{
    public static int intReverse(int num)
    {
        int revNum = 0;
        do
        {
            int n = num % 10;
            revNum = revNum* 10 + n;
            num /= 10;
        } while (num > 0);
        return revNum;
    }

    public static string strReverse(string str)
    {
        char[] chars = str.ToCharArray();
        string newString = "";
        for (int i= chars.Length -1 ; i >=0 ; i--)
        {
            newString += chars[i].ToString();
        }
        return newString;
    }

    public static bool strPalindrome(string str)
    {
        char[] chars = str.ToCharArray();
        string newString = "";
        for (int i = chars.Length - 1; i >= 0; i--)
        {
            newString += chars[i].ToString();
        }
        return newString == str;
    }

    public static void countEachCharacter(string str)
    {
        Dictionary<char, int> characterCount = new Dictionary<char, int>();
        foreach (var character in str)
        {
            if (character != ' ')
            {
                if (!characterCount.ContainsKey(character))
                {
                    characterCount.Add(character, 1);
                }
                else
                {
                    characterCount[character]++;
                }
            }
        }
        foreach(var c in characterCount)
        {
            Console.WriteLine("{0} : {1}",c.Key, c.Value);
        }
    }

    public static string removeString(string Str)
    {
        string result = string.Empty;
        foreach(char c in Str)
        {
            if (!result.Contains(c))
            {
                result += c;
            }
        }
        return result;
    }
}