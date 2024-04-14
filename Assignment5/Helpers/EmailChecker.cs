/// <summary>
/// Filename: EmailChecker.cs
/// Created on: 2024-04-04 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using System.Text.RegularExpressions;

namespace Assignment5.Helpers
{
    public class EmailChecker
    {
        #region Public Static methods
        /// <summary>
        /// Will check email has a valid format string@string.string. String.empty will also be valid.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsValidAddress(string email)
        {
            if (email is not null)
            {
                // Regular expression pattern for email validation
                string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

                Regex regex = new Regex(pattern);

                Match match = regex.Match(email);

                return match.Success || email == string.Empty;
            }
            return false;
        }
        #endregion
    }
}