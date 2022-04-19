using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageService
    {
        List<Message> GetListInbox();
        List<Message> GetListSendbox();
        void MessageAddBl(Message message);
        void MessageDelete(Message message);
        Category GetById(int id);
        void MessageUpdate(Message message);


    }
}
