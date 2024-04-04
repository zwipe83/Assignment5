/// <summary>
/// Filename: Debugger.cs
/// Created on: 2024-04-04 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Helpers
{
    internal class Debugger
    {
        public static void DEBUG_PRINT(string message)
        { 
            DateTime now = DateTime.Now;
            System.Diagnostics.Debug.Print($"{now:yyyy-MM-dd HH:mm:ss.fff} {message}");
        }
    }
}
