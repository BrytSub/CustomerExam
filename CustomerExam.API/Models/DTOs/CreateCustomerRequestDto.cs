using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace CustomerExam.API.Models.DTOs;

public class CreateCustomerRequestDto
{
    [Required(ErrorMessage = "Full Name is required.")]
    public string FullName { get; set; } = default!;

    [Required(ErrorMessage = "Birthdate is required.")]
    public DateTime Birthdate { get; set; }

    [Required(ErrorMessage = "Gender is required.")]
    public string Gender { get; set; } = default!;

    [Required(ErrorMessage = "At least one address is required.")]
    [MinLength(1, ErrorMessage = "At least one address must be provided.")]
    public List<AddressDto> Addresses { get; set; } = new();

    [Required(ErrorMessage = "At least one contact number is required.")]
    [MinLength(1, ErrorMessage = "At least one contact number must be provided.")]
    public List<ContactNumberDto> ContactNumbers { get; set; } = new();
}
