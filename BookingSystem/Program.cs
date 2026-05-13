public class Apartment
{
    public int Id { get; set; }
    public string Address { get; set; }
    public int Rooms { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return $"[ID: {Id}] {Address} | Rooms: {Rooms} | Price: {Price}";
    } 
}
public class Host
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public List<Apartment> Apartments { get; set; } = new();

    public override string ToString()
    {
        return $"[ID: {Id}] {Name} | Phone: {Phone} | Apartments: {Apartments.Count}:";
    }
}

class Program
{
    static void Main(string[] args)
    {
        var hosts = new List<Host>
        {
            new()
            {
                Id = 1,
                Name = "Саша",
                Phone = "09999999999",
                Apartments = new List<Apartment>
                {
                    new()
                    { 
                        Id = 1, 
                        Address = "Вулиця Пушкина 1",
                        Rooms = 10,
                        Price = 2
                    }, 
                    new() 
                    { 
                        Id = 2, 
                        Address = "Вулиця Пушкина 2",
                        Rooms = 10,
                        Price = 2
                    }, 
                    new()
                    {
                        Id = 3,
                        Address = "Вулиця Пушкина 3",
                        Rooms = 10,
                        Price = 2
                    }, 
                    new()
                    {
                        Id = 4,
                        Address = "Вулиця Пушкина 4",
                        Rooms = 10,
                        Price = 2
                    }
                }
            },
            new()
            {
                Id = 2, 
                Name = "Даня",
                Phone = "09999999991",
                Apartments = new List<Apartment> { new() { Id = 5 } }
            },
            new()
            {
                Id = 3, 
                Name = "Тест",
                Phone = "09999999992",
                Apartments = new List<Apartment>
                    { new() { Id = 6 }, new() { Id = 7 }, new() { Id = 8 } }
            },
        };

 
        
        Console.WriteLine("Choose host:");
        Console.WriteLine(string.Join(", ", hosts.Select(h => h.Id)));
        if (!int.TryParse(Console.ReadLine(), out var chosenHostId))
        {
            Console.WriteLine("Could not  parse choice"); 
            return;
        }
        var chosenHost = hosts.FirstOrDefault(h => h.Id == chosenHostId);

        if (chosenHost is null)
        {
            Console.WriteLine("Host not found");
            return;
        }
        
        Console.WriteLine(chosenHost);
        foreach (var apartment in chosenHost.Apartments)
        {
            Console.WriteLine(apartment);
        }
    }
}
