using System;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
	public interface IGenericDal<T> where T: class, IEntity
	{
		void Insert(T entity);
		void Delete(T entity);
		void Update(T entity);
		List<T> GetList();
		T GetById(int id);
	}
}

