class Host
{
    public int  Id { get; set; }
    public string Name { get; set; }
    
}

class Apartment
{
    public int Id { get; set; }
    public List<int> HostId { get; set; } = new();
}

class Program
{
    static void Main(string[] args)
    {
        var hosts = new List<Host>
        {
            new Host { Id = 1, Name = "Алексей" },
            new Host { Id = 2, Name = "Мария" },
            new Host { Id = 3, Name = "Иван" },
        };

        var apartments = new List<Apartment>
        {
            new Apartment { Id = 1, HostId = new List<int> { 1, 2 } },  
            new Apartment { Id = 2, HostId = new List<int> { 3 } },
            new Apartment { Id = 3, HostId = new List<int> { 1 } },
        };
        
        Console.WriteLine("Choose host:");
        Console.WriteLine(string.Join(", ", hosts.Select(h => h.Id)));
        var choosedHostId = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose apartment:");
        foreach (var a in apartments)
        {
            if (a.HostId.Contains(choosedHostId))
            {
                Console.WriteLine($"Apartment ID: {a.Id}");
            }
        }
    }

  
}
