using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(p => p.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz");
            RuleFor(p => p.CategoryName).MinimumLength(2).WithMessage("Kategori adı en az 2 karekter olmalıdır");
            RuleFor(p => p.CategoryName).MaximumLength(20).WithMessage("Kategori adı en fazla 20 karekter olmalıdır");
            RuleFor(p => p.CategoryDescription).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz"); 
            
        }


    }
}
