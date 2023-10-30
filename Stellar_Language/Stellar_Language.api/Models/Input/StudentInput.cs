using Stellar_Language.api.Enums;
using Stellar_Language.api.Models.Entities;

namespace Stellar_Language.api.Models.Input;

public class StudentInput:UserInput
{
    public LanguageLevel LanguageLevel { get; set; }
}