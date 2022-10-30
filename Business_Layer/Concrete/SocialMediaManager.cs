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
    public class SocialMediaManager:ISocialMediaService 
    {
        ISocialMediaDAL _socialMediaDAL;

        public SocialMediaManager(ISocialMediaDAL socialMediaDAL)
        {
            _socialMediaDAL = socialMediaDAL;
        }

        public void TAdd(SocialMedia t)
        {
            _socialMediaDAL.Insert(t);
        }

        public void TDelete(SocialMedia t)
        {
            _socialMediaDAL.Delete(t);
        }

        public SocialMedia TGetByID(int id)
        {
            return _socialMediaDAL.GetByID(id);
        }

        public List<SocialMedia> TGetList()
        {
            return _socialMediaDAL.GetList();
        }

        public List<SocialMedia> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SocialMedia t)
        {
            _socialMediaDAL.Update(t);
        }
    }
}
