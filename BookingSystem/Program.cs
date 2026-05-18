using BookingSystem.Menus;
using BookingSystem.Repositories.Hosts;

class Program
{
    static void Main(string[] args)
    {
        IHostRepository hostRepo = new HostRepository();
        new HostMenu(hostRepo).Run();
    }
}
