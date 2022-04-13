using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {

        public ContactValidator()
        {
            RuleFor(p => p.UserMail).NotEmpty().WithMessage("Mail adresini boş geçemezsiniz");
            RuleFor(p => p.Subject).NotEmpty().WithMessage("Konu adını boş geçemezsiniz");
            RuleFor(p => p.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız");
            RuleFor(p => p.Subject).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla değer girişi yapmayın");
            RuleFor(p => p.UserName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız");
            RuleFor(p => p.UserName).NotEmpty().WithMessage("Kullancı adını boş geçemezsiniz");


        }



    }
}
