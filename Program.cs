using data = verCheckData;

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

            List<data.Root> datas = new();

            List<data.Address> bkAddys = new()
            {
                new data.Address() { Street = "123 Main St", City = "New York", County = "New York", State = "NY" },
                new data.Address() { Street = "456 Main St", City = "New York", County = "New York", State = "NY" },
                new data.Address() { Street = "789 Main St", City = "New York", County = "New York", State = "NY" }
            };


            datas.Add(new data.Root() { Name="Burger King", Hash= Guid.NewGuid().ToString(), Addresses=bkAddys });

            List<data.Address> wendysAddys = new()
            {
                new data.Address() { Street = "123 Main St", City = "St Paul", County = "Ramsey", State = "MN" },
                new data.Address() { Street = "456 Main St", City = "Kalispell", County = "Flathead", State = "MT" },
                new data.Address() { Street = "789 Main St", City = "Alpine", County = "Wyoming", State = "WY" }
            };


            datas.Add(new data.Root() { Name = "Wendys", Hash = Guid.NewGuid().ToString(), Addresses= wendysAddys });


            foreach (var data in datas)
            {
                Console.WriteLine($"   > Name: {data.Name}, Hash: {data.Hash}");
                foreach( var addy in data.Addresses)
                {
                    Console.WriteLine($"      > Street: {addy.Street}, City: {addy.City}, County: {addy.County}, State: {addy.State}");
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Goodbye!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==========================================================");
            Console.ResetColor();

            Console.WriteLine("Last Change From: HOME");
        }
    }
}