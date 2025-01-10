using System.Reflection;

namespace CustomerExam.API.Models.DTOs;

public class CustomerDto
{
    public int Id { get; set; }
    public string FullName { get; set; } = default!;
    public DateTime Birthdate { get; set; }
    public string Gender { get; set; } = default!;
    public List<AddressDto> Addresses { get; set; } = new();
    public List<ContactNumberDto> ContactNumbers { get; set; } = new();
}
