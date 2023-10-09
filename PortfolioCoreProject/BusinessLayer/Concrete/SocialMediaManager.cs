using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void Delete(SocialMedia entity) => _socialMediaDal.Delete(entity);

        public SocialMedia GetById(int id) => _socialMediaDal.GetById(id);

        public List<SocialMedia> GetList() => _socialMediaDal.GetList();

        public void Insert(SocialMedia entity) => _socialMediaDal.Insert(entity);

        public void Update(SocialMedia entity) => _socialMediaDal.Update(entity);
    }
}

