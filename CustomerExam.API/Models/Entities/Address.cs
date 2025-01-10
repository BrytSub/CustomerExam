namespace CustomerExam.API.Models.Entities;

public class Address
{
    public int Id { get; set; }
    public string Street { get; set; } = default!;
    public string Barangay { get; set; } = default!;
    public string City { get; set; } = default!;
    public string Province { get; set; } = default!;
    public int ZipCode { get; set; }
    public int CustomerId { get; set; }
}
