namespace SampleProject.Domain.Entities;

public class WorkbookEntity : BaseEntity
{
    public string? Title { get; set; }
    public int UserId { get; set; }

    public UserEntity? User { get; set; }
}