using Abp.Configuration;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.Runtime.Security;

namespace PodEZ.PodEZTemplate.Net.Emailing
{
    public class PodEZTemplateSmtpEmailSenderConfiguration : SmtpEmailSenderConfiguration
    {
        public PodEZTemplateSmtpEmailSenderConfiguration(ISettingManager settingManager) : base(settingManager)
        {

        }

        public override string Password => SimpleStringCipher.Instance.Decrypt(GetNotEmptySettingValue(EmailSettingNames.Smtp.Password));
    }
}