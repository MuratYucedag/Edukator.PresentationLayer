using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrete
{
    public class CourseRegister
    {
        public int CourseRegisterID { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }

    }
}