using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    
        //bizim için bir şablon görevi görür
        public interface IEntityRepository<T> where T : class, IEntity, new() // generic constrain nedir
        {
            T Get(Expression<Func<T, bool>> filter); //bir nesneyi filtreleme yapıyor
            IList<T> GetList(Expression<Func<T, bool>> filter = null); //birden fazla nesneyi filtreleme
            void Add(T entity);
            void Update(T entity);
            void Delete(T entity);
        
    }
}
