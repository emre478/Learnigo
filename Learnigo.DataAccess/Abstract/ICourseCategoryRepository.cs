﻿using Learnigo.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnigo.DataAccess.Abstract
{
    public interface ICourseCategoryRepository: IRepository<CourseCategory>
    {
        void ShowOnHome(int  id);
        void DontShowOnHome(int  id);

    }
}
