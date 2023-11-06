namespace PONG3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBoxCampo = new PictureBox();
            textBoxX = new TextBox();
            labelX = new Label();
            labelY = new Label();
            textBoxY = new TextBox();
            labelYDir = new Label();
            textBoxYDir = new TextBox();
            labelXdir = new Label();
            textBoxXDir = new TextBox();
            labelColor = new Label();
            textBoxColore = new TextBox();
            labelDim = new Label();
            textBoxDim = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            textBoxGiocatori = new TextBox();
            textBoxPalline = new TextBox();
            labelGiocatori = new Label();
            labelPalline = new Label();
            buttonGenerate = new Button();
            buttonRun = new Button();
            labelPunteggioA = new Label();
            labelPunteggioB = new Label();
            textBoxKey = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCampo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCampo
            // 
            pictureBoxCampo.BackColor = Color.White;
            pictureBoxCampo.Location = new Point(12, 12);
            pictureBoxCampo.Name = "pictureBoxCampo";
            pictureBoxCampo.Size = new Size(803, 374);
            pictureBoxCampo.TabIndex = 0;
            pictureBoxCampo.TabStop = false;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(915, 12);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(100, 23);
            textBoxX.TabIndex = 1;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(871, 15);
            labelX.Name = "labelX";
            labelX.Size = new Size(13, 15);
            labelX.TabIndex = 2;
            labelX.Text = "x";
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Location = new Point(871, 44);
            labelY.Name = "labelY";
            labelY.Size = new Size(13, 15);
            labelY.TabIndex = 4;
            labelY.Text = "y";
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(915, 41);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(100, 23);
            textBoxY.TabIndex = 3;
            // 
            // labelYDir
            // 
            labelYDir.AutoSize = true;
            labelYDir.Location = new Point(871, 102);
            labelYDir.Name = "labelYDir";
            labelYDir.Size = new Size(28, 15);
            labelYDir.TabIndex = 8;
            labelYDir.Text = "yDir";
            // 
            // textBoxYDir
            // 
            textBoxYDir.Location = new Point(915, 99);
            textBoxYDir.Name = "textBoxYDir";
            textBoxYDir.Size = new Size(100, 23);
            textBoxYDir.TabIndex = 7;
            // 
            // labelXdir
            // 
            labelXdir.AutoSize = true;
            labelXdir.Location = new Point(871, 73);
            labelXdir.Name = "labelXdir";
            labelXdir.Size = new Size(28, 15);
            labelXdir.TabIndex = 6;
            labelXdir.Text = "xDir";
            // 
            // textBoxXDir
            // 
            textBoxXDir.Location = new Point(915, 70);
            textBoxXDir.Name = "textBoxXDir";
            textBoxXDir.Size = new Size(100, 23);
            textBoxXDir.TabIndex = 5;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(871, 160);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(42, 15);
            labelColor.TabIndex = 12;
            labelColor.Text = "Colore";
            // 
            // textBoxColore
            // 
            textBoxColore.Location = new Point(915, 157);
            textBoxColore.Name = "textBoxColore";
            textBoxColore.Size = new Size(100, 23);
            textBoxColore.TabIndex = 11;
            // 
            // labelDim
            // 
            labelDim.AutoSize = true;
            labelDim.Location = new Point(871, 131);
            labelDim.Name = "labelDim";
            labelDim.Size = new Size(28, 15);
            labelDim.TabIndex = 10;
            labelDim.Text = "dim";
            // 
            // textBoxDim
            // 
            textBoxDim.Location = new Point(915, 128);
            textBoxDim.Name = "textBoxDim";
            textBoxDim.Size = new Size(100, 23);
            textBoxDim.TabIndex = 9;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // textBoxGiocatori
            // 
            textBoxGiocatori.Location = new Point(915, 259);
            textBoxGiocatori.Name = "textBoxGiocatori";
            textBoxGiocatori.Size = new Size(100, 23);
            textBoxGiocatori.TabIndex = 13;
            // 
            // textBoxPalline
            // 
            textBoxPalline.Location = new Point(915, 288);
            textBoxPalline.Name = "textBoxPalline";
            textBoxPalline.Size = new Size(100, 23);
            textBoxPalline.TabIndex = 14;
            // 
            // labelGiocatori
            // 
            labelGiocatori.AutoSize = true;
            labelGiocatori.Location = new Point(854, 262);
            labelGiocatori.Name = "labelGiocatori";
            labelGiocatori.Size = new Size(55, 15);
            labelGiocatori.TabIndex = 15;
            labelGiocatori.Text = "Giocatori";
            // 
            // labelPalline
            // 
            labelPalline.AutoSize = true;
            labelPalline.Location = new Point(854, 291);
            labelPalline.Name = "labelPalline";
            labelPalline.Size = new Size(57, 15);
            labelPalline.TabIndex = 16;
            labelPalline.Text = "n° Palline";
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(940, 317);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(75, 23);
            buttonGenerate.TabIndex = 17;
            buttonGenerate.Text = "Genera";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(940, 466);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(75, 23);
            buttonRun.TabIndex = 18;
            buttonRun.Text = "Run";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // labelPunteggioA
            // 
            labelPunteggioA.AutoSize = true;
            labelPunteggioA.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelPunteggioA.Location = new Point(48, 389);
            labelPunteggioA.Name = "labelPunteggioA";
            labelPunteggioA.Size = new Size(28, 32);
            labelPunteggioA.TabIndex = 19;
            labelPunteggioA.Text = "0";
            // 
            // labelPunteggioB
            // 
            labelPunteggioB.AutoSize = true;
            labelPunteggioB.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelPunteggioB.Location = new Point(787, 389);
            labelPunteggioB.Name = "labelPunteggioB";
            labelPunteggioB.Size = new Size(28, 32);
            labelPunteggioB.TabIndex = 20;
            labelPunteggioB.Text = "0";
            // 
            // textBoxKey
            // 
            textBoxKey.Location = new Point(915, 186);
            textBoxKey.Name = "textBoxKey";
            textBoxKey.Size = new Size(100, 23);
            textBoxKey.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 501);
            Controls.Add(textBoxKey);
            Controls.Add(labelPunteggioB);
            Controls.Add(labelPunteggioA);
            Controls.Add(buttonRun);
            Controls.Add(buttonGenerate);
            Controls.Add(labelPalline);
            Controls.Add(labelGiocatori);
            Controls.Add(textBoxPalline);
            Controls.Add(textBoxGiocatori);
            Controls.Add(labelColor);
            Controls.Add(textBoxColore);
            Controls.Add(labelDim);
            Controls.Add(textBoxDim);
            Controls.Add(labelYDir);
            Controls.Add(textBoxYDir);
            Controls.Add(labelXdir);
            Controls.Add(textBoxXDir);
            Controls.Add(labelY);
            Controls.Add(textBoxY);
            Controls.Add(labelX);
            Controls.Add(textBoxX);
            Controls.Add(pictureBoxCampo);
            Name = "Form1";
            Text = "Pong - 2IoT";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCampo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxCampo;
        private TextBox textBoxX;
        private Label labelX;
        private Label labelY;
        private TextBox textBoxY;
        private Label labelYDir;
        private TextBox textBoxYDir;
        private Label labelXdir;
        private TextBox textBoxXDir;
        private Label labelColor;
        private TextBox textBoxColore;
        private Label labelDim;
        private TextBox textBoxDim;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBoxGiocatori;
        private TextBox textBoxPalline;
        private Label labelGiocatori;
        private Label labelPalline;
        private Button buttonGenerate;
        private Button buttonRun;
        private Label labelPunteggioA;
        private Label labelPunteggioB;
        private TextBox textBoxKey;
    }
}