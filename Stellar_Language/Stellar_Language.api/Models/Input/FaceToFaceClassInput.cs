namespace Stellar_Language.api.Models.Input;

public class FaceToFaceClassInput :CourseInput
{
    public string? AddressClass { get; set; }
    public DateTimeOffset DateClass { get; set; }
    public string? Status { get; set; }
}