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
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail kısmını boş geçemezsiniz.");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad kısmını boş geçemezsiniz.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad kısmını boş geçemezsiniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş geçemezsiniz.");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj içeriğini boş geçemezsiniz.");
        }
    }
}
