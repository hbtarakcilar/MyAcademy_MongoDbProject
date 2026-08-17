using FluentValidation;
using Travel.Web.DTOs.BannerDtos;

namespace Travel.Web.Validations.BannerValidations
{
    public class CreateBannerValidator : AbstractValidator<CreateBannerDto>
    {
        public CreateBannerValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz.")
                                 .MinimumLength(3).WithMessage("Başlık en az 3 karakter olmalıdır.");

            RuleFor(x => x.Desc).NotEmpty().WithMessage("Açıklama boş bırakılamaz")
                                .MaximumLength(250).WithMessage("Açıklama en fazla 250 karakter olabilir.");

            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel URL boş bırakılamaz.");
        }
    }
}
