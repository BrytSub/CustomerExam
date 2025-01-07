using CustomerExam.UI.Models.DTOs;
using CustomerExam.UI.Models.Enums;

namespace CustomerExam.UI.Models;

public class CreateCustomerVM
{
    public string FullName { get; set; } = default!;
    public DateTime Birthdate { get; set; }
    public Gender Gender { get; set; }
    public List<AddressDto> Addresses { get; set; } = new();
    public List<ContactNumberDto> ContactNumbers { get; set; } = new();
}
