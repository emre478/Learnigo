using FluentValidation;
using Learnigo.WebUI.Dtos.BlogCategoryDtos;

namespace Learnigo.WebUI.Validators
{
    public class BlogCategoryValidator: AbstractValidator<CreateBlogCategoryDto>
    {
        public BlogCategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Blog Kategori adı boş bırakılamaz");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Blog Kategori adı en fazla 30 karakter olmalıdır");
            
        }
    }
    
}
