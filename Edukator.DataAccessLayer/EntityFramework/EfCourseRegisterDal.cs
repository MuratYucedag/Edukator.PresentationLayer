using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Concrete;
using Edukator.DataAccessLayer.Repositories;
using Edukator.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfCourseRegisterDal : GenericRepository<CourseRegister>, ICourseRegisterDal
    {
        public List<CourseRegister> CourseRegisterListWithCoursesAndUsers()
        {
            using var context = new Context();
            var values = context.CourseRegisters.Include(x => x.Course).Include(y => y.AppUser).ToList();
            return values;
        }
    }
}
