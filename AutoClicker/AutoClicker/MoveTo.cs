using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace AutoClicker
{
    class MoveTo
    {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        public static void SetCursorPosition(int x, int y)
        {
            SetCursorPos(x, y);
        }
    }
}
