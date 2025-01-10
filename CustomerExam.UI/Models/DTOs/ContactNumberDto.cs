using System.ComponentModel.DataAnnotations;

namespace CustomerExam.UI.Models.DTOs;

public class ContactNumberDto
{
    [Required(ErrorMessage = "Contact number is required.")]
    public string Number { get; set; } = default!;
}
