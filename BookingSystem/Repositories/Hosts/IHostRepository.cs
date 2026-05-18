public interface IHostRepository
{
    IEnumerable<Host> GetAll();
    Host? AddHost(Host host);
    Host? GetById(int id);
    Host? UpdateById(int id, Host host);
    Host? DeleteById(int id);
}