 IList<string> CommonChars(string[] words) {
        
        var chars = new Dictionary<string, int>();
        foreach(var word in words)
        {
            var charArray = word.ToCharArray();
            foreach(var c in charArray)
            {
                if(!chars.ContainsKey(c.ToString()))
                {
                    chars.Add(c.ToString(),1);
                    continue;
                }
                
                chars[c.ToString()]++;
            }
        }

        var commonChars = chars.Where(x => x.Value == words.Length ).ToDictionary().Keys.ToList();
        return commonChars;
}

Console.Clear();
var result = CommonChars(new string[] { "bella", "label", "roller"});
foreach(var word in result)
{
    Console.Write($"{word} ");
}