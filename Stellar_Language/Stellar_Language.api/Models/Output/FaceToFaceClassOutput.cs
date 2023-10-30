namespace Stellar_Language.api.Models.Output;
public class FaceToFaceClassOutput:CourseOutput
{
    public string? AddressClass { get; set; }
    public DateTimeOffset DateClass { get; set; }
    public string? Status { get; set; }
}