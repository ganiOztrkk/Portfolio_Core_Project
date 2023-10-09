﻿using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class SkillManager : ISkillService
    {
        private readonly ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void Delete(Skill entity) => _skillDal.Delete(entity);

        public Skill GetById(int id) => _skillDal.GetById(id);

        public List<Skill> GetList() => _skillDal.GetList();

        public void Insert(Skill entity) => _skillDal.Insert(entity);

        public void Update(Skill entity) => _skillDal.Update(entity);
    }
}

