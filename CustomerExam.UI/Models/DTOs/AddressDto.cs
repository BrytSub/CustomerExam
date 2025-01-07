namespace CustomerExam.UI.Models.DTOs;

public class AddressDto
{
    public string Street { get; set; } = default!;
    public string Barangay { get; set; } = default!;
    public string City { get; set; } = default!;
    public string Province { get; set; } = default!;
    public int ZipCode { get; set; }
}
