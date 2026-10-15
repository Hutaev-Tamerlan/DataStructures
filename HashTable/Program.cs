namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var table = new MyHashTable<string, int>(capacity: 5);

            table.Add("Apple", 100);
            table.Add("Banana", 200);
            table.Add("Orange", 150);

            table["Apple"] = 120;

            if (table.Find("Apple", out int applePrice))
            {
                Console.WriteLine(applePrice);
            }

            bool isRemowed = table.Remove("Banana");
            Console.WriteLine(isRemowed);

            bool isFound = table.ContainsKey("Banana");
            Console.WriteLine(isFound);

            Console.WriteLine(table.Count());

            Console.WriteLine(table["Orange"]);
        }
    }
}
