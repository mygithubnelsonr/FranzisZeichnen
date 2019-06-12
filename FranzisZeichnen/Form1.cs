using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace FranzisZeichnen
{
    public partial class FormSimplePaint : Form
    {
        public enum Tools
        {
            Pen,
            Shape,
            Text
        }

        public enum Shapes
        {
            Rectangle,
            Ellipse
        }

        private string _fileName;
        private bool _drawing;
        private Tools _currentTool;
        private Graphics _graphic;
        private Object _toolX;
        private float sngX;
        private float sngY;

        public string fileName { get; set; }
        public bool drawing { get; set; }

        public Tools CurrentTool
        {
            get { return _currentTool; }
            set
            {
                _currentTool = value;
                if (_toolX != null)
                {
                    ((IDisposable)_toolX).Dispose();
                }
            }
        }

        public FormSimplePaint()
        {
            InitializeComponent();
        }

        #region Form Controls
        private void FormSimplePaint_Load(object sender, EventArgs e)
        {
            FillLists();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height, PixelFormat.Format24bppRgb);
            _graphic = Graphics.FromImage(pictureBox1.Image);
            _graphic.Clear(Color.White);
            radioButtonStift.PerformClick();
        }

        private void radioButtonStift_Click(object sender, EventArgs e)
        {
            _currentTool = Tools.Pen;
            panelWidth.Visible = true;
            panelType.Visible = false;
            panelText.Visible = false;
        }

        private void radioButtonForm_Click(object sender, EventArgs e)
        {
            _currentTool = Tools.Shape;
            panelWidth.Visible = false;
            panelType.Visible = true;
            panelText.Visible = false;

        }

        private void radioButtonText_Click(object sender, EventArgs e)
        {
            _currentTool = Tools.Text;
            panelWidth.Visible = false;
            panelType.Visible = false;
            panelText.Visible = true;
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height, PixelFormat.Format24bppRgb);
            _graphic = Graphics.FromImage(pictureBox1.Image);
            _graphic.Clear(Color.White);
            pictureBox1.Refresh();
        }

        private void ToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            string fileNameX;

            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                fileNameX = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(fileNameX);
                _graphic = Graphics.FromImage(pictureBox1.Image);

                this.Text += " - " + fileNameX;
            }
        }

        private void ToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            ImageFormat oFormat = null;
            string FileNameX;
            var result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                FileNameX = saveFileDialog1.FileName;
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        oFormat = ImageFormat.Bmp;
                        break;
                    case 2:
                        oFormat = ImageFormat.Png;
                        break;
                    case 3:
                        oFormat = ImageFormat.Jpeg;
                        break;

                }

                try
                {
                    pictureBox1.Image.Save(FileNameX, oFormat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_drawing == true)
            {
                _graphic.DrawLine((Pen)_toolX, sngX, sngY, e.X, e.Y);
                sngX = e.X;
                sngY = e.Y;
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (_currentTool)
            {
                case Tools.Pen:
                    _toolX = new System.Drawing.Pen(Color.FromName(comboBoxColor.Text), (float)numericUpDownBreite.Value);
                    sngX = e.X;
                    sngY = e.Y;
                    _drawing = true;
                    break;
                case Tools.Shape:
                    switch (comboBoxType.SelectedIndex)
                    {
                        case (int)Shapes.Rectangle:
                            _graphic.FillRectangle(new SolidBrush(Color.FromName(comboBoxColor.Text)), e.X, e.Y, (float)numericUpDownWidth.Value, (float)numericUpDownHeight.Value);
                            break;
                        case (int)Shapes.Ellipse:
                            _graphic.FillEllipse(new SolidBrush(Color.FromName(comboBoxColor.Text)), e.X, e.Y, (float)numericUpDownWidth.Value, (float)numericUpDownHeight.Value);
                            break;
                    }
                    pictureBox1.Refresh();
                    break;
                case Tools.Text:
                    _toolX = new Font(comboBoxFont.Text, (float)numericUpDownSize.Value);
                    _graphic.DrawString(textBoxText.Text, (Font)_toolX, new SolidBrush(Color.FromName(comboBoxColor.Text)), e.X, e.Y);
                    pictureBox1.Refresh();
                    break;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _drawing = false;

        }
        #endregion

        private void FillLists()
        {
            {
                var i = comboBoxColor.Items;
                i.Add("Black");
                i.Add("Red");
                i.Add("Green");
                i.Add("Blue");
                i.Add("Yellow");
            }
            comboBoxColor.SelectedIndex = 0;

            {
                var i = comboBoxType.Items;
                i.Add("Rectangle");
                i.Add("Ellipse");
            }
            comboBoxType.SelectedIndex = 0;

            {
                var i = comboBoxFont.Items;
                i.Add("Arial");
                i.Add("Times New Roman");
                i.Add("Courier New");
            }
            comboBoxFont.SelectedIndex = 0;
        }

    }
}
