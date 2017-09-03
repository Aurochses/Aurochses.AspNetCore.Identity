namespace Aurochses.Identity.Tests.Fakes
{
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