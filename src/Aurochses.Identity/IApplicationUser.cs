using System;

namespace Aurochses.Identity
{
    /// <summary>
    /// User
    /// </summary>
    public interface IApplicationUser
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Guid Id { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        /// <value>The user name.</value>
        string UserName { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        /// <value>The email.</value>
        string Email { get; set; }

        /// <summary>
        /// Phone Number
        /// </summary>
        /// <value>The phone number.</value>
        string PhoneNumber { get; set; }

        /// <summary>
        /// First Name
        /// </summary>
        /// <value>The first name.</value>
        string FirstName { get; set; }

        /// <summary>
        /// Last Name
        /// </summary>
        /// <value>The last name.</value>
        string LastName { get; set; }

        /// <summary>
        /// Registration date
        /// </summary>
        /// <value>The date of user registration.</value>
        DateTime CreatedDate { get; set; }
    }
}