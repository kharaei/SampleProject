
using System.ComponentModel.DataAnnotations;

namespace SampleProject.Domain;

public class UserEntity : BaseEntity
{
    [MaxLength(40)]
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string? Fullname { get; set; }
}
