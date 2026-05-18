namespace BookingSystem.Menus;

public class HostMenu(IHostRepository repo)
{
    public void Run()
    {
        PrintMenu();
        switch (Console.ReadLine())
        {
            case "1": ShowAll(); break;
            case "2": GetById(); break;
            case "3": Add(); break;
            case "4": Update(); break;
            case "5": Delete(); break;
            case "0": return;
            default: Console.WriteLine("Invalid choice"); break;
        }
    }

    private static void PrintMenu()
    {
        {
            Console.WriteLine("\n1. Show all hosts");
            Console.WriteLine("2. Get host by ID");
            Console.WriteLine("3. Add host");
            Console.WriteLine("4. Update host");
            Console.WriteLine("5. Delete host");
            Console.WriteLine("0. Exit");
            Console.Write("\nChoose: ");
        }
    }

    private void ShowAll()
    {
        foreach (var host in repo.GetAll())
        {
            Console.WriteLine(host);   
        }
    }

    private void GetById()
    {
        Console.Write("Enter ID:");
        if (!int.TryParse(Console.ReadLine(), out var id)) return;
        var host = repo.GetById(id);
        if (host is null)
        {
             Console.Write("Host is not found");
             return;
        }
        Console.WriteLine(host);
    }

    private void Add()
    {
        Console.Write("Name:");
        var name = Console.ReadLine() ?? "";
        Console.Write("Phone:");
        var phone = Console.ReadLine() ?? "";
        repo.AddHost(new Host { Name = name, Phone = phone });
        Console.Write("Added");
    }

    private void Update()
    {
        Console.Write("Enter ID to update:");
        if (!int.TryParse(Console.ReadLine(), out var id)) return;
        var host = repo.GetById(id);
        if (host is null)
        {
            Console.Write("Host is not found");
        }
        Console.WriteLine(host);
        Console.Write("New Name:");
        var name = Console.ReadLine() ?? "";
        Console.Write("New phone: ");
        var phone = Console.ReadLine() ?? "";
        var updated = repo.UpdateById(id, new Host {Name = name, Phone = phone});
        if (updated is null)
        {
            Console.Write("Not found");
            return;
        }
        Console.Write($"Updated: {updated}");
    }
    private void Delete()
    {
        Console.Write("Enter ID to delete: ");
        if (!int.TryParse(Console.ReadLine(), out var id)) return;
        var deleted = repo.DeleteById(id);
        if (deleted is null)
        {
            Console.WriteLine("Not Found");
            return;
        }
        Console.WriteLine($"Deleted {deleted}");
    }
}