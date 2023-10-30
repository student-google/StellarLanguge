using Microsoft.EntityFrameworkCore;
using Stellar_Language.api.Models;
using Stellar_Language.api.Models.Entities;
using Stellar_Language.api.Models.Entities.common;

namespace Stellar_Language.api.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    /*
     * This code is useful for preventing accidental data loss.
     * For example, if you have a Customer table with a foreign
     * key to an Order table, and you delete a customer record,
     * you may not want to delete all of the associated order records.
     * By setting the DeleteBehavior property of the foreign key to DeleteBehavior.Restrict,
     * you can prevent this from happening.
     */

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            relationship.DeleteBehavior = DeleteBehavior.Restrict;
        }
    }

    public override int SaveChanges()
    {
        foreach (var entry in ChangeTracker.Entries<BaseEntity>())
        {
            switch(entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreationDate = DateTimeOffset.UtcNow;
                    break;
                case EntityState.Modified:
                    entry.Entity.ModificationDate = DateTimeOffset.UtcNow;
                    break;
                case EntityState.Deleted:
                    entry.Entity.Deletedate = DateTimeOffset.UtcNow;
                    break;
                default:
                    break;
            }
        }
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in ChangeTracker.Entries<BaseEntity>())
        {
            switch(entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreationDate = DateTimeOffset.UtcNow;
                    break;
                case EntityState.Modified:
                    entry.Entity.ModificationDate = DateTimeOffset.UtcNow;
                    break;
                case EntityState.Deleted:
                    entry.Entity.Deletedate = DateTimeOffset.UtcNow;
                    break;
                default:
                    break;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }



public DbSet<User> Users { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<StudentCourse> StudentCourses { get; set; }
    //public DbSet<CourseCategory>CourseCategories { get; set; }
}