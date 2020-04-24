using System.Threading.Tasks;

namespace PodEZ.PodEZTemplate.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}