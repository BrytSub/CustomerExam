using CustomerExam.API.Models.Common;
using CustomerExam.API.Models.Enums;
using System.Reflection;

namespace CustomerExam.API.Models.Entities;

public class Customer : BaseEntity
{
    public string FullName { get; set; } = default!;
    public DateTime Birthdate { get; set; }
    public Gender Gender { get; set; }
    public ICollection<Address> Addresses { get; set; } = new List<Address>();
    public ICollection<ContactNumber> ContactNumbers { get; set; } = new List<ContactNumber>();
}
