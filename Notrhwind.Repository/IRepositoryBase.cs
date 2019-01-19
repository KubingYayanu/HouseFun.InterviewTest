using System.Linq;

namespace Notrhwind.Repository
{
    public interface IRepositoryBase<TModel> where TModel : class, new()
    {
        IQueryable<TModel> GetAll();

        TModel Add(TModel model);

        void Update(TModel model);

        void Delete(TModel model);
    }
}