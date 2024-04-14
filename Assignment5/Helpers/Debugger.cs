/// <summary>
/// Filename: Debugger.cs
/// Created on: 2024-04-04 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment5.Helpers
{
    internal class Debugger
    {
        #region Public Static Methods
        /// <summary>
        /// Debug printer which will print a specific message to VS debugger
        /// </summary>
        /// <param name="message"></param>
        public static void DEBUG_PRINT(string message)
        {
#if DEBUG
            DateTime now = DateTime.Now;
            System.Diagnostics.Debug.Print($"{now:yyyy-MM-dd HH:mm:ss.fff} {message}");
#endif
        }
        #endregion
    }
}
