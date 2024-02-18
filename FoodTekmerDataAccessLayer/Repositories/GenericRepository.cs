using FoodTekmerDataAccessLayer.Abstract;
using FoodTekmerDataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTekmerDataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        FoodyTekmerContext c = new FoodyTekmerContext();
        public void Add(T entity)
        {
            c.Add(entity);
            c.SaveChanges();
        }

        public void Delete(T entity)
        {
            c.Remove(entity);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            return c.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            c.Update(entity);
            c.SaveChanges();
        }
    }
}
