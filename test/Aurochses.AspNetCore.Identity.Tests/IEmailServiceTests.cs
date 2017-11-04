using System.Threading.Tasks;
using Aurochses.AspNetCore.Identity.Tests.Fakes;
using Moq;
using Xunit;

namespace Aurochses.AspNetCore.Identity.Tests
{
    // ReSharper disable once InconsistentNaming
    public class IEmailServiceTests
    {
        private readonly Mock<IEmailService> _mockEmailService;

        public IEmailServiceTests()
        {
            _mockEmailService = new Mock<IEmailService>(MockBehavior.Strict);
        }

        [Fact]
        public async Task SendEmailConfirmationTokenAsync_Success()
        {
            // Arrange
            var user = new FakeApplicationUser();
            const string callbackUrl = "callbackUrl";
            var sendResult = SendResult.Success;

            _mockEmailService.Setup(m => m.SendEmailConfirmationTokenAsync(user, callbackUrl)).ReturnsAsync(sendResult);

            // Act & Assert
            Assert.Equal(sendResult, await _mockEmailService.Object.SendEmailConfirmationTokenAsync(user, callbackUrl));
        }

        [Fact]
        public async Task SendPasswordResetTokenAsync_Success()
        {
            // Arrange
            var user = new FakeApplicationUser();
            const string callbackUrl = "callbackUrl";
            var sendResult = SendResult.Success;

            _mockEmailService.Setup(m => m.SendPasswordResetTokenAsync(user, callbackUrl)).ReturnsAsync(sendResult);

            // Act & Assert
            Assert.Equal(sendResult, await _mockEmailService.Object.SendPasswordResetTokenAsync(user, callbackUrl));
        }

        [Fact]
        public async Task SendTwoFactorTokenAsync_Success()
        {
            // Arrange
            var user = new FakeApplicationUser();
            const string token = "token";
            var sendResult = SendResult.Success;

            _mockEmailService.Setup(m => m.SendTwoFactorTokenAsync(user, token)).ReturnsAsync(sendResult);

            // Act & Assert
            Assert.Equal(sendResult, await _mockEmailService.Object.SendTwoFactorTokenAsync(user, token));
        }
    }
}