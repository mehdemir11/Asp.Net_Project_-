using Business_Layer.Abstract;
using Data_Access_Layer.Abstract;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Concrete
{
    public class SkillManager : ISkillService
    {
        ISkillDAL _skillDAL;

        public SkillManager(ISkillDAL skillDAL)
        {
            _skillDAL = skillDAL;
        }

        public void TAdd(Skill t)
        {
            _skillDAL.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _skillDAL.Delete(t);
        }

        public Skill TGetByID(int id)
        {
            return _skillDAL.GetByID(id);
        }

        public List<Skill> TGetList()
        {
            return _skillDAL.GetList();
        }

        public List<Skill> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Skill t)
        {
            _skillDAL.Update(t);
        }
    }
}
