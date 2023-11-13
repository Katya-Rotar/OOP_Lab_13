using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string input_A = Console.ReadLine();
        string input_B = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < input_A.Length; i++) {
            for (int j = 0; j < input_B.Length; j++)
            {
                int x = 0;
                if (input_A[i] == input_B[j]) {
                    sb.Append(input_A[i]);
                    while (i + x < input_A.Length && j + x < input_B.Length && input_A[i + x] == input_B[j + x]){
                        sb.Append(input_A[i +x]);
                        x++;
                    }
                }
            }
        }
        if (sb.Length > 0)
        {
            Console.WriteLine("yes");
        }
        else { Console.WriteLine("no"); }
    }
}