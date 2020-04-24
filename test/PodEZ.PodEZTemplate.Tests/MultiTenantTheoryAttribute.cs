using Xunit;

namespace PodEZ.PodEZTemplate.Tests
{
    public sealed class MultiTenantTheoryAttribute : TheoryAttribute
    {
        private readonly bool _multiTenancyEnabled = PodEZTemplateConsts.MultiTenancyEnabled;
      
        public MultiTenantTheoryAttribute()
        {
            if (!_multiTenancyEnabled)
            {
                Skip = "MultiTenancy is disabled.";
            }
        }
    }
}