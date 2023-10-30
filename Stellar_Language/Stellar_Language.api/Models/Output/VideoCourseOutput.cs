using Stellar_Language.api.Models.Entities.common;

namespace Stellar_Language.api.Models.Output;
public class VideoCourseOutput:CourseOutput
{
    public bool DownloadVideo { get; set; }
    public string? Size { get; set; }
    public string? Status { get; set; }
}