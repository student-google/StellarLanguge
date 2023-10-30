using Stellar_Language.api.Enums;
using Stellar_Language.api.Models.Entities.common;

namespace Stellar_Language.api.Models.Entities;

public class User:BaseEntity
{
    public string name { get; set; }
    public string family { get; set; }
    public DateTimeOffset BirthDate { get; set; }
    public string Email { get; set; }
    public string password { get; set; }
    public Gender gender { get; set; }
    public string Adress { get; set; }
}