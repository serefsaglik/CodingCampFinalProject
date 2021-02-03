using Enities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    //where T:class : T sadece referans tip olabilir demek
    //where T:class,IEntity -- T ya IEntity ya da IEntity implementi bir referans tip olabilir
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll();
        void Add(T entity);
        void Update(T product);
        void Delete(T product);
        List<T> GetAllByCategory(int categoryId);
    }

    
}
