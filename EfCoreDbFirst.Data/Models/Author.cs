namespace EfCoreDbFirst.Data.Models;

public record Author
{
    public int id { get; set; }
    public string first_name {get; set; }
    public string last_name { get; set; }
}