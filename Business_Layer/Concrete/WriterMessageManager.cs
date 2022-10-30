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
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDAL _writerMessageDAL;

        public WriterMessageManager(IWriterMessageDAL writerMessageDAL)
        {
            _writerMessageDAL = writerMessageDAL;
        }

        public List<WriterMessage> GetListRecieversMessage(string p)
        {
            return _writerMessageDAL.GetbyFilter(x => x.Receiver == p);
        }

        public List<WriterMessage> GetListSendersMessage(string p)
        {
            return _writerMessageDAL.GetbyFilter(x => x.Sender == p);
        }

        public void TAdd(WriterMessage t)
        {
            _writerMessageDAL.Insert(t);
        }

        public void TDelete(WriterMessage t)
        {
            _writerMessageDAL.Delete(t);
        }

        public WriterMessage TGetByID(int id)
        {
            return _writerMessageDAL.GetByID(id);
        }

        public List<WriterMessage> TGetList()
        {
            throw new NotImplementedException();
        }

        public List<WriterMessage> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
