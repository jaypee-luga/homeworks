public class Solution {
    public bool IsPalindrome(int x) {
        
        if(x == int.MinValue || x == int.MaxValue)
            return false;

        var isNegative = false;
        if(x < 0)
        {
            isNegative = true;
            x = x * -1;
        }

        var l = 0;
        var r = x.ToString().Length - 1;
        var xString = x.ToString().ToCharArray();
        
        while(l < r)
        {
            char tmp = ' ';
            tmp = xString[l];
            xString[l] = xString[r];
            xString[r] = tmp;

            l++;
            r--;
        }

        var reversed = Int64.Parse(new string(xString));

        if(isNegative)
            reversed = reversed * -1;

        return x == reversed;
    }
}
