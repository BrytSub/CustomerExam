using CustomerExam.API.Models.Common;

namespace CustomerExam.API.Models.Entities;

public class ContactNumber : BaseEntity
{
    public string Number { get; set; } = default!;
    public Guid CustomerId { get; set; }
}
