using Stellar_Language.api.Models.Entities.common;
using Stellar_Language.api.Repository.contract;

namespace Stellar_Language.api.Service.Contracts;

public interface IBaseService<TEntity,TInput>
    where TEntity : BaseEntity,new()
    where TInput : class
{
    IQueryable<TEntity> Get();
   
    IQueryable<TEntity>GetAll();
    IQueryable<TCustomEntity>Get<TCustomEntity>()
        where TCustomEntity : BaseEntity;
    TEntity GetById(int id);
    TEntity Create(TInput input);
    TEntity Update(int id, TInput input);
    bool Delete(int id);
}