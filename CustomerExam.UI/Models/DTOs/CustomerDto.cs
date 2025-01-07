using CustomerExam.UI.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace CustomerExam.UI.Models.DTOs;

public class CustomerDto
{
    public Guid Id { get; set; }
    public string FullName { get; set; } = default!;

    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime Birthdate { get; set; }

    public Gender Gender { get; set; }
    public List<AddressDto> Addresses { get; set; } = new();
    public List<ContactNumberDto> ContactNumbers { get; set; } = new();
}
