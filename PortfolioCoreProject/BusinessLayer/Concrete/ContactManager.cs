using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class ContactManager : IContactService
	{
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Delete(Contact entity) => _contactDal.Delete(entity);

        public Contact GetById(int id) => _contactDal.GetById(id);

        public List<Contact> GetList() => _contactDal.GetList();

        public void Insert(Contact entity) => _contactDal.Insert(entity);

        public void Update(Contact entity) => _contactDal.Update(entity);
    }
}

