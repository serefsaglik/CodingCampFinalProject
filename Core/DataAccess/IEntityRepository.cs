using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint
    //where T:class : T sadece referans tip olabilir demek
    //where T:class,IEntity -- T ya IEntity ya da IEntity implementi bir referans tip olabilir
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        void Add(T entity);
        void Update(T product);
        void Delete(T product);
        
    }

    
}
