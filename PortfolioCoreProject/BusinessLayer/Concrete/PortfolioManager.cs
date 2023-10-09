using System;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public class PortfolioManager : IPortfolioService
    {
        private readonly IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public void Delete(Portfolio entity) => _portfolioDal.Delete(entity);

        public Portfolio GetById(int id) => _portfolioDal.GetById(id);

        public List<Portfolio> GetList() => _portfolioDal.GetList();

        public void Insert(Portfolio entity) => _portfolioDal.Insert(entity);

        public void Update(Portfolio entity) => _portfolioDal.Update(entity);
    }
}

