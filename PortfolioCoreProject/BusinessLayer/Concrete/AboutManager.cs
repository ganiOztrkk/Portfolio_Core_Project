using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Delete(About entity) => _aboutDal.Delete(entity);

        public About GetById(int id) => _aboutDal.GetById(id);

        public List<About> GetList() => _aboutDal.GetList();

        public void Insert(About entity) => _aboutDal.Insert(entity);

        public void Update(About entity) => _aboutDal.Update(entity);
    }
}

