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