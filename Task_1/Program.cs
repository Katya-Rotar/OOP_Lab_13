internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string reversesInput = Reverses(input);
        Console.WriteLine(reversesInput);
    }
    public static string Reverses(string input) {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}