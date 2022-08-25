using LicensingProject.DataAccess.Abstractions;
using LicensingProject.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensingProject.DataAccess.EntityFramework
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly LicensingDbContext dbContext;

        public BaseRepository(LicensingDbContext dbContext)
        { 
            this.dbContext = dbContext;
        }
        public T Add(T toAdd)
        {
           var entity = dbContext.Set<T>().Add(toAdd);
           dbContext.SaveChanges();
           return entity.Entity;
        }

        public void DeleteById(Guid id)
        {
            var toDelete = GetById(id);
            dbContext.Set<T>()
                     .Remove(toDelete);
            dbContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>()
                .ToList();
        }

        public T GetById(Guid id)
        {
          return dbContext.Set<T>().Where(x => x.Id == id)
                              .First();
        }

        public T Update(T toUpdate)
        {
            dbContext.Set<T>().Update(toUpdate);
            dbContext.SaveChanges();
            return toUpdate;
        }
    }
}
