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