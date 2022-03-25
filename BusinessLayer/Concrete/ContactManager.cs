using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager
    {
        GenericRepository<Contact> repo = new GenericRepository<Contact>();

        public List<Contact> GetAll()
        {
            return repo.List();
        }

        public void ContactAddBl(Contact contact)
        {
            if (contact.UserName == "" || contact.UserMail=="")
            {

            }
            else
            {
                repo.Insert(contact);
            }
        }

    }
}
