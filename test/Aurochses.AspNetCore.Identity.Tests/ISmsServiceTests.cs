using System.Threading.Tasks;
using Aurochses.AspNetCore.Identity.Tests.Fakes;
using Moq;
using Xunit;

namespace Aurochses.AspNetCore.Identity.Tests
{
    // ReSharper disable once InconsistentNaming
    public class ISmsServiceTests
    {
        private readonly Mock<ISmsService> _mockSmsService;

        public ISmsServiceTests()
        {
            _mockSmsService = new Mock<ISmsService>(MockBehavior.Strict);
        }

        [Fact]
        public async Task SendTwoFactorTokenAsync_Success()
        {
            // Arrange
            var user = new FakeApplicationUser();
            const string token = "token";
            var sendResult = SendResult.Success;

            _mockSmsService.Setup(m => m.SendTwoFactorTokenAsync(user, token)).ReturnsAsync(sendResult);

            // Act & Assert
            Assert.Equal(sendResult, await _mockSmsService.Object.SendTwoFactorTokenAsync(user, token));
        }
    }
}