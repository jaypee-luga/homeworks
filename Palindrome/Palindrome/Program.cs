        
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        
        var x=-2147483648;
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
        Console.WriteLine(new string(xString));
        var reversed = Int64.Parse(new string(xString));

        if(isNegative)
            reversed = reversed * -1;

        if( x == reversed )
            Console.WriteLine("Palindrome");