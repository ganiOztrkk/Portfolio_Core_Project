using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Delete(Testimonial entity) => _testimonialDal.Delete(entity);

        public Testimonial GetById(int id) => _testimonialDal.GetById(id);

        public List<Testimonial> GetList() => _testimonialDal.GetList();

        public void Insert(Testimonial entity) => _testimonialDal.Insert(entity);

        public void Update(Testimonial entity) => _testimonialDal.Update(entity);
    }
}

