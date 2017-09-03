using System.Threading.Tasks;

namespace Aurochses.Identity
{
    /// <summary>
    /// Interface of email service
    /// </summary>
    public interface IEmailService
    {
        /// <summary>
        /// Send Email Confirmation Token
        /// </summary>
        /// <param name="user">The User.</param>
        /// <param name="callbackUrl">The callback url.</param>
        /// <returns>SendResult</returns>
        Task<SendResult> SendEmailConfirmationTokenAsync(IApplicationUser user, string callbackUrl);

        /// <summary>
        /// Send Password Reset Token
        /// </summary>
        /// <param name="user">The User.</param>
        /// <param name="callbackUrl">The callback url.</param>
        /// <returns>SendResult</returns>
        Task<SendResult> SendPasswordResetTokenAsync(IApplicationUser user, string callbackUrl);

        /// <summary>
        /// Send Two Factor Token
        /// </summary>
        /// <param name="user">The User.</param>
        /// <param name="token">The token.</param>
        /// <returns>SendResult</returns>
        Task<SendResult> SendTwoFactorTokenAsync(IApplicationUser user, string token);
    }
}