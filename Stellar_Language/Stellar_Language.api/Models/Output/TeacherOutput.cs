using Stellar_Language.api.Enums;
using Stellar_Language.api.Models.Entities;

namespace Stellar_Language.api.Models.Output;

public class TeacherOutput:UserOutput
{
    public DegreeOfEducation DegreeOfEducation { get; set; }
    public string? WorkExperience { get; set; }
    public string? LanguageCertificate { get; set; }
    public string? Resume { get; set; }

}