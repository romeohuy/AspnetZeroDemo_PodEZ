using System.ComponentModel;
using Abp.AutoMapper;
using PodEZ.PodEZTemplate.Authorization.Users.Dto;

namespace PodEZ.PodEZTemplate.Models.Users
{
    [AutoMapFrom(typeof(CreateOrUpdateUserInput))]
    public class UserCreateOrUpdateModel : CreateOrUpdateUserInput, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}