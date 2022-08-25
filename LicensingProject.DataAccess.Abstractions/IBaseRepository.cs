using LicensingProject.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensingProject.DataAccess.Abstractions
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        public IEnumerable<T> GetAll();
        public T GetById(Guid id);
        public T Add(T toAdd);
        public void DeleteById(Guid id);
        public T Update(T toUpdate);
    }
}
