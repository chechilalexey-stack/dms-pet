namespace Backend.Entities;

public class Document
{
    public Guid Id { get; set; }

    public string Number { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string Status { get; set; } = "DRAFT";

    public DateTime CreatedAt { get; set; }
}