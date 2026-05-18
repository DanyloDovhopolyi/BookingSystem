namespace BookingSystem.Repositories.Hosts;

public class HostRepository : IHostRepository
{
    private readonly List<Host> _hosts = new()
    {
        new()
        {
            Id = 1, Name = "Саша", Phone = "09999999999",
            Apartments = new List<Apartment>
            {
                new() { Id = 1, Address = "Вулиця Пушкина 1", Rooms = 10, Price = 2 },
                new() { Id = 2, Address = "Вулиця Пушкина 2", Rooms = 10, Price = 2 },
                new() { Id = 3, Address = "Вулиця Пушкина 3", Rooms = 10, Price = 2 },
                new() { Id = 4, Address = "Вулиця Пушкина 4", Rooms = 10, Price = 2 },
            }
        },
        new()
        {
            Id = 2, Name = "Даня", Phone = "09999999991",
            Apartments = new List<Apartment> { new() { Id = 5 } }
        },
        new()
        {
            Id = 3, Name = "Тест", Phone = "09999999992",
            Apartments = new List<Apartment>
                { new() { Id = 6 }, new() { Id = 7 }, new() { Id = 8 } }
        },
    };

    public IEnumerable<Host> GetAll()
    {
        return _hosts;
    }

    public Host AddHost(Host host)
    {
        host.Id = _hosts.Max(h => h.Id) + 1;
        _hosts.Add(host);
        return host;
    }

    public Host? GetById(int id)
    {
        return _hosts.Find((h) => h.Id == id);
    }

    public Host? DeleteById(int id)
    {
        var host = _hosts.FirstOrDefault(h => h.Id == id);
        if (host is null) return null;

        _hosts.Remove(host);
        return host;
    }

    public Host? UpdateById(int id, Host updated)
    {
        var host = _hosts.Find(h => h.Id == id);
    	if(host is null) return null;

        host.Name = updated.Name;
        host.Phone = updated.Phone;
        host.Apartments = updated.Apartments;

        return host;
    }
}