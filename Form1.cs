using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsciiArt
{
    public partial class Form1 : Form
    {
        public char[,] MAP;
        public readonly int LINE_LENGTH = "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM".Length;
        public readonly int ROW_LENGTH = 26;
        public Size charSize;
        public Form1()
        {
            InitializeComponent();
            MAP = new char[LINE_LENGTH, ROW_LENGTH];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            charSize = TextRenderer.MeasureText("M", picture.Font);

            FillWith(' ');
            UpdateDisplay();
        }
        char GetDrawChar()
        {
            if (charPick.Text.Length == 0) return ' ';
            return charPick.Text[0];
        }
        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            Point pos = e.Location;
            pos.X /= (charSize.Height/2);
            pos.Y /= charSize.Height;
            if(e.Button == MouseButtons.Left)
            {
                DrawCharacter(pos.X, pos.Y, GetDrawChar());
                UpdateDisplay();
            } else if(e.Button == MouseButtons.Right)
            {
                DrawCharacter(pos.X, pos.Y, ' ');
                UpdateDisplay();
            }
        }

        void FillWith(char character)
        {
            for(int x = 0; x < LINE_LENGTH; x++)
            {
                for(int y = 0; y < ROW_LENGTH; y++)
                {
                    MAP[x, y] = character;
                }
            }
        }
        void DrawCharacter(int x, int y, char c)
        {
            try
            {
                int val = sizeSlider.Value;
                if (val == 1)
                {
                    MAP[x, y] = c;
                }
                else if(val == 2)
                {
                    for (int ix = x - 2; ix <= x + 2; ix++)
                    {
                        for (int iy = y - 1; iy <= y + 1; iy++)
                        {
                            MAP[ix, iy] = c;
                        }
                    }
                }
                else if (val == 3)
                {
                    for (int ix = x - 3; ix <= x + 3; ix++)
                    {
                        for (int iy = y - 2; iy <= y + 2; iy++)
                        {
                            MAP[ix, iy] = c;
                        }
                    }
                }
            } catch(IndexOutOfRangeException) {
                return;
            }
        }
        void UpdateDisplay()
        {
            List<string> lines = new List<string>();
            for (int y = 0; y < ROW_LENGTH; y++)
            {
                StringBuilder lineBuilder = new StringBuilder();
                for(int x = 0; x < LINE_LENGTH; x++)
                {
                    lineBuilder.Append(MAP[x, y]);
                }
                lines.Add(lineBuilder.ToString());
            }
            picture.Text = string.Join("\r\n", lines);
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            string str = picture.Text.Replace(' ', '　');
            if (str.StartsWith("　"))
                str = '-' + str;
            Clipboard.SetText(str);
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            FillWith(' ');
            UpdateDisplay();
        }
        private void fillButton_Click(object sender, EventArgs e)
        {
            char c = GetDrawChar();
            FillWith(c);
            UpdateDisplay();
        }
        private void charPick_TextChanged(object sender, EventArgs e)
        {
            char c = GetDrawChar();
            fillButton.Text = "FILL WITH '" + c + "'";
        }

        // IMAGE STUFF
        private void loadImageButton_Click(object sender, EventArgs e)
        {
            string file;
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (.jpg, .png, .bmp)|*.jpg;*.png;*.bmp";
                ofd.Title = "Pick an image file...";
                ofd.CheckFileExists = true; ofd.CheckPathExists = true;
                ofd.Multiselect = false;

                if(ofd.ShowDialog() == DialogResult.OK)
                    file = ofd.FileName;
                else return;
            }

            // Load and apply file data.
            Bitmap scaled;
            using (Bitmap img = (Bitmap)Image.FromFile(file))
            {
                scaled = new Bitmap(img, LINE_LENGTH, ROW_LENGTH);
            }
            using(scaled)
            {
                for (int x = 0; x < scaled.Width; x++)
                {
                    for (int y = 0; y < scaled.Height; y++)
                    {
                        Color c = scaled.GetPixel(x, y);
                        int brightness = c.R + c.G + c.B;
                        char pixelChar;
                        // brightness is between 0 - 765
                        if (brightness < 50)
                            pixelChar = '█';
                        else if (brightness < 100)
                            pixelChar = '▓';
                        else if (brightness < 200)
                            pixelChar = '▒';
                        else if (brightness < 300)
                            pixelChar = '░';
                        else if (brightness < 400)
                            pixelChar = '□';
                        else if (brightness < 500)
                            pixelChar = '▪';
                        else if (brightness < 600)
                            pixelChar = '▫';
                        else if (brightness < 700)
                            pixelChar = '◦';
                        else
                            pixelChar = ' ';
                        DrawCharacter(x, y, pixelChar);
                    }
                }
            }
            UpdateDisplay();
        }
    }
}
