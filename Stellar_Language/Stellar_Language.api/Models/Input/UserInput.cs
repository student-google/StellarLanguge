using Stellar_Language.api.Enums;

namespace Stellar_Language.api.Models.Input;

public class UserInput
{
    public string name { get; set; }
    public string family { get; set; }
    public DateOnly BirthDate { get; set; }
    public string Email { get; set; }
    public string password { get; set; }
    public Gender gender { get; set; }
    public string Adress { get; set; }
}