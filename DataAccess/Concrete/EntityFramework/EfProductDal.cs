using DataAccess.Abstract;
using Enities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //IDisposable pattenr implementation of c#
            using (NortWindContext context =new NortWindContext())
            {
                var addedEntity = context.Entry(product);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NortWindContext context = new NortWindContext())
            {
                var DeletedEntity = context.Entry(product);
                DeletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            using (NortWindContext context = new NortWindContext())
            {
                var updatedEntity = context.Entry(product);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
