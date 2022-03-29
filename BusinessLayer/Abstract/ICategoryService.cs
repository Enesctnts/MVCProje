using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();
        void CategoryAddBl(Category category);
        void CategoryDelete(Category category);
        Category GetById(int id);
        void CategoryUpdate(Category category);
        


    }
}
