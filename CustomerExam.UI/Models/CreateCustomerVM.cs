using CustomerExam.UI.Models.DTOs;
using System.ComponentModel.DataAnnotations;

namespace CustomerExam.UI.Models;

public class CreateCustomerVM
{
    [Required(ErrorMessage = "Full name is required.")]
    public string FullName { get; set; } = default!;

    [Required(ErrorMessage = "Birthdate is required.")]
    public DateTime Birthdate { get; set; }

    [Required(ErrorMessage = "Gender is required.")]
    public string Gender { get; set; } = default!;

    [Required(ErrorMessage = "At least one address is required.")]
    public List<AddressDto> Addresses { get; set; } = new();

    [Required(ErrorMessage = "At least one contact number is required.")]
    public List<ContactNumberDto> ContactNumbers { get; set; } = new();
}
