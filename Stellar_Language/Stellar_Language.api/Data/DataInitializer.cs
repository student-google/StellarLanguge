using Microsoft.EntityFrameworkCore;

namespace Stellar_Language.api.Data;

public class DataInitializer
{
    public static void Initialize(DataContext context)
    {
        context.Database.Migrate();
    }
}