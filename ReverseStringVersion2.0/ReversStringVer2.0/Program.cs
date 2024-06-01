
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

//Check if Input has length over 0, otherwise stop program
if(strInput?.Length > 0)
{
    //create a StringBuilder object
    var newReversedString = new StringBuilder();
    //split input by spaces
    var stringSets = strInput.Split(' ');

    //loop through each splitted string set
    for(int i = 0; i < stringSets.Length; i++)
    {
        //set 2 index pointers at head and tail
        int head = 0;
        int tail = stringSets[i].Length - 1;

        //set stringset to a char array variable
        var set = stringSets[i].ToCharArray();
        //while head doesn't cross path with tails keep looping
        while( head <= tail)
        {
            //switch
            var tmp = set[head];
            set[head] = set[tail];
            set[tail] = tmp;

            //move the indexers
            head++;
            tail--;
        }
        //append set to StringBuilder Object
        newReversedString.Append(new string(set));
        
        //add space at the end of each set while it's not the last set
        if((i + 1 != stringSets.Length) )
            newReversedString.Append(" ");
    }
    Console.WriteLine(newReversedString.ToString());
}
else
{
    Console.WriteLine("No string input provided");
}