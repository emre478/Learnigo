using Learnigo.DataAccess.Abstract;
using Learnigo.DataAccess.Context;
using Learnigo.DataAccess.Repositories;
using Learnigo.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnigo.DataAccess.Concrete
{
    public class BlogRepository : GenericRepository<Blog>, IBlogRepository
    {
        private readonly LearnigoContext _lercontext;
        public BlogRepository(LearnigoContext _context) : base(_context)
        {
            _lercontext = _context;
        }

        public List<Blog> GetBlogsWithCategories()
        {
            return _lercontext.Blogs.Include(x => x.BlogCategory).ToList();
        }
    }
}
