internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string protocol = "";
        string server = "";
        string resource = "";
        string[] URL_1 = input.Split("://");
        if (URL_1.Length >= 2) {
            protocol = URL_1[0];
            string[] URL_2 = URL_1[1].Split('/');
            server = URL_2[0];
            if(URL_2.Length == 2)
            {
                resource = URL_2[1];
            }
            else if(URL_2.Length > 2) {
                for(int i = 1; i < URL_2.Length; i++)
                {
                    resource += URL_2[i] + "/";
                }
            }
        }
        Console.WriteLine($"[protocol] = '{protocol}'");
        Console.WriteLine($"[server] = '{server}'");
        Console.WriteLine($"[resource] = '{resource}'");
    }
}