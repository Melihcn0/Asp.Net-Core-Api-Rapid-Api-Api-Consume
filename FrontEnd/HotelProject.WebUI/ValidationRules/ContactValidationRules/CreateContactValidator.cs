using FluentValidation;
using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.ContactValidationRules
{
    public class CreateContactValidator : AbstractValidator<CreateContactDto>
    {
        public CreateContactValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Soyad alanı boş geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu başlığı alanı boş geçilemez");
            RuleFor(x => x.MessageCategoryID).NotEmpty().WithMessage("Konu alanı boş geçilemez");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj alanı boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapınız");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapınız");
            RuleFor(x => x.Message).MaximumLength(200).WithMessage("Lütfen en fazla 200 karakter veri girişi yapınız");
        }
    }
}
