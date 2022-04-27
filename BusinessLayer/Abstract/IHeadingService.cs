using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetList();
        List<Heading> GetListByWriter(int id);
        void HeadingAddBl(Heading heading);
        void HeadingDelete(Heading heading);
        Heading GetById(int id);
        void HeadingUpdate(Heading heading);
    }
}
