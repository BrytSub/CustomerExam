using System.ComponentModel.DataAnnotations;

namespace CustomerExam.UI.Models.DTOs;

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

    [Required(ErrorMessage = "Zip code is required.")]
    public int ZipCode { get; set; }
}
