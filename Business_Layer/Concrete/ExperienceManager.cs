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
    public class ExperienceManager:IExperienceService
    {
        IExperienceDAL _experienceDal;

        public ExperienceManager(IExperienceDAL experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void TAdd(Experience t)
        {
            _experienceDal.Insert(t);
        }

        public void TDelete(Experience t)
        {
            _experienceDal.Delete(t);
        }

        public Experience TGetByID(int id)
        {
            return _experienceDal.GetByID(id);
        }

        public List<Experience> TGetList()
        {
            return _experienceDal.GetList();
        }

        public List<Experience> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Experience t)
        {
            _experienceDal.Update(t);
        }
    }
}
