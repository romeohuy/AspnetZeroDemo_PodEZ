using System.ComponentModel;
using Abp.AutoMapper;
using PodEZ.PodEZTemplate.MultiTenancy.Dto;

namespace PodEZ.PodEZTemplate.Models.Tenants
{
    [AutoMapFrom(typeof(TenantEditDto))]
    public class TenantEditModel : TenantEditDto, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}