namespace verCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==========================================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Git Submodule Demo");
            Console.ResetColor();

            List<verCheckData> datas = new();
            datas.Add(new verCheckData() { Name="EC", Hash= Guid.NewGuid().ToString() });
            datas.Add(new verCheckData() { Name = "OPS", Hash = Guid.NewGuid().ToString() });


            foreach (var data in datas)
            {
                Console.WriteLine($"   > Name: {data.Name}, Hash: {data.Hash}");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Goodbye!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==========================================================");
            Console.ResetColor();

        }
    }
}