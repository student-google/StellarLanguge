using Stellar_Language.api.Models.Entities.common;

namespace Stellar_Language.api.Models;

public class OnlineClasses:Course
{
    public string? Link { get; set; }
    public bool Handout { get; set; }
}