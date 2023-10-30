using Stellar_Language.api.Models.Entities.common;

namespace Stellar_Language.api.Models.Input;

public class OnlineClassesInput:CourseInput
{
    public string? Link { get; set; }
    public bool Handout { get; set; }
}