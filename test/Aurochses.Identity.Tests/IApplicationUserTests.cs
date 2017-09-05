using System;
using Moq;
using Xunit;

namespace Aurochses.Identity.Tests
{
    // ReSharper disable once InconsistentNaming
    public class IApplicationUserTests
    {
        private readonly Mock<IApplicationUser> _mockApplicationUser;

        public IApplicationUserTests()
        {
            _mockApplicationUser = new Mock<IApplicationUser>(MockBehavior.Strict);
        }

        [Fact]
        public void Id_Get_Success()
        {
            // Arrange
            var value = Guid.NewGuid();

            _mockApplicationUser.SetupGet(m => m.Id).Returns(value);

            // Act & Assert
            Assert.Equal(value, _mockApplicationUser.Object.Id);
        }

        [Fact]
        public void Id_Set_Success()
        {
            // Arrange
            var result = Guid.Empty;

            var value = Guid.NewGuid();

            _mockApplicationUser.SetupSet(m => m.Id = It.IsAny<Guid>()).Callback((Guid val) => { result = val; });

            // Act
            _mockApplicationUser.Object.Id = value;

            // Assert
            Assert.Equal(value, result);
        }

        [Fact]
        public void UserName_Get_Success()
        {
            // Arrange
            const string value = "TestUserName";

            _mockApplicationUser.SetupGet(m => m.UserName).Returns(value);

            // Act & Assert
            Assert.Equal(value, _mockApplicationUser.Object.UserName);
        }

        [Fact]
        public void UserName_Set_Success()
        {
            // Arrange
            var result = "UserName";

            const string value = "TestUserName";

            _mockApplicationUser.SetupSet(m => m.UserName = It.IsAny<string>()).Callback((string val) => { result = val; });

            // Act
            _mockApplicationUser.Object.UserName = value;

            // Assert
            Assert.Equal(value, result);
        }

        [Fact]
        public void Email_Get_Success()
        {
            // Arrange
            const string value = "TestEmail";

            _mockApplicationUser.SetupGet(m => m.Email).Returns(value);

            // Act & Assert
            Assert.Equal(value, _mockApplicationUser.Object.Email);
        }

        [Fact]
        public void Email_Set_Success()
        {
            // Arrange
            var result = "Email";

            const string value = "TestEmail";

            _mockApplicationUser.SetupSet(m => m.Email = It.IsAny<string>()).Callback((string val) => { result = val; });

            // Act
            _mockApplicationUser.Object.Email = value;

            // Assert
            Assert.Equal(value, result);
        }

        [Fact]
        public void PhoneNumber_Get_Success()
        {
            // Arrange
            const string value = "TestPhoneNumber";

            _mockApplicationUser.SetupGet(m => m.PhoneNumber).Returns(value);

            // Act & Assert
            Assert.Equal(value, _mockApplicationUser.Object.PhoneNumber);
        }

        [Fact]
        public void PhoneNumber_Set_Success()
        {
            // Arrange
            var result = "PhoneNumber";

            const string value = "TestPhoneNumber";

            _mockApplicationUser.SetupSet(m => m.PhoneNumber = It.IsAny<string>()).Callback((string val) => { result = val; });

            // Act
            _mockApplicationUser.Object.PhoneNumber = value;

            // Assert
            Assert.Equal(value, result);
        }

        [Fact]
        public void FirstName_Get_Success()
        {
            // Arrange
            const string value = "TestFirstName";

            _mockApplicationUser.SetupGet(m => m.FirstName).Returns(value);

            // Act & Assert
            Assert.Equal(value, _mockApplicationUser.Object.FirstName);
        }

        [Fact]
        public void FirstName_Set_Success()
        {
            // Arrange
            var result = "FirstName";

            const string value = "TestFirstName";

            _mockApplicationUser.SetupSet(m => m.FirstName = It.IsAny<string>()).Callback((string val) => { result = val; });

            // Act
            _mockApplicationUser.Object.FirstName = value;

            // Assert
            Assert.Equal(value, result);
        }

        [Fact]
        public void LastName_Get_Success()
        {
            // Arrange
            const string value = "TestLastName";

            _mockApplicationUser.SetupGet(m => m.LastName).Returns(value);

            // Act & Assert
            Assert.Equal(value, _mockApplicationUser.Object.LastName);
        }

        [Fact]
        public void LastName_Set_Success()
        {
            // Arrange
            var result = "LastName";

            const string value = "TestLastName";

            _mockApplicationUser.SetupSet(m => m.LastName = It.IsAny<string>()).Callback((string val) => { result = val; });

            // Act
            _mockApplicationUser.Object.LastName = value;

            // Assert
            Assert.Equal(value, result);
        }

        [Fact]
        public void CreatedDate_Get_Success()
        {
            // Arrange
            var value = DateTime.Now;

            _mockApplicationUser.SetupGet(m => m.CreatedDate).Returns(value);

            // Act & Assert
            Assert.Equal(value, _mockApplicationUser.Object.CreatedDate);
        }

        [Fact]
        public void CreatedDate_Set_Success()
        {
            // Arrange
            var result = DateTime.MinValue;

            var value = DateTime.Now;

            _mockApplicationUser.SetupSet(m => m.CreatedDate = It.IsAny<DateTime>()).Callback((DateTime val) => { result = val; });

            // Act
            _mockApplicationUser.Object.CreatedDate = value;

            // Assert
            Assert.Equal(value, result);
        }
    }
}