using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        char[] separators = { ' ', ',', '.', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?' };
        List<string> uniquePalindromes = new List<string>();
        string[] input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        foreach (string inputItem in input)
        {
            if(Palindromes(inputItem) && !uniquePalindromes.Contains(inputItem))
            {
                uniquePalindromes.Add(inputItem);
            }
        }
        uniquePalindromes.Sort();
        string result = string.Join(", ", uniquePalindromes);
        Console.WriteLine(result);
    }
    static bool Palindromes(string inputItem) {
        char[] charArray = inputItem.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);

        return inputItem == reversed;
    }
}