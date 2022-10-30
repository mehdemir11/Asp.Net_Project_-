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
    public class FeatureManager : IGenericService<Feature>
    {
        IFeatureDAL _featureDAL;

        public FeatureManager(IFeatureDAL featureDAL)
        {
            _featureDAL = featureDAL;
        }

        public void TAdd(Feature t)
        {
            _featureDAL.Insert(t);
        }

        public void TDelete(Feature t)
        {
            _featureDAL.Delete(t);
        }

        public Feature TGetByID(int id)
        {
            return _featureDAL.GetByID(id);
        }

        public List<Feature> TGetList()
        {
            return _featureDAL.GetList();
        }

        public List<Feature> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Feature t)
        {
            _featureDAL.Update(t);
        }
    }
}
