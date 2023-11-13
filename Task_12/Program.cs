internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        SortedDictionary<string, string> phonebookSort = new SortedDictionary<string, string>();
        while (true) {
            string input = Console.ReadLine();
            if(input.ToLower() == "end") { break; }
            string[] inputArray = input.Split(' ');
            switch (inputArray[0].ToUpper()) {
                case "A":
                    AddContact(phonebook, inputArray[1], inputArray[2]);
                    AddContactSort(phonebookSort, inputArray[1], inputArray[2]);
                    break;
                case "S":
                    SearchContact(phonebook, inputArray[1]);
                    SearchContactSort(phonebookSort, inputArray[1]);
                    break;
                case "LISTALL_1":
                    ListAllContacts_1(phonebook);
                    break;
                case "LISTALL_2":
                    ListAllContacts_2(phonebookSort);
                    break;

            }
        }
        static void AddContact(Dictionary<string, string> phonebook, string name, string phoneNumber) {
            if (phonebook.ContainsKey(phoneNumber))
            {
                phonebook[name] = phoneNumber;
            }
            else {
                phonebook.Add(name, phoneNumber);
            }
        }
        static void SearchContact(Dictionary<string, string> phonebook, string name) {
            if (phonebook.ContainsKey(name))
            {
                Console.WriteLine($"{name} -> {phonebook[name]}");
            }
            else {
                Console.WriteLine($"Contact {name} does not exist.");
            }
        }
        static void ListAllContacts_1(Dictionary<string, string> phonebook)
        {
            foreach (var entry in phonebook.OrderBy(e => e.Key))
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }


        static void AddContactSort(SortedDictionary<string, string> phonebook, string name, string phoneNumber)
        {
            if (phonebook.ContainsKey(phoneNumber))
            {
                phonebook[name] = phoneNumber;
            }
            else
            {
                phonebook.Add(name, phoneNumber);
            }
        }
        static void SearchContactSort(SortedDictionary<string, string> phonebook, string name)
        {
            if (phonebook.ContainsKey(name))
            {
                Console.WriteLine($"{name} -> {phonebook[name]}");
            }
            else
            {
                Console.WriteLine($"Contact {name} does not exist.");
            }
        }
        static void ListAllContacts_2(SortedDictionary<string, string> phonebook)
        {
            foreach (var entry in phonebook)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}