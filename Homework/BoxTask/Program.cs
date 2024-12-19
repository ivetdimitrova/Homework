namespace BoxTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string text = Console.ReadLine();

                box.Add(text);
            }

            Console.WriteLine(box.ToString());
        }
    }
}
