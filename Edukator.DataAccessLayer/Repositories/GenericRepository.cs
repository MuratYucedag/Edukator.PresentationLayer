using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            var context = new Context();
            context.Remove(t);
            context.SaveChanges();
        }

        public T GetByID(int id)
        {
            var context = new Context();
            return context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            var context = new Context();
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            var context = new Context();
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            var context = new Context();
            context.Update(t);
            context.SaveChanges();
        }
    }
}
