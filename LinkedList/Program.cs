namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> list = new MyLinkedList<int>();

            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);

            list.AddFirst(40);
            list.AddFirst(50);
            list.AddFirst(60);

            list.Remove(40);
            list.RemoveLast();
            list.RemoveFirst();

            list.Print();
            Console.WriteLine(list.Count);
        }
    }
}
