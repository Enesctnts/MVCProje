using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(w => w.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz");
            RuleFor(w => w.WriterSurname).NotEmpty().WithMessage("Yazar Soyadını Boş Geçemezsiniz");
            RuleFor(w => w.WriterAbout).NotEmpty().WithMessage("Hakkımda Kısmı Boş Geçilemez");
            RuleFor(w => w.WriterTitle).NotEmpty().WithMessage("Hakkımda Kısmı Boş Geçilemez");
             RuleFor(w => w.WriterAbout).MaximumLength(200).WithMessage("En fazla 200 karakter girişi yapılabilir");
            RuleFor(w => w.WriterSurname).MinimumLength(2).WithMessage("En az 2 karakter girişi yapılabilir");
            RuleFor(w => w.WriterSurname).MaximumLength(50).WithMessage("En fazla 50 karakter girişi yapılabilir");

        }
    }
}