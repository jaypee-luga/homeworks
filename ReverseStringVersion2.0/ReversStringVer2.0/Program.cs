
//Reverse all strings in a sentence but keep their position
/*
    Example:
    Microsoft C# is awesome
    Output:
    tfosorciM #C si emosewa
*/

using System.Globalization;
using System.Text;

Console.Clear();
Console.Write("Enter a string phrase: ");
var strInput = Console.ReadLine();

if(strInput?.Length > 0)
{
    var newReversedString = new StringBuilder();
    var stringSets = strInput.Split(' ');

    //Console.WriteLine(stringSets.Length);
    for(int i = 0; i < stringSets.Length; i++)
    {
        int head = 0;
        int tail = stringSets[i].Length - 1;

        var set = stringSets[i].ToCharArray();
        while( head <= tail)
        {
            var tmp = set[head];
            set[head] = set[tail];
            set[tail] = tmp;

            head++;
            tail--;
        }
        newReversedString.Append(new string(set));
        
        if((i + 1 != stringSets.Length) )
            newReversedString.Append(" ");
    }
    Console.WriteLine(newReversedString.ToString());
}
else
{
    Console.WriteLine("No string input provided");
}