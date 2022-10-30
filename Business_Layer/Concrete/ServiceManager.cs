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
    public class ServiceManager : IServiceService
    {
        IServiceDAL _serviceDal;

        public ServiceManager(IServiceDAL serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TAdd(Service t)
        {
            _serviceDal.Insert(t);
        }

        public object TGetList()
        {
            return _serviceDal.GetList();
        }

        public void TDelete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public void TUpdate(Service t)
        {
            _serviceDal.Update(t);
        }

        Service IGenericService<Service>.TGetByID(int id)
        {
            return _serviceDal.GetByID(id);
        }

        List<Service> IGenericService<Service>.TGetList()
        {
            return _serviceDal.GetList();
        }

        public object TGetByID(int id)
        {
            return _serviceDal.GetByID(id);
        }

        public void TDelete(object values)
        {
            throw new NotImplementedException();
        }

        public List<Service> TGetListByFilter()
        {
            throw new NotImplementedException();
        }
    }
}
