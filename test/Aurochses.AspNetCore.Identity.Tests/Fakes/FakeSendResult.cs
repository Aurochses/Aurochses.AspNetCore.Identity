using System.Diagnostics.CodeAnalysis;

namespace Aurochses.AspNetCore.Identity.Tests.Fakes
{
    [ExcludeFromCodeCoverage]
    public class FakeSendResult : SendResult
    {
        public void SetSucceeded(bool value)
        {
            Succeeded = value;
        }

        public void SetResponse(object value)
        {
            Response = value;
        }
    }
}