using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Regex regex = new Regex(@"<upcase>(.*?)<\/upcase>");
        MatchCollection matchCollection = regex.Matches(input);
        
        foreach (Match match in matchCollection)
        {
            string uppercase = match.Value.ToUpper();
            input = input.Replace(match.Value, uppercase);
        }
        string[] upcase = new string[] { "<UPCASE>", "</UPCASE>" };
        string[] text = input.Split(upcase, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(string.Join("", text));
    }
}