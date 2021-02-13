using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Generic Constraint - Generic Kısıtları
    //class : referans tip olabilir
    //T ya IEntity olabilir ya da IEntity ipmlemente edilen bir şey olabilir.
    //new() : new'lenebilir olamlı. Interface newlenemez o yüzden IEntity'yi saf dışı bıraktık.
    public interface IEntityRepository<T> 
        where T:class,
        IEntity,
        new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
