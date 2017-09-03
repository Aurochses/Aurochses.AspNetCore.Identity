using Aurochses.Identity.Tests.Fakes;
using Xunit;

namespace Aurochses.Identity.Tests
{
    public class SendResultTests
    {
        private readonly FakeSendResult _sendResult;

        public SendResultTests()
        {
            _sendResult = new FakeSendResult();
        }

        [Fact]
        public void Succeeded_Success()
        {
            // Arrange
            const bool value = true;

            _sendResult.SetSucceeded(value);

            // Act & Assert
            Assert.Equal(value, _sendResult.Succeeded);
        }

        [Fact]
        public void Response_Success()
        {
            // Arrange
            var response = new FakeApplicationUser();

            _sendResult.SetResponse(response);

            // Act & Assert
            Assert.Equal(response, _sendResult.Response);
        }

        [Fact]
        public void Success_Success()
        {
            // Arrange & Act
            var item = SendResult.Success;

            // Assert
            Assert.True(item.Succeeded);
            Assert.Null(item.Response);
        }

        [Fact]
        public void Failed_Success()
        {
            // Arrange & Act
            var response = new FakeApplicationUser();
            var item = SendResult.Failed(response);

            // Assert
            Assert.False(item.Succeeded);
            Assert.Equal(response, item.Response);
        }
    }
}