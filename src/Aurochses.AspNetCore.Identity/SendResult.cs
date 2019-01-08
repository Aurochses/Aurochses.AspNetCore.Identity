namespace Aurochses.AspNetCore.Identity
{
    /// <summary>
    /// Class SendResult.
    /// </summary>
    public class SendResult
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="SendResult"/> is succeeded.
        /// </summary>
        /// <value>
        ///   <c>true</c> if succeeded; otherwise, <c>false</c>.
        /// </value>
        public bool Succeeded { get; protected set; }

        /// <summary>
        /// Gets or sets the response.
        /// </summary>
        /// <value>
        /// The response.
        /// </value>
        public object Response { get; protected set; }

        /// <summary>
        /// Gets the success.
        /// </summary>
        /// <value>
        /// The success.
        /// </value>
        public static SendResult Success { get; } = new SendResult { Succeeded = true };

        /// <summary>
        /// Failed the specified response.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <returns></returns>
        public static SendResult Failed(object response)
        {
            return new SendResult
            {
                Succeeded = false,
                Response = response
            };
        }
    }
}