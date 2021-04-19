namespace Pen_Testing
{
    partial class FormDrawBoard
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxPen = new System.Windows.Forms.CheckBox();
            this.panelBoard = new System.Windows.Forms.Panel();
            this.buttonClearGraphics = new System.Windows.Forms.Button();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.numericUpDownPenWidth = new System.Windows.Forms.NumericUpDown();
            this.buttonPenColorWhite = new System.Windows.Forms.Button();
            this.buttonPenColorBlack = new System.Windows.Forms.Button();
            this.buttonBoardColorWhite = new System.Windows.Forms.Button();
            this.buttonBoardColorBlack = new System.Windows.Forms.Button();
            this.buttonPenColorGreen = new System.Windows.Forms.Button();
            this.buttonPenColorRed = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonImage = new System.Windows.Forms.Button();
            this.labelDraw = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelMap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxPen
            // 
            this.checkBoxPen.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxPen.AutoSize = true;
            this.checkBoxPen.ForeColor = System.Drawing.Color.Black;
            this.checkBoxPen.Location = new System.Drawing.Point(660, 415);
            this.checkBoxPen.Name = "checkBoxPen";
            this.checkBoxPen.Size = new System.Drawing.Size(36, 23);
            this.checkBoxPen.TabIndex = 0;
            this.checkBoxPen.Text = "Pen";
            this.checkBoxPen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPen.UseVisualStyleBackColor = true;
            this.checkBoxPen.CheckedChanged += new System.EventHandler(this.checkBoxPen_CheckedChanged);
            // 
            // panelBoard
            // 
            this.panelBoard.BackColor = System.Drawing.Color.White;
            this.panelBoard.Location = new System.Drawing.Point(12, 12);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(776, 352);
            this.panelBoard.TabIndex = 1;
            this.panelBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBoard_MouseDown);
            this.panelBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBoard_MouseMove);
            this.panelBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelBoard_MouseUp);
            // 
            // buttonClearGraphics
            // 
            this.buttonClearGraphics.ForeColor = System.Drawing.Color.Red;
            this.buttonClearGraphics.Location = new System.Drawing.Point(702, 415);
            this.buttonClearGraphics.Name = "buttonClearGraphics";
            this.buttonClearGraphics.Size = new System.Drawing.Size(86, 23);
            this.buttonClearGraphics.TabIndex = 2;
            this.buttonClearGraphics.Text = "Clear";
            this.buttonClearGraphics.UseVisualStyleBackColor = true;
            this.buttonClearGraphics.Click += new System.EventHandler(this.buttonClearGraphics_Click);
            // 
            // buttonGraph
            // 
            this.buttonGraph.Location = new System.Drawing.Point(12, 415);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(75, 23);
            this.buttonGraph.TabIndex = 3;
            this.buttonGraph.Text = "Graph";
            this.buttonGraph.UseVisualStyleBackColor = true;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // numericUpDownPenWidth
            // 
            this.numericUpDownPenWidth.Location = new System.Drawing.Point(618, 415);
            this.numericUpDownPenWidth.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownPenWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPenWidth.Name = "numericUpDownPenWidth";
            this.numericUpDownPenWidth.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownPenWidth.TabIndex = 4;
            this.numericUpDownPenWidth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownPenWidth.ValueChanged += new System.EventHandler(this.numericUpDownPenWidth_ValueChanged);
            // 
            // buttonPenColorWhite
            // 
            this.buttonPenColorWhite.BackColor = System.Drawing.Color.White;
            this.buttonPenColorWhite.Location = new System.Drawing.Point(572, 415);
            this.buttonPenColorWhite.Name = "buttonPenColorWhite";
            this.buttonPenColorWhite.Size = new System.Drawing.Size(40, 23);
            this.buttonPenColorWhite.TabIndex = 5;
            this.buttonPenColorWhite.Text = "W";
            this.buttonPenColorWhite.UseVisualStyleBackColor = false;
            this.buttonPenColorWhite.Click += new System.EventHandler(this.buttonPenColorWhite_Click);
            // 
            // buttonPenColorBlack
            // 
            this.buttonPenColorBlack.BackColor = System.Drawing.Color.Black;
            this.buttonPenColorBlack.ForeColor = System.Drawing.Color.White;
            this.buttonPenColorBlack.Location = new System.Drawing.Point(526, 415);
            this.buttonPenColorBlack.Name = "buttonPenColorBlack";
            this.buttonPenColorBlack.Size = new System.Drawing.Size(40, 23);
            this.buttonPenColorBlack.TabIndex = 6;
            this.buttonPenColorBlack.Text = "B";
            this.buttonPenColorBlack.UseVisualStyleBackColor = false;
            this.buttonPenColorBlack.Click += new System.EventHandler(this.buttonPenColorBlack_Click);
            // 
            // buttonBoardColorWhite
            // 
            this.buttonBoardColorWhite.BackColor = System.Drawing.Color.White;
            this.buttonBoardColorWhite.Location = new System.Drawing.Point(748, 370);
            this.buttonBoardColorWhite.Name = "buttonBoardColorWhite";
            this.buttonBoardColorWhite.Size = new System.Drawing.Size(40, 23);
            this.buttonBoardColorWhite.TabIndex = 7;
            this.buttonBoardColorWhite.Text = "W";
            this.buttonBoardColorWhite.UseVisualStyleBackColor = false;
            this.buttonBoardColorWhite.Click += new System.EventHandler(this.buttonBoardColorWhite_Click);
            // 
            // buttonBoardColorBlack
            // 
            this.buttonBoardColorBlack.BackColor = System.Drawing.Color.Black;
            this.buttonBoardColorBlack.ForeColor = System.Drawing.Color.White;
            this.buttonBoardColorBlack.Location = new System.Drawing.Point(702, 370);
            this.buttonBoardColorBlack.Name = "buttonBoardColorBlack";
            this.buttonBoardColorBlack.Size = new System.Drawing.Size(40, 23);
            this.buttonBoardColorBlack.TabIndex = 8;
            this.buttonBoardColorBlack.Text = "B";
            this.buttonBoardColorBlack.UseVisualStyleBackColor = false;
            this.buttonBoardColorBlack.Click += new System.EventHandler(this.buttonBoardColorBlack_Click);
            // 
            // buttonPenColorGreen
            // 
            this.buttonPenColorGreen.BackColor = System.Drawing.Color.Green;
            this.buttonPenColorGreen.ForeColor = System.Drawing.Color.White;
            this.buttonPenColorGreen.Location = new System.Drawing.Point(480, 415);
            this.buttonPenColorGreen.Name = "buttonPenColorGreen";
            this.buttonPenColorGreen.Size = new System.Drawing.Size(40, 23);
            this.buttonPenColorGreen.TabIndex = 9;
            this.buttonPenColorGreen.Text = "G";
            this.buttonPenColorGreen.UseVisualStyleBackColor = false;
            this.buttonPenColorGreen.Click += new System.EventHandler(this.buttonPenColorGreen_Click);
            // 
            // buttonPenColorRed
            // 
            this.buttonPenColorRed.BackColor = System.Drawing.Color.Red;
            this.buttonPenColorRed.ForeColor = System.Drawing.Color.White;
            this.buttonPenColorRed.Location = new System.Drawing.Point(434, 415);
            this.buttonPenColorRed.Name = "buttonPenColorRed";
            this.buttonPenColorRed.Size = new System.Drawing.Size(40, 23);
            this.buttonPenColorRed.TabIndex = 10;
            this.buttonPenColorRed.Text = "R";
            this.buttonPenColorRed.UseVisualStyleBackColor = false;
            this.buttonPenColorRed.Click += new System.EventHandler(this.buttonPenColorRed_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Enabled = false;
            this.buttonLoad.Location = new System.Drawing.Point(540, 370);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 11;
            this.buttonLoad.Text = "Load BMP";
            this.buttonLoad.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(621, 370);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save BMP";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonImage
            // 
            this.buttonImage.Location = new System.Drawing.Point(93, 415);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Size = new System.Drawing.Size(75, 23);
            this.buttonImage.TabIndex = 13;
            this.buttonImage.Text = "Grass field";
            this.buttonImage.UseVisualStyleBackColor = true;
            this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
            // 
            // labelDraw
            // 
            this.labelDraw.AutoSize = true;
            this.labelDraw.ForeColor = System.Drawing.Color.White;
            this.labelDraw.Location = new System.Drawing.Point(12, 399);
            this.labelDraw.Name = "labelDraw";
            this.labelDraw.Size = new System.Drawing.Size(32, 13);
            this.labelDraw.TabIndex = 14;
            this.labelDraw.Text = "Draw";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(269, 415);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 15;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(174, 418);
            this.numericUpDownX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownX.TabIndex = 16;
            this.numericUpDownX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(223, 418);
            this.numericUpDownY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownY.TabIndex = 17;
            this.numericUpDownY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.ForeColor = System.Drawing.Color.White;
            this.labelWidth.Location = new System.Drawing.Point(174, 402);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(35, 13);
            this.labelWidth.TabIndex = 18;
            this.labelWidth.Text = "Width";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.ForeColor = System.Drawing.Color.White;
            this.labelHeight.Location = new System.Drawing.Point(220, 402);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(38, 13);
            this.labelHeight.TabIndex = 19;
            this.labelHeight.Text = "Height";
            // 
            // labelMap
            // 
            this.labelMap.AutoSize = true;
            this.labelMap.ForeColor = System.Drawing.Color.White;
            this.labelMap.Location = new System.Drawing.Point(269, 402);
            this.labelMap.Name = "labelMap";
            this.labelMap.Size = new System.Drawing.Size(28, 13);
            this.labelMap.TabIndex = 20;
            this.labelMap.Text = "Map";
            // 
            // FormDrawBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMap);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.numericUpDownX);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.labelDraw);
            this.Controls.Add(this.buttonImage);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonPenColorRed);
            this.Controls.Add(this.buttonPenColorGreen);
            this.Controls.Add(this.buttonBoardColorBlack);
            this.Controls.Add(this.buttonBoardColorWhite);
            this.Controls.Add(this.buttonPenColorBlack);
            this.Controls.Add(this.buttonPenColorWhite);
            this.Controls.Add(this.numericUpDownPenWidth);
            this.Controls.Add(this.buttonGraph);
            this.Controls.Add(this.buttonClearGraphics);
            this.Controls.Add(this.panelBoard);
            this.Controls.Add(this.checkBoxPen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDrawBoard";
            this.ShowIcon = false;
            this.Text = "Draw Board";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxPen;
        private System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.Button buttonClearGraphics;
        private System.Windows.Forms.Button buttonGraph;
        private System.Windows.Forms.NumericUpDown numericUpDownPenWidth;
        private System.Windows.Forms.Button buttonPenColorWhite;
        private System.Windows.Forms.Button buttonPenColorBlack;
        private System.Windows.Forms.Button buttonBoardColorWhite;
        private System.Windows.Forms.Button buttonBoardColorBlack;
        private System.Windows.Forms.Button buttonPenColorGreen;
        private System.Windows.Forms.Button buttonPenColorRed;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonImage;
        private System.Windows.Forms.Label labelDraw;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelMap;
    }
}

