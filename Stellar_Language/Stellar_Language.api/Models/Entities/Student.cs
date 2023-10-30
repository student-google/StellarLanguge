using Stellar_Language.api.Enums;
using Stellar_Language.api.Models.Entities.common;

namespace Stellar_Language.api.Models.Entities;

public class Student:User
{
    public LanguageLevel LanguageLevel { get; set; }

    public ICollection<StudentCourse> StudentCourses { get; set; }
}