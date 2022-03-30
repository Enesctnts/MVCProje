using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetList();
        void AboutAddBl(About about);
        void AboutDelete(About about);
        About GetById(int id);
        void AboutUpdate(About about);
    }
}
