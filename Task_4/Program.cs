internal class Program
{
    private static void Main(string[] args)
    {
        string word = Console.ReadLine();
        string[] sentences = Console.ReadLine().Split('.', '!','?');
        for(int i = 0; i < sentences.Length; i++)
        {
            string[] sentence = sentences[i].Split(' ', ',');
            for(int j = 0; j < sentence.Length; j++)
            {
                if (sentence[j] == word) {
                    Console.WriteLine(sentences[i]);
                }
            }
        }
    }
}