using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AdminValidator : AbstractValidator<Admin>
    {
        public AdminValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Admin kullanıcı maili boş geçilemez.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Admin şifresi boş geçilemez.");
            RuleFor(x => x.Username).MaximumLength(20).WithMessage("Admin kullanıcı maili en fazla 20 karakter girilebilir.");
            RuleFor(x => x.Password).MaximumLength(20).WithMessage("Admin şifresi en fazla 20 karakter girilebilir.");
        }
    }
}
