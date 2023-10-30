using Stellar_Language.api.Models.Entities.common;

namespace Stellar_Language.api.Models.Entities;

public class StudentCourse:BaseEntity
{
    public int? StudentId { get; set; }
    public Student? Student { get; set; }
    
    public int? CourseId { get; set; }
    public Course? Course { get; set; }
}