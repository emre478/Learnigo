using Learnigo.DataAccess.Abstract;
using Learnigo.DataAccess.Context;
using Learnigo.DataAccess.Repositories;
using Learnigo.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnigo.DataAccess.Concrete
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(LearnigoContext context) : base(context)
        {
        }

        public void DontShowOnHome(int id)
        {
            var value = _context.Courses.Find(id);
            value.IsShown= false;
            _context.SaveChanges();
        }

        public void ShowOnHome(int id)
        {
            var value = _context.Courses.Find(id);
            value.IsShown = false;
            _context.SaveChanges();
        }
    }
}
