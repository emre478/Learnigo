using Learnigo.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnigo.Business.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> TGetBlogsWithCategories();
    }
}
