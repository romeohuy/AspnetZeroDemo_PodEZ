using System.Globalization;

namespace PodEZ.PodEZTemplate.Localization
{
    public interface IApplicationCulturesProvider
    {
        CultureInfo[] GetAllCultures();
    }
}