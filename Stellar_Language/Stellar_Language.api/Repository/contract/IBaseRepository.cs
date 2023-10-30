using Stellar_Language.api.Models.Entities.common;

namespace Stellar_Language.api.Repository.contract;

public interface IBaseRepository<TEntity>
    where TEntity : BaseEntity,new()
{
    IQueryable<TEntity>GetAll();
    IQueryable<TCunstumEntity>GetAll<TCunstumEntity>()where TCunstumEntity : BaseEntity;
    TEntity GetById(int id);
    TEntity Create(TEntity input);
    TEntity Update(int id, TEntity input);
    bool Delete(int id);
}