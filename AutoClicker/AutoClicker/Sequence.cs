using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    class Sequence
    {
        Click c = new Click();
        KeyPress k = new KeyPress();

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        public void Reader(string item)
        {
            Point p = new Point();
            string[] itemList = item.Split(':');

            if (item.Contains("lclick"))
            {
                p.X = Int32.Parse(itemList[1]);
                p.Y = Int32.Parse(itemList[2]);

                c.LeftClick(p);
            }
            else if (item.Contains("rclick"))
            {

                p.X = Int32.Parse(itemList[1]);
                p.Y = Int32.Parse(itemList[2]);

                c.RightClick(p);

            }
            else if (item.Contains("copy"))
            {
                SendKeys.Send("^c");
            }
            else if (item.Contains("moveto"))
            {
                MoveTo.SetCursorPosition(Int32.Parse(itemList[1]), Int32.Parse(itemList[2]));
            }
            else if (item.Contains("timewait"))
            {
                wait(Int32.Parse(itemList[1]));
            }
            else if (item.Contains("sclick"))
            {
                k.ShiftDown();
                wait(500);
                p.X = Int32.Parse(itemList[1]);
                p.Y = Int32.Parse(itemList[2]);
                c.LeftClick(p);
                wait(500);
                k.ShiftUp();
            }
            else if (item.Contains("imgwait"))
            {
                int j = 0;
                string ScreenPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Screenshot.png";
                Bitmap bitmain = new Bitmap(ScreenPath);
                Bitmap bitsub = new Bitmap(Char.ToString(item[1]));

                while (!ImageScanner.GetSubPositions(bitmain, bitsub).Any() || j < 20)
                {
                    wait(1000);
                    j += 1;
                    ImageScanner.ScreenCapture();
                }
            }
        }
    }
}
