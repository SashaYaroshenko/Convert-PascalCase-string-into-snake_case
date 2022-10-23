using System;

public static class Kata
{
    public static string ToUnderscore(int str)
    {
        //str = Regex.Replace(str, "([a-z0-9])([A-Z])", "$1_$2");
        //return str.ToLower();

        return str.ToString();
        
    }

    public static string ToUnderscore(string str)
    {
        //str = Regex.Replace(str, "(.)([A-Z][a-z]+)", "$1_$2");
        //return str.ToLower();

        //return Regex.Replace(str, @"(.)([A-Z])", @"$1_$2").ToLower();

        string result = "";
        for(int i=0; i < str.ToCharArray().Length; i++)
        {
            if(Char.IsUpper(str[i]))
            {
                result+= "_" + str[i];
            }
            else
            {
                result+=str[i];
            }
        }
        result = result.TrimStart('_').ToLower();
        return result;
    }
}

