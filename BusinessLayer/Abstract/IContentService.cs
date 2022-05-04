using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList(string p);
        List<Content> GetListByWriter(int id);
        List<Content> GetListHeadingId(int id);//Başlığa göre liste getirecek.
        void ContentAddBl(Content content);
        void ContentDelete(Content content);
        Content GetById(int id);
        void ContentUpdate(Content content);
    }
}
