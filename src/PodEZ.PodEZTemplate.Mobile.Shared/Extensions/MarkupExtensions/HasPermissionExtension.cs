using System;
using PodEZ.PodEZTemplate.Core;
using PodEZ.PodEZTemplate.Core.Dependency;
using PodEZ.PodEZTemplate.Services.Permission;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PodEZ.PodEZTemplate.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class HasPermissionExtension : IMarkupExtension
    {
        public string Text { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return false;
            }

            var permissionService = DependencyResolver.Resolve<IPermissionService>();
            return permissionService.HasPermission(Text);
        }
    }
}