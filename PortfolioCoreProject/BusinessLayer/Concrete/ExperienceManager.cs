using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class ExperienceManager : IExperienceService
	{
		private readonly IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void Delete(Experience entity) => _experienceDal.Delete(entity);

        public Experience GetById(int id) => _experienceDal.GetById(id);

        public List<Experience> GetList() => _experienceDal.GetList();

        public void Insert(Experience entity) => _experienceDal.Insert(entity);

        public void Update(Experience entity) => _experienceDal.Update(entity);
    }
}

