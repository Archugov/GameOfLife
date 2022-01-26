
namespace GameOfLife
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numResolution = new System.Windows.Forms.NumericUpDown();
            this.numDensity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.butStart = new System.Windows.Forms.Button();
            this.butStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDensity)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.butStop);
            this.splitContainer1.Panel1.Controls.Add(this.butStart);
            this.splitContainer1.Panel1.Controls.Add(this.numDensity);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.numResolution);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1251, 701);
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1113, 697);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Разрешение";
            // 
            // numResolution
            // 
            this.numResolution.Location = new System.Drawing.Point(14, 28);
            this.numResolution.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numResolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numResolution.Name = "numResolution";
            this.numResolution.Size = new System.Drawing.Size(32, 20);
            this.numResolution.TabIndex = 1;
            this.numResolution.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numDensity
            // 
            this.numDensity.Location = new System.Drawing.Point(14, 68);
            this.numDensity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numDensity.Name = "numDensity";
            this.numDensity.Size = new System.Drawing.Size(32, 20);
            this.numDensity.TabIndex = 3;
            this.numDensity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Плотность";
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(14, 95);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(75, 23);
            this.butStart.TabIndex = 4;
            this.butStart.Text = "Старт";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // butStop
            // 
            this.butStop.Location = new System.Drawing.Point(14, 124);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(75, 23);
            this.butStop.TabIndex = 5;
            this.butStop.Text = "Стоп";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 701);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDensity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.NumericUpDown numDensity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numResolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

