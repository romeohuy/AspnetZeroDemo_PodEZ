namespace PodEZ.PodEZTemplate.Net.Emailing
{
    public interface IEmailTemplateProvider
    {
        string GetDefaultTemplate(int? tenantId);
    }
}
