using System.Threading.Tasks;

namespace Aurochses.AspNetCore.Identity
{
    /// <summary>
    /// Interface of sms service
    /// </summary>
    public interface ISmsService
    {
        /// <summary>
        /// Send Two Factor Token
        /// </summary>
        /// <param name="user">The User.</param>
        /// <param name="token">The token.</param>
        /// <returns>SendResult</returns>
        Task<SendResult> SendTwoFactorTokenAsync(IApplicationUser user, string token);
    }
}