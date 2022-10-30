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
    public class WriterUserManager:IWriterUserService
    {
        IWriterUserDAL _writerUserDAL;

        public WriterUserManager(IWriterUserDAL writerUserDAL)
        {
            _writerUserDAL = writerUserDAL;
        }

        public void TAdd(WriterUser t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(WriterUser t)
        {
            throw new NotImplementedException();
        }

        public WriterUser TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<WriterUser> TGetList()
        {
            return _writerUserDAL.GetList();
        }

        public List<WriterUser> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterUser t)
        {
            throw new NotImplementedException();
        }
    }
}
