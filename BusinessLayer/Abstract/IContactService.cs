using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> GetList();
        void ContactAddBl(Contact contact);
        void ContactDelete(Contact contact);
        Contact GetById(int id);
        void ContactUpdate(Contact contact);
    }
}
