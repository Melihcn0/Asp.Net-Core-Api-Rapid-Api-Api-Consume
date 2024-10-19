using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;
using HotelProject.WebUI.Models.Setting;

namespace HotelProject.WebUI.ValidationRules.SettingsValidationRules
{
    public class UserEditSettingsValidator : AbstractValidator<UserEditViewModel>
    {
        public UserEditSettingsValidator()
        {
            RuleFor(x => x.Name)
                        .NotEmpty().WithMessage("İsim alanı boş geçilemez")
                        .MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri girişi yapınız");

            RuleFor(x => x.Surname)
                        .NotEmpty().WithMessage("Soyisim alanı boş geçilemez")
                        .MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapınız");

            RuleFor(x => x.Email)
                        .NotEmpty().WithMessage("Email alanı boş geçilemez")
                        .EmailAddress().WithMessage("Geçerli bir email adresi giriniz");

            RuleFor(x => x.Password)
                        .NotEmpty().WithMessage("Şifre alanı boş geçilemez")
                        .MinimumLength(6).WithMessage("Lütfen en az 6 karakter veri girişi yapınız")
                        .Matches("[a-zA-Z]").WithMessage("Şifre en az bir harf içermelidir")
                        .Matches("[0-9]").WithMessage("Şifre en az bir rakam içermelidir")
                        .Matches("[^a-zA-Z0-9]").WithMessage("Şifre en az bir sembol içermelidir");

            RuleFor(x => x.ConfirmPassword)
                     .NotEmpty().WithMessage("Şifre onay alanı boş geçilemez")
                     .Equal(x => x.Password).WithMessage("Şifreler eşleşmiyor");

        }
    }
}
