using System.Runtime.Serialization.Formatters;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] inputArray = input.Split('@');
        string newEmail = "";
        for (int i = 0; i < inputArray[0].Length; i++)
        {
            newEmail += "*";
        }
        newEmail += $"@{inputArray[1]}";
        Console.WriteLine(newEmail);
        string[] text = Console.ReadLine().Split(' ');
        for (int i = 0; i < text.Length;i++)
        {
            if (text[i] == input) {
                text[i] = newEmail;
            }
            Console.Write(text[i] + " ");
        }
    }
}