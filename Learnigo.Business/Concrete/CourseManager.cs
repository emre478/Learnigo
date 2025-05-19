﻿using Learnigo.Business.Abstract;
using Learnigo.DataAccess.Abstract;
using Learnigo.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnigo.Business.Concrete
{
    public class CourseManager : GenericManager<Course>, ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        public CourseManager(IRepository<Course> _repository, ICourseRepository courseRepository) : base(_repository)
        {
            _courseRepository = courseRepository;
        }

        public void TDontShowOnHome(int id)
        {
           _courseRepository.DontShowOnHome(id);
        }

        public void TShowOnHome(int id)
        {
            _courseRepository.ShowOnHome(id);
        }
    }
}
