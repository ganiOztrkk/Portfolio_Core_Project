using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class ServiceManager : IServiceService
	{
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void Delete(Service entity) => _serviceDal.Delete(entity);

        public Service GetById(int id) => _serviceDal.GetById(id);

        public List<Service> GetList() => _serviceDal.GetList();

        public void Insert(Service entity) => _serviceDal.Insert(entity);

        public void Update(Service entity) => _serviceDal.Update(entity);
    }
}

