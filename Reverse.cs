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
}