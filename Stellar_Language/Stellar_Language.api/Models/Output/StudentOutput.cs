using Stellar_Language.api.Enums;
using Stellar_Language.api.Models.Entities;

namespace Stellar_Language.api.Models.Output;
public class StudentOutput:UserOutput
{
    public LanguageLevel LanguageLevel { get; set; }
}