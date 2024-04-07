/// <summary>
/// Filename: Program.cs
/// Created on: 2024-04-04 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 
using System.Text.RegularExpressions;

namespace Assignment5.Helpers
{
    public class EmailChecker
    {
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
    }
}