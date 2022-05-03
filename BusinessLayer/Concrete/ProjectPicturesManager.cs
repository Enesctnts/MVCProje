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
    public class ProjectPicturesManager : IProjectPicturesService
    {
        IProjectPicturesDal _projectPicturesDal;

        public ProjectPicturesManager(IProjectPicturesDal projectPicturesDal)
        {
            _projectPicturesDal = projectPicturesDal;
        }

        public List<ProjectPictures> GetList()
        {
            return _projectPicturesDal.List();
        }
    }
}
