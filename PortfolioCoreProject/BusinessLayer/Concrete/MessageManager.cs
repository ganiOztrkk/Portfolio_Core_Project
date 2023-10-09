using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class MessageManager : IMessageService
	{
        private readonly IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Delete(Message entity) => _messageDal.Delete(entity);

        public Message GetById(int id) => _messageDal.GetById(id);

        public List<Message> GetList() => _messageDal.GetList();

        public void Insert(Message entity) => _messageDal.Insert(entity);

        public void Update(Message entity) => _messageDal.Update(entity);
    }
}

