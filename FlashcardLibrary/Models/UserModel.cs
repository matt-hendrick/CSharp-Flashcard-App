using System;
using System.Collections.Generic;
using System.Text;

namespace FlashcardLibrary.Models
{
    /// <summary>
    /// Represents a user
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// Unique ID for the user
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// User's username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// User's email
        /// </summary>
        public string Email { get; set; }

        // TODO - Add password hashing
        /// <summary>
        /// User's password (for testing purposes this is initially just plain text)
        /// </summary>
        public string Password { get; set; }
    }
}
