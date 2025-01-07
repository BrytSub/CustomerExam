using CustomerExam.API.Models.Common;

namespace CustomerExam.API.Models.Entities;

public class Address : BaseEntity
{
    public string Street { get; set; } = default!;
    public string Barangay { get; set; } = default!;
    public string City { get; set; } = default!;
    public string Province { get; set; } = default!;
    public int ZipCode { get; set; }
    public Guid CustomerId { get; set; }
}
