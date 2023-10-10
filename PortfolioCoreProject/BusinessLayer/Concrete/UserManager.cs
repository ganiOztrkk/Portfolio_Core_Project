using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
		private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Delete(User entity) => _userDal.Delete(entity);

        public User GetById(int id) => _userDal.GetById(id);
        public List<User> GetList() => _userDal.GetList();
        public void Insert(User entity) => _userDal.Insert(entity);

        public void Update(User entity) => _userDal.Update(entity);
    }
}

