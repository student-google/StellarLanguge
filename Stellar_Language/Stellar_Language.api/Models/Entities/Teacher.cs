using Stellar_Language.api.Enums;
using Stellar_Language.api.Models.Entities.common;

namespace Stellar_Language.api.Models.Entities;

public class Teacher:User
{
    public DegreeOfEducation DegreeOfEducation { get; set; }
    public string? WorkExperience { get; set; }
    public string? LanguageCertificate { get; set; }
    public string? Resume { get; set; }

    public ICollection<Course> Courses { get; set; }
}