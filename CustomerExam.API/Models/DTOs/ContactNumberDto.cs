using System.ComponentModel.DataAnnotations;

namespace CustomerExam.API.Models.DTOs;

public class ContactNumberDto
{
    [Required(ErrorMessage = "Contact number is required.")]
    public string Number { get; set; } = default!;
}
