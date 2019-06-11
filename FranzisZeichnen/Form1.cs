using System;
using System.Drawing;
using System.Windows.Forms;

namespace FranzisZeichnen
{
    public partial class FormSimplePaint : Form
    {
        public enum Tool
        {
            Pen,
            Shape,
            Text
        }

        private string _fileName;
        private bool _painting;
        private Tool _currentTool;
        private Graphics _graphic;
        private Object _toolX;
        private float sngX;
        private float sngY;

        public string fileName { get; set; }
        public bool drawing { get; set; }

        public Tool CurrentTool
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
    }
}
