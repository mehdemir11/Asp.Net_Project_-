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
    public class AboutManager : IAboutService
    {
        IAboutDAL aboutDAL;

        public AboutManager(IAboutDAL aboutDal)
        {
            this.aboutDAL = aboutDal;
        }

        public void TAdd(About t)
        {
            this.aboutDAL.Insert(t);
        }

        public void TDelete(About t)
        {
            this.aboutDAL.Delete(t);
        }

        public About TGetByID(int id)
        {
            return this.aboutDAL.GetByID(id);
        }

        public List<About> TGetList()
        {
            return this.aboutDAL.GetList();
        }

        public List<About> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About t)
        {
            this.aboutDAL.Update(t);
        }
    }
}
