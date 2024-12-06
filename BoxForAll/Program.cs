namespace BoxForAll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Box<int> a = new Box<int>(123123);
            a.ToString();
            Box<string> b = new Box<string>("life in a box");
            b.ToString();
            int count=int.Parse(Console.ReadLine());
            List<Box<string>> list = new List<Box<string>>();
            for (int i = 0; i < count; i++) 
            {
                string string_ = Console.ReadLine();
                Box<string> c = new Box<string>(string_);
                list.Add(c);
            }
            for (int i = 0; i < count; i++)
            {
                list[i].ToString();
            }

        }
    }
}
