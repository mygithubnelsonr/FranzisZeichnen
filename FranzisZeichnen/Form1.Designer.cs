namespace FranzisZeichnen
{
    partial class FormSimplePaint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.radioButtonText = new System.Windows.Forms.RadioButton();
            this.radioButtonForm = new System.Windows.Forms.RadioButton();
            this.radioButtonStift = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelWidth = new System.Windows.Forms.Panel();
            this.numericUpDownBreite = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.panelType = new System.Windows.Forms.Panel();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelText = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFont = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBreite)).BeginInit();
            this.panelType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            this.panelText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.radioButtonText);
            this.panelLeft.Controls.Add(this.radioButtonForm);
            this.panelLeft.Controls.Add(this.radioButtonStift);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 24);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(86, 367);
            this.panelLeft.TabIndex = 0;
            // 
            // radioButtonText
            // 
            this.radioButtonText.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonText.Location = new System.Drawing.Point(21, 210);
            this.radioButtonText.Name = "radioButtonText";
            this.radioButtonText.Size = new System.Drawing.Size(48, 36);
            this.radioButtonText.TabIndex = 2;
            this.radioButtonText.Text = "Text";
            this.radioButtonText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonText.UseVisualStyleBackColor = true;
            this.radioButtonText.Click += new System.EventHandler(this.radioButtonText_Click);
            // 
            // radioButtonForm
            // 
            this.radioButtonForm.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonForm.Location = new System.Drawing.Point(18, 105);
            this.radioButtonForm.Name = "radioButtonForm";
            this.radioButtonForm.Size = new System.Drawing.Size(48, 36);
            this.radioButtonForm.TabIndex = 1;
            this.radioButtonForm.Text = "Form";
            this.radioButtonForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonForm.UseVisualStyleBackColor = true;
            this.radioButtonForm.Click += new System.EventHandler(this.radioButtonForm_Click);
            // 
            // radioButtonStift
            // 
            this.radioButtonStift.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonStift.Checked = true;
            this.radioButtonStift.Location = new System.Drawing.Point(18, 18);
            this.radioButtonStift.Name = "radioButtonStift";
            this.radioButtonStift.Size = new System.Drawing.Size(48, 36);
            this.radioButtonStift.TabIndex = 0;
            this.radioButtonStift.TabStop = true;
            this.radioButtonStift.Text = "Stift";
            this.radioButtonStift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonStift.UseVisualStyleBackColor = true;
            this.radioButtonStift.Click += new System.EventHandler(this.radioButtonStift_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNew,
            this.ToolStripMenuItemOpen,
            this.ToolStripMenuItemSave,
            this.toolStripSeparator1,
            this.ToolStripMenuItemExit});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // ToolStripMenuItemNew
            // 
            this.ToolStripMenuItemNew.Name = "ToolStripMenuItemNew";
            this.ToolStripMenuItemNew.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenuItemNew.Text = "Neu";
            this.ToolStripMenuItemNew.Click += new System.EventHandler(this.ToolStripMenuItemNew_Click);
            // 
            // ToolStripMenuItemOpen
            // 
            this.ToolStripMenuItemOpen.Name = "ToolStripMenuItemOpen";
            this.ToolStripMenuItemOpen.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenuItemOpen.Text = "Öffnen";
            this.ToolStripMenuItemOpen.Click += new System.EventHandler(this.ToolStripMenuItemOpen_Click);
            // 
            // ToolStripMenuItemSave
            // 
            this.ToolStripMenuItemSave.Name = "ToolStripMenuItemSave";
            this.ToolStripMenuItemSave.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenuItemSave.Text = "Speichern";
            this.ToolStripMenuItemSave.Click += new System.EventHandler(this.ToolStripMenuItemSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(123, 6);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenuItemExit.Text = "Beenden";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(86, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 287);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panelWidth);
            this.panelBottom.Controls.Add(this.panelType);
            this.panelBottom.Controls.Add(this.panelText);
            this.panelBottom.Controls.Add(this.label1);
            this.panelBottom.Controls.Add(this.comboBoxColor);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(86, 311);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(564, 80);
            this.panelBottom.TabIndex = 3;
            // 
            // panelWidth
            // 
            this.panelWidth.Controls.Add(this.numericUpDownBreite);
            this.panelWidth.Controls.Add(this.label8);
            this.panelWidth.Location = new System.Drawing.Point(192, 12);
            this.panelWidth.Name = "panelWidth";
            this.panelWidth.Size = new System.Drawing.Size(274, 56);
            this.panelWidth.TabIndex = 7;
            this.panelWidth.Tag = "Panel2";
            // 
            // numericUpDownBreite
            // 
            this.numericUpDownBreite.Location = new System.Drawing.Point(96, 15);
            this.numericUpDownBreite.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownBreite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBreite.Name = "numericUpDownBreite";
            this.numericUpDownBreite.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownBreite.TabIndex = 1;
            this.numericUpDownBreite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Breite";
            // 
            // panelType
            // 
            this.panelType.Controls.Add(this.numericUpDownHeight);
            this.panelType.Controls.Add(this.comboBoxType);
            this.panelType.Controls.Add(this.label5);
            this.panelType.Controls.Add(this.numericUpDownWidth);
            this.panelType.Controls.Add(this.label6);
            this.panelType.Controls.Add(this.label7);
            this.panelType.Location = new System.Drawing.Point(192, 12);
            this.panelType.Name = "panelType";
            this.panelType.Size = new System.Drawing.Size(274, 56);
            this.panelType.TabIndex = 6;
            this.panelType.Tag = "Panel3";
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownHeight.Location = new System.Drawing.Point(64, 32);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownHeight.TabIndex = 7;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(64, 3);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(192, 21);
            this.comboBoxType.TabIndex = 6;
            this.comboBoxType.Tag = "Combobox3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Width";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownWidth.Location = new System.Drawing.Point(208, 32);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownWidth.TabIndex = 4;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Height";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Typ";
            // 
            // panelText
            // 
            this.panelText.Controls.Add(this.label4);
            this.panelText.Controls.Add(this.numericUpDownSize);
            this.panelText.Controls.Add(this.label3);
            this.panelText.Controls.Add(this.comboBoxFont);
            this.panelText.Controls.Add(this.label2);
            this.panelText.Controls.Add(this.textBoxText);
            this.panelText.Location = new System.Drawing.Point(192, 12);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(274, 56);
            this.panelText.TabIndex = 2;
            this.panelText.Tag = "Panel4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Size";
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.Location = new System.Drawing.Point(208, 32);
            this.numericUpDownSize.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numericUpDownSize.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownSize.TabIndex = 4;
            this.numericUpDownSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Font";
            // 
            // comboBoxFont
            // 
            this.comboBoxFont.FormattingEnabled = true;
            this.comboBoxFont.Location = new System.Drawing.Point(44, 32);
            this.comboBoxFont.Name = "comboBoxFont";
            this.comboBoxFont.Size = new System.Drawing.Size(104, 21);
            this.comboBoxFont.TabIndex = 2;
            this.comboBoxFont.Tag = "Combobox2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text";
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(44, 6);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(212, 20);
            this.textBoxText.TabIndex = 0;
            this.textBoxText.Text = "Enter some text here!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Farbe";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(15, 34);
            this.comboBoxColor.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(136, 21);
            this.comboBoxColor.TabIndex = 0;
            this.comboBoxColor.Tag = "Combobox1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|PNG files (*.png)|*.png|JPEG file (*.jpg)|*.jpg";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Zeichnung1";
            this.saveFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|PNG files (*.png)|*.png|JPEG file (*.jpg)|*.jpg";
            // 
            // panelRight
            // 
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(634, 24);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(16, 287);
            this.panelRight.TabIndex = 4;
            // 
            // FormSimplePaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 391);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSimplePaint";
            this.Text = "Simple Paint";
            this.Load += new System.EventHandler(this.FormSimplePaint_Load);
            this.panelLeft.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelWidth.ResumeLayout(false);
            this.panelWidth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBreite)).EndInit();
            this.panelType.ResumeLayout(false);
            this.panelType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            this.panelText.ResumeLayout(false);
            this.panelText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.RadioButton radioButtonText;
        private System.Windows.Forms.RadioButton radioButtonForm;
        private System.Windows.Forms.RadioButton radioButtonStift;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Panel panelType;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panelWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownBreite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelRight;
    }
}

