using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Delete(Feature entity) => _featureDal.Delete(entity);

        public Feature GetById(int id) => _featureDal.GetById(id);

        public List<Feature> GetList() => _featureDal.GetList();

        public void Insert(Feature entity) => _featureDal.Insert(entity);

        public void Update(Feature entity) => _featureDal.Update(entity);
    }
}

