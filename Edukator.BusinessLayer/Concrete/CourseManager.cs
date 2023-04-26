using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Concrete
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public void TDelete(Course t)
        {
            _courseDal.Delete(t);
        }
        public Course TGetByID(int id)
        {
           return _courseDal.GetByID(id);
        }
        public List<Course> TGetCoursesWithCategory()
        {
            return _courseDal.GetCoursesWithCategory();
        }

        public List<Course> TGetList()
        {
            return _courseDal.GetList();
        }
        public void TInsert(Course t)
        {
            _courseDal.Insert(t);
        }
        public void TUpdate(Course t)
        {
            _courseDal.Update(t);
        }
    }
}
