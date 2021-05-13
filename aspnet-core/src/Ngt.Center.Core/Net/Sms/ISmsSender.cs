using System.Threading.Tasks;

namespace Ngt.Center.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}