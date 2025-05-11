using Learnigo.Business.Abstract;
using Learnigo.DataAccess.Abstract;
using Learnigo.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnigo.Business.Concrete
{
    public class BlogManager : GenericManager<Blog>, IBlogService
    {
        private readonly IBlogRepository _blogRepository;
        public BlogManager(IRepository<Blog> _repository, IBlogRepository blogRepository) : base(_repository)
        {
            _blogRepository = blogRepository;
        }

        public Blog TGetBlogWithCategory(int id)
        {

            return _blogRepository.GetBlogWithCategory(id);

        }

        public List<Blog> TGetBlogsWithCategories()
        {
            return _blogRepository.GetBlogsWithCategories();
        }


    }
}
