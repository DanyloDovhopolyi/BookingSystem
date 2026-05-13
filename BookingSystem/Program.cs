class Apartment
{
    public int Id { get; set; }
}
class Host
{
    public int  Id { get; set; }
    public List<Apartment> Apartments { get; set; } = new();
}

class Program
{
    static void Main(string[] args)
    {
        var hosts = new List<Host>
        {
            new Host
            {
                Id = 1, Apartments = new List<Apartment> { new Apartment { Id = 1 }, new Apartment { Id = 2 } }
            },
            new Host
            {
                Id = 2, Apartments = new List<Apartment> { new Apartment { Id = 3 } }
            },
            new Host
            {
                Id = 3, Apartments = new List<Apartment>
                    { new Apartment { Id = 4 }, new Apartment { Id = 5 }, new Apartment { Id = 6 } }
            },
        };

 
        
        Console.WriteLine("Choose host:");
        Console.WriteLine(string.Join(", ", hosts.Select(h => h.Id)));

        var chosenHostId = int.Parse(Console.ReadLine());
        var chosenHost = hosts.FirstOrDefault(h => h.Id == chosenHostId);

        if (chosenHost == null)
        {
            Console.WriteLine("Host not found");
            return;
        }

        Console.WriteLine($"Apartments of {chosenHost.Id}:");
        foreach (var a in chosenHost.Apartments)
        {
            Console.WriteLine($"Apartment ID: {a.Id}");
        }
        
        
    }

  
}
