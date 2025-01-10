using System.ComponentModel.DataAnnotations;

namespace CustomerExam.UI.Models.DTOs;

public class CustomerDto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Full name is required.")]
    public string FullName { get; set; } = default!;

    [Required(ErrorMessage = "Birthdate is required.")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime Birthdate { get; set; }

    [Required(ErrorMessage = "Gender is required.")]
    public string Gender { get; set; } = default!;

    [Required(ErrorMessage = "At least one address is required.")]
    [MinLength(1, ErrorMessage = "At least one address is required.")]
    public List<AddressDto> Addresses { get; set; } = new();

    [Required(ErrorMessage = "At least one contact number is required.")]
    [MinLength(1, ErrorMessage = "At least one contact number is required.")]
    public List<ContactNumberDto> ContactNumbers { get; set; } = new();
}
