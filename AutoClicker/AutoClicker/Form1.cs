using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;


// Version 1.0.0
//Change Log
// implement if, then statements


namespace AutoClicker
{
    public partial class ClickForm : Form
    {
        public ClickForm()
        {
            InitializeComponent();
            Directory.CreateDirectory("img");

        }

        private string seqPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Instructions.txt";
        private string ScreenPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Screenshot.png";
        List<string> seqList = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread TrackerThread = new Thread(Tracker);
            TrackerThread.IsBackground = true;
            TrackerThread.Start();
            string[] Sequence = File.ReadAllLines(seqPath);
            seqList.AddRange(Sequence);

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            
            ConsoleText.Text = "Welcome to the AutoClicker. \n \n" + 
                "Commands: lclick, rclick, moveto, copy, copyall, copy2csv, paste, sclick, imgwait, timewait \n \n" + 
                "Current Sequence: \n" + string.Join("  ", Sequence);
        }

        private void Tracker()
        {
            while (true)
            {
                int x = MousePosition.X;
                int y = MousePosition.Y;

                XCoord.Text = x.ToString();
                YCoord.Text = y.ToString();
            }
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Commands.Text = XCoord.Text + "," + YCoord.Text;
            }
            else if (e.KeyData == Keys.Enter)
            {
                Add.PerformClick();
            }
        }


        private void Execute_Click(object sender, EventArgs e)
        {
            // minimize form
            this.WindowState = FormWindowState.Minimized;
            int j = 0;

            if (int.TryParse(Loops.Text.Replace("", String.Empty), out j))
            {
                List<string> Sequence = File.ReadLines(seqPath).ToList();
                foreach (string item in Sequence)
                {
                    Sequence sq = new Sequence();
                    sq.Reader(item.ToLower());
                }
            }
            else
            {
                MessageBox.Show("Enter a valid integer");
            }
        }

        private string selection = "";
        private void ScreenCap_Click(object sender, EventArgs e)
        {
            ImageScanner.ScreenCapture();
            MessageBox.Show("Screen Capture at: " + ScreenPath);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            // load all cue images in the folder for use
            var imgDictonary = Directory.GetFiles(Path.GetDirectoryName(Application.ExecutablePath) + @"\img")
                          .Select(file => new FileInfo(file))
                          .ToDictionary(f => f.Name.ToLower(), f => f);

            var imgKeys = imgDictonary.Keys.ToArray();

            String[] consoleText = ConsoleText.Text.Split(new[] { Environment.NewLine }
                                          , StringSplitOptions.RemoveEmptyEntries);
            var coordCommands = new List<string>() { "lclick", "rclick", "moveto", "sclick"};
            var regCommands = new List<string>() {"copy", "copyall", "copy2csv", "paste", "altab", "timewait" };
            var fileCommands = new List<string>() {"imgwait"};


            //MessageBox.Show(Clipboard.GetText());
            // SendKeys.Send("%{Tab}")

            if (coordCommands.Contains(Commands.Text.ToLower()))
            {

                if (!consoleText.Last().Contains("Enter coord"))
                {
                    selection = Commands.Text;
                    ConsoleText.Text += Environment.NewLine + "Enter coordinates in the form: x,y" + Environment.NewLine;    
                    Commands.Text = "";
                }
                else
                {
                    ConsoleText.Text += Environment.NewLine + "Enter coordinates in the form: x,y" + Environment.NewLine;
                    Commands.Text = "";
                }
              
            }

            // expecting a coord
            else if (consoleText.Last().Contains("Enter coord"))
            {
                if (Commands.Text.Contains(",") & Char.IsNumber(Commands.Text, 0) & Char.IsNumber(Commands.Text, Commands.Text.Length - 1) & Commands.Text.Trim() != "")
                {
                    ConsoleText.Text += Environment.NewLine + selection + ": " + Commands.Text.Trim() + Environment.NewLine;
                    File.AppendAllText(seqPath, selection + ":" + Commands.Text.Trim() + Environment.NewLine);
                    seqList.Add(selection + ":" + Commands.Text.Trim());
                    ConsoleText.Text += Environment.NewLine + "Current Sequence: \n" + string.Join("  ", seqList) + Environment.NewLine;
                    selection = "";
                    Commands.Text = "";
                }
                else
                {
                    Commands.Text = "";
                    ConsoleText.Text += Environment.NewLine + "Enter coordinates in the form: x,y" + Environment.NewLine;
                }
            }
            else if (fileCommands.Contains(Commands.Text.ToLower()))
            {
                ConsoleText.Text += Environment.NewLine + "Choose an image: " + string.Join("  ", imgKeys) + Environment.NewLine;
                Commands.Text = "";
            }
            else if (consoleText.Last().Contains("Choose "))
            {

            }

            else if (regCommands.Contains(Commands.Text.ToLower()))
            {
                File.AppendAllText(seqPath, selection + Commands.Text.Trim() + Environment.NewLine);
                seqList.Add(Commands.Text.Trim());
                ConsoleText.Text += Environment.NewLine + "Current Sequence: \n" + string.Join("  ", seqList) + Environment.NewLine;
                Commands.Text = "";
            }
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            if (new FileInfo(seqPath).Length == 0)
            {
                MessageBox.Show("File is already empty");
            }
            else
            {
                var lines = File.ReadAllLines(seqPath);
                File.WriteAllLines(seqPath, lines.Take(lines.Length - 1).ToArray());
            }
        }

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

        private void ECFile_Click(object sender, EventArgs e)
        {
            //ImageScanner.ScreenCapture();
            // wait(1000);
            // Bitmap bitmain = new Bitmap(ScreenPath);
            // Bitmap bitsub = new Bitmap(@"E:\Documents\sub.png");

            // MessageBox.Show(ImageScanner.GetSubPositions(bitmain, bitsub)[0].ToString());
            //SendKeys.Send("This is a test...");
            //MessageBox.Show(Path.GetDirectoryName(Application.ExecutablePath));
            int j = 0;
            string ScreenPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\folder1\Screenshot.PNG";
            Bitmap bitmain = new Bitmap(ScreenPath);
            Bitmap bitsub = new Bitmap(@"C:\Users\junxi\source\repos\AutoClicker\AutoClicker\bin\Debug\img\sub.PNG");
            bool isEmpty = !ImageScanner.GetSubPositions(bitmain, bitsub).Any();

            while (isEmpty && j < 10)
            {
                
                j += 1;
                ImageScanner.ScreenCapture();
                wait(2000);
                //ScreenPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Screenshot.png";
            }
            MessageBox.Show("found");
            
        }

        private void loadSeq_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            //seqFile.Text = filePath;
            if (filePath != string.Empty)
            {
                seqPath = filePath;
                MessageBox.Show("HI");
            }
        }
    }
}
