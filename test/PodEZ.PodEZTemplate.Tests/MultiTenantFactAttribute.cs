using Xunit;

namespace PodEZ.PodEZTemplate.Tests
{
    public sealed class MultiTenantFactAttribute : FactAttribute
    {
        private readonly bool _multiTenancyEnabled = PodEZTemplateConsts.MultiTenancyEnabled;

        public MultiTenantFactAttribute()
        {
            if (!_multiTenancyEnabled)
            {
                Skip = "MultiTenancy is disabled.";
            }
        }
    }
}
