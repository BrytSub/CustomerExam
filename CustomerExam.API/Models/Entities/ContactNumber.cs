namespace CustomerExam.API.Models.Entities;

public class ContactNumber
{
    public int Id { get; set; }
    public string Number { get; set; } = default!;
    public int CustomerId { get; set; }
}
