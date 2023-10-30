namespace Stellar_Language.api.Models.Entities.common;

public class Course:BaseEntity
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Evidence { get; set; }
    public string? Term { get; set; }
    public string? Session { get; set; }
    public string? Price { get; set; }
    public string? Support { get; set; }
    public string? Capacity { get; set; }
    public string? Discount { get; set; }


    public Teacher teacher { get; set; }
    public int teacherId { get; set; }
    
    public ICollection<Student> students { get; set; }
}