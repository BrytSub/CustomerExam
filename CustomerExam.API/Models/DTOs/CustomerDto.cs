using CustomerExam.API.Models.Enums;

namespace CustomerExam.API.Models.DTOs;

public class CustomerDto
{
    public Guid Id { get; set; }
    public string FullName { get; set; } = default!;
    public DateTime Birthdate { get; set; }
    public Gender Gender { get; set; }
    public List<AddressDto> Addresses { get; set; } = new();
    public List<ContactNumberDto> ContactNumbers { get; set; } = new();
}
