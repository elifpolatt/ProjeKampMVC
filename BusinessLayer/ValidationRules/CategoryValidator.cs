using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            //Abstract validator içine gonderdıgım t degerı için (category) kural olusturdum.
            RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın. ");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla giriş yapmayın.");


            //not: Eğer client taraflı doğrulama yapılsaydı kullanıcı doğrulamayı bikaç oynamayla rahatlıkla geçebilirdi. fakat backend tarafına entegre edilmiş doğrulamayı geçemez. yani özet olarak projelerimizde client taraflı doğrulamayı kullanıcıya bilgi vermek server taraflı doğrulamayı ise gerçekten datayı doğrulama yapmak için entegre ederiz.
        }
    }
}
