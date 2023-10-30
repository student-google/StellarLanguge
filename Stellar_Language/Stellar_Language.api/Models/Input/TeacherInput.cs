using Stellar_Language.api.Enums;
using Stellar_Language.api.Models.Entities;

namespace Stellar_Language.api.Models.Input;

public class TeacherInput:UserInput
{
    public DegreeOfEducation DegreeOfEducation { get; set; }
    public string? WorkExperience { get; set; }
    public string? LanguageCertificate { get; set; }
    public string? Resume { get; set; }

}