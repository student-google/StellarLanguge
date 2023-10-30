namespace Stellar_Language.api.Models.Entities.common;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTimeOffset CreationDate { get; set; }
    public DateTimeOffset ModificationDate { get; set; }
    public DateTimeOffset Deletedate { get; set; }
    public bool IsArcive { get; set; }
}