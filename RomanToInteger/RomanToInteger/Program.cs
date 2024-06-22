namespace RomanToInteger;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine(RomanToIntegerValue("MCMLXXXIX"));
    }

    static int RomanToIntegerValue(string s)
    {

        #region -- define roman values
        Dictionary<char, int> RomanValues = new Dictionary<char, int>();
        RomanValues.Add('I',1);
        RomanValues.Add('V',5);
        RomanValues.Add('X',10);
        RomanValues.Add('L',50);
        RomanValues.Add('C', 100);
        RomanValues.Add('D', 500);
        RomanValues.Add('M', 1000);
        #endregion

        if (string.IsNullOrEmpty(s))
            return 0;
    
        var integerValue =  0;
        for(int i=0; i < s.ToCharArray().Length; i++)
        {   
            integerValue += RomanValues[s[i]];

            if(i > 0 && RomanValues[s[i-1]] < RomanValues[s[i]])
            {
                var tmp = RomanValues[s[i]] - RomanValues[s[i-1]];
                integerValue -= RomanValues[s[i]] + RomanValues[s[i-1]];

                if(i == 1 && s.Length == 2)
                    return tmp;

                integerValue += tmp;
            }
        }
        return integerValue;
    }
}
