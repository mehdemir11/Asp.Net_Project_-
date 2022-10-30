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
    public class SquadManager : ISquadService
    {
        ISquadDAL _squadDal;

        public SquadManager(ISquadDAL squadDal)
        {
            _squadDal = squadDal;
        }

        public void TAdd(Squad t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Squad t)
        {
            throw new NotImplementedException();
        }

        public Squad TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Squad> TGetList()
        {
            return _squadDal.GetList();
        }

        public List<Squad> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Squad t)
        {
            throw new NotImplementedException();
        }
    }
}
