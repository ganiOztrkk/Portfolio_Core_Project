using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IGenericService<T> where T:class, IEntity
	{
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetList();
        T GetById(int id);
    }
}

