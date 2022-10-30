using Entity_Layer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.portfolioTitle).NotEmpty().WithMessage("Proje Adı Boş Geçilemez!");
            RuleFor(x=>x.portfolioImageUrl).NotEmpty().WithMessage("Proje Görseli Boş Geçilemez!");
            RuleFor(x=>x.portfolioImageUrl2).NotEmpty().WithMessage("Proje Görseli Boş Geçilemez!");
            RuleFor(x=>x.portfolioPrice).NotEmpty().WithMessage("Proje Bedeli Boş Geçilemez!");
            RuleFor(x=>x.portfolioValue).NotEmpty().WithMessage("Proje İlerlemesi Boş Geçilemez!");
            RuleFor(x => x.portfolioTitle).MinimumLength(5).WithMessage("Proje Adı En Az 5 Karakterden Oluşmak Zorunda!");
            RuleFor(x => x.portfolioTitle).MaximumLength(100).WithMessage("Proje Adı 100 Karakterden Fazla Olamaz!");
        }
    }
}
