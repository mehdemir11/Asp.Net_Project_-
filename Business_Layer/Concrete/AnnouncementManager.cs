﻿using Business_Layer.Abstract;
using Data_Access_Layer.Abstract;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDAL _announcementDal;

        public AnnouncementManager(IAnnouncementDAL announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void TAdd(Announcement t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Announcement t)
        {
            throw new NotImplementedException();
        }

        public Announcement TGetByID(int id)
        {
            return _announcementDal.GetByID(id);
        }

        public List<Announcement> TGetList()
        {
            return _announcementDal.GetList();
        }

        public List<Announcement> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Announcement t)
        {
            throw new NotImplementedException();
        }
    }
}
