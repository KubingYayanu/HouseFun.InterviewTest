using Northwind.Entity;
using System.Data.Entity;
using System.Linq;

namespace Notrhwind.Repository
{
    public abstract class RepositoryBase<TDbContext, TModel> : IRepositoryBase<TModel> where TModel : class, new()
    {
        public RepositoryBase()
        {
            context = new NorthwindContext();
            dbSet = context.Set<TModel>();
        }

        #region Properties

        protected DbContext context { get; }
        protected DbSet<TModel> dbSet { get; }

        #endregion Properties

        private void SaveChanges()
        {
            context.SaveChanges();
        }

        public TModel Add(TModel model)
        {
            model = dbSet.Add(model);
            SaveChanges();
            return model;
        }

        public void Delete(TModel model)
        {
            context.Entry(model).State = EntityState.Deleted;
            SaveChanges();
        }

        public IQueryable<TModel> GetAll()
        {
            return dbSet.AsQueryable();
        }

        public void Update(TModel model)
        {
            context.Entry(model).State = EntityState.Modified;
            SaveChanges();
        }
    }
}