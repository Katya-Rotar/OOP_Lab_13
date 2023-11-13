internal class Program
{
    private static void Main(string[] args)
    {
        char[] separators = { ' ', ',', '.', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?' };
        string[] input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        string returnText = Capitalize(input);
        Console.WriteLine(returnText);

    }
    static string Capitalize(string[] text) {
        for (int i = 0; i < text.Length; i++)
        {
            char firstChar = char.ToUpper(text[i][0]);
            text[i] = firstChar + text[i].Substring(1);
        }
        return string.Join(" ", text);
    }
}