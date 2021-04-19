using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pen_Testing
{
    public partial class FormDrawBoard : Form
    {

        bool penActive = true;
        bool moving = false;
        int x;
        int y;
        Pen pen;
        Pen penGraph;
        Graphics g;
        decimal penWidth = 5;
        Image grass = Properties.Resources.grass;
        Image stone = Properties.Resources.stone;
        Point p;
        int pX = 0;
        int pY = 0;
        List<List<string>> listMap = new List<List<string>>();
        Random rnd = new Random();

        public FormDrawBoard()
        {
            InitializeComponent();
            g = panelBoard.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, Convert.ToInt16(penWidth));
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            penGraph = new Pen(Color.Orange, 1);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startupDesign();
        }

        private void startupDesign()
        {

            checkBoxPen.ForeColor = Color.Green;

        }

        private void checkBoxPen_CheckedChanged(object sender, EventArgs e)
        {

            penActive = checkBoxPen.Checked;

            if (penActive == true)
            {
                checkBoxPen.ForeColor = Color.Green;
            }
            else
            {
                checkBoxPen.ForeColor = Color.Red;
            }

        }

        private void panelBoard_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
            panelBoard.Cursor = Cursors.Cross;
        }

        private void panelBoard_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            panelBoard.Cursor = Cursors.Default;

        }

        private void panelBoard_MouseMove(object sender, MouseEventArgs e)
        {

            if (moving == true && penActive == true)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }

        }

        private void buttonClearGraphics_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            Point[] graphLocations =
                {
                    new Point(10,  10),
                    new Point(30, 100),
                    new Point(200,  50),
                    new Point(250, 300)
                };

                g.DrawLines(penGraph, graphLocations);


        }

        private void numericUpDownPenWidth_ValueChanged(object sender, EventArgs e)
        {

            penWidth = numericUpDownPenWidth.Value;
            pen.Width = Convert.ToInt16(penWidth);

        }

        private void buttonPenColorWhite_Click(object sender, EventArgs e)
        {

            pen.Color = Color.White;

        }

        private void buttonPenColorBlack_Click(object sender, EventArgs e)
        {

            pen.Color = Color.Black;

        }

        private void buttonBoardColorBlack_Click(object sender, EventArgs e)
        {
            panelBoard.BackColor = Color.Black;
        }

        private void buttonBoardColorWhite_Click(object sender, EventArgs e)
        {
            panelBoard.BackColor = Color.White;

        }

        private void buttonPenColorRed_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;

        }

        private void buttonPenColorGreen_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Green;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {;
            Bitmap bm = new Bitmap(776, 352, g);
            try
            {
                bm.Save(@"" + Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\\\" + DateTime.Now.ToString("yyyMMdd_hhmmss") + ".PNG", ImageFormat.Png);
                MessageBox.Show("Saved to your desktop.", "Save");
            }
            catch (Exception exce)
            {

                MessageBox.Show(exce.ToString());
            }

        }

        private void buttonImage_Click(object sender, EventArgs e)
        {

            p = new Point(pX, pY);

            drawField(grass, p);

            pX += 10;
        }

        private void drawField(Image img, Point point)
        {
            g.DrawImage(img, point);
        }

        private string randomGround()
        {
            int rndNumber = rnd.Next(0,9);
            if (rndNumber < 8) // 70% grass
            {
                return "grass";
            }
            else
            {
                return "stone";
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {

            Image imageGround;

            g.Clear(Color.White);

            for (int i = 0; i < Convert.ToInt16(numericUpDownX.Value); i++)
            {

                List<string> xFields = new List<string>();

                for (int counter = 0; counter < Convert.ToInt16(numericUpDownY.Value); counter++)
                {
                    string ground = randomGround();
                    xFields.Add(ground);
                    switch (ground)
                    {
                        case "grass":
                            imageGround = grass;
                            break;
                        case "stone":
                            imageGround = stone;
                            break;
                        default:
                            imageGround = grass;
                            break;
                            
                    }

                    drawField(imageGround, new Point(i*10, counter*10));

                }
             
                listMap.Add(xFields);

            }



        }
    }
}
