using System.Threading.Tasks;
using PodEZ.PodEZTemplate.Security.Recaptcha;

namespace PodEZ.PodEZTemplate.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
