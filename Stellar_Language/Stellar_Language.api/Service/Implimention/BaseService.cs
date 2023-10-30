using Mapster;
using Stellar_Language.api.Models.Entities.common;
using Stellar_Language.api.Repository.contract;
using Stellar_Language.api.Service.Contracts;

namespace Stellar_Language.api.Service.Implimention;

public class BaseService<TEntity, TInput>: IBaseService<TEntity, TInput>
    where TEntity : BaseEntity, new()
    where TInput : class
{
    private readonly IBaseRepository<TEntity> _repository;

    public BaseService(IBaseRepository<TEntity> repository)
    {
        _repository = repository;
    }

    public IQueryable<TEntity> Get()
    {
        return _repository.GetAll();
    }

    public IQueryable<TCustomEntity> Get<TCustomEntity>() 
        where TCustomEntity : BaseEntity
    {
        return _repository.GetAll<TCustomEntity>();
    }

    public virtual IQueryable<TEntity> GetAll()
    {
        var result = _repository.GetAll().ToList();
        if (result == null)
            return null;
        return result.AsQueryable();
    }
    
    public virtual TEntity GetById(int id)
    {
        var result = _repository.GetById(id);
        if (result == null)
            return null;
        return result;
    }

    public virtual TEntity Create(TInput input)
    {
        var Entity = input.Adapt<TEntity>();
        var result= _repository.Create(Entity);
        return result;
    }

    public TEntity Update(int id, TInput input)
    {
        var result = _repository.GetById(id);
        if (result == null)
            return null;
        var Entity = input.Adapt<TEntity>();    
        var resultExist= _repository.Update(id, Entity);
        return resultExist;
    }

    public bool Delete(int id)
    {
        var result = _repository.GetById(id);
        if (result == null)
            return false;
        var resultExist= _repository.Delete(id);
        return resultExist;
    }
}