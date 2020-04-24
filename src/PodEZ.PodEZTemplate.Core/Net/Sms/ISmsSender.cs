using System.Threading.Tasks;

namespace PodEZ.PodEZTemplate.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}