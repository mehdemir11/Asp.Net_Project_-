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
    public class MessageManager : IMessageService
    {
        IMessageDAL _messageDAL;

        public MessageManager(IMessageDAL messageDAL)
        {
            _messageDAL = messageDAL;
        }

        public void TAdd(Message t)
        {
            _messageDAL.Insert(t);
            
        }

        public void TDelete(Message t)
        {
            _messageDAL.Delete(t);
        }

        public Message TGetByID(int id)
        {
            return _messageDAL.GetByID(id);
        }

        public List<Message> TGetList()
        {
            return _messageDAL.GetList();
        }

        public void TUpdate(Message t)
        {
            throw new NotImplementedException();
        }

        public static void Tadd(Message p)
        {
            throw new NotImplementedException();
        }

        public List<Message> TGetListByFilter()
        {
            throw new NotImplementedException();
        }
    }
}
