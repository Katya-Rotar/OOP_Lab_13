internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Console.WriteLine(FindIndexToRemove(input));
    }
    static bool Palindromes(string inputItem)
    {
        char[] charArray = inputItem.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);

        return inputItem == reversed;
    }
    static int FindIndexToRemove(string input){
        if (Palindromes(input)) return -1;
        int left = 0;
        int right = input.Length - 1;
        while (left < right)
        {
            if (input[left] != input[right]) {
                if (Palindromes(input.Remove(left, 1))) { return left; }
                else if (Palindromes(input.Remove(right, 1))) { return right; }
                else return -1;
            }
            left++;
            right--;
        }
        return -1;
    }
}