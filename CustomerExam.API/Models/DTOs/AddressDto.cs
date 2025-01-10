using System.ComponentModel.DataAnnotations;

namespace CustomerExam.API.Models.DTOs;

public class AddressDto
{
    [Required(ErrorMessage = "Street is required.")]
    public string Street { get; set; } = default!;

    [Required(ErrorMessage = "Barangay is required.")]
    public string Barangay { get; set; } = default!;

    [Required(ErrorMessage = "City is required.")]
    public string City { get; set; } = default!;

    [Required(ErrorMessage = "Province is required.")]
    public string Province { get; set; } = default!;

    [Required(ErrorMessage = "Zip Code is required.")]
    [Range(1000, 9999, ErrorMessage = "Zip Code must be a valid 4-digit number.")]
    public int ZipCode { get; set; }
}
