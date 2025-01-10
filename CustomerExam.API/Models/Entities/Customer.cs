using System.Net;
using System.Reflection;

namespace CustomerExam.API.Models.Entities;

public class Customer
{
    public int Id { get; set; }
    public string FullName { get; set; } = default!;
    public DateTime Birthdate { get; set; }
    public string Gender { get; set; } = default!;
    public ICollection<Address> Addresses { get; set; } = new List<Address>();
    public ICollection<ContactNumber> ContactNumbers { get; set; } = new List<ContactNumber>();
}
