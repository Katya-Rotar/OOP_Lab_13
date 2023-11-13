class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine(); 
        char[] separators = " .,:;=()&[]\"'\\/!?".ToCharArray();
        string[] wordsInput = input.Split(separators, StringSplitOptions.RemoveEmptyEntries); 
        string[] separatorsInput = input.Split(wordsInput, StringSplitOptions.RemoveEmptyEntries);
        wordsInput = Reverses(wordsInput);
        for (int i = 0, j = 0; i < wordsInput.Length && j < separatorsInput.Length; i++, j++)
        {
            Console.Write(wordsInput[i] + separatorsInput[j]);
        }
    }
    public static string[] Reverses(string[] input)
    {
        return input.Reverse().ToArray();
    }
}