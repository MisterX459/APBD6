namespace WebApplication6;

using System.ComponentModel.DataAnnotations;

public class AddAnimalRequest
{
    [MinLength(3)]
    [MaxLength(100)]
    public string Name { get; set; }
    [MaxLength(200)]
    public string? Description { get; set; }
    [MinLength(3)]
    [MaxLength(200)]
    public string Category { get; set; }
    [MinLength(3)]
    [MaxLength(200)]
    public string Area { get; set; }
}