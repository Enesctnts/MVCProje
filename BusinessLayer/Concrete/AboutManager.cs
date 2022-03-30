using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager: IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void AboutAddBl(About heading)
        {

            _aboutDal.Insert(heading);

        }

        public void AboutDelete(About heading)
        {
            _aboutDal.Delete(heading);
        }

        public void AboutUpdate(About heading)
        {
            _aboutDal.Update(heading);
        }

        public About GetById(int id)
        {
            return _aboutDal.Get(p => p.AboutId == id);
        }

        public List<About> GetList()
        {
            return _aboutDal.List();
        }
    }
}
