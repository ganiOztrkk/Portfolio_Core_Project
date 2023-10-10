using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class UserMessageManager : IUserMessageService
	{
		private readonly IUserMessageDal _userMessageDal;

        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _userMessageDal = userMessageDal;
        }

        public void Delete(UserMessage entity) => _userMessageDal.Delete(entity);

        public UserMessage GetById(int id) => _userMessageDal.GetById(id);
        public List<UserMessage> GetList() => _userMessageDal.GetList();
        public void Insert(UserMessage entity) => _userMessageDal.Insert(entity);

        public void Update(UserMessage entity) => _userMessageDal.Update(entity);
    }
}

