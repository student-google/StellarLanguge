using Stellar_Language.api.Data;
using Stellar_Language.api.Models.Entities.common;
using Stellar_Language.api.Repository.contract;

namespace Stellar_Language.api.Repository;

public class BaseRepository<TEntity> : IBaseRepository<TEntity>
    where TEntity : BaseEntity,new()
{
    private readonly DataContext _context;
    public BaseRepository(DataContext context)
    {
        _context = context;
    }
    public IQueryable<TEntity> GetAll()
    {
        return _context.Set<TEntity>();
    }

    public IQueryable<TCunstumEntity> GetAll<TCunstumEntity>() 
        where TCunstumEntity : BaseEntity
    {
        return _context.Set<TCunstumEntity>();
    }

    public TEntity GetById(int id)
    {
        return _context.Set<TEntity>().Find(id);
    }

    public TEntity Create(TEntity input)
    {
        _context.Set<TEntity>().Add(input);
        _context.SaveChanges();
        return input;
    }

    public bool Delete(int id)
    {
        var Entity = _context.Set<TEntity>().Find(id);
        if (Entity != null) 
            _context.Set<TEntity>().Remove(Entity);
        _context.SaveChanges();
        return true;
    }
    public TEntity Update(int id, TEntity input)
    {
        var entity = _context.Set<TEntity>().Find(id);
        if (entity != null) 
            _context.Set<TEntity>().Update(entity);
        _context.SaveChanges();
        return input;
    }

}