using Stellar_Language.api.Models.Entities.common;

namespace Stellar_Language.api.Models.Output;
public class OnlineClassesOutput:CourseOutput
{
    public string? Link { get; set; }
    public bool Handout { get; set; }
}