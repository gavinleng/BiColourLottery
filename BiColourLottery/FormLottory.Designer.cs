namespace BiColourLottery
{
    partial class FormLottory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelRed6 = new System.Windows.Forms.Label();
            this.labelRed5 = new System.Windows.Forms.Label();
            this.labelRed4 = new System.Windows.Forms.Label();
            this.labelRed3 = new System.Windows.Forms.Label();
            this.labelRed2 = new System.Windows.Forms.Label();
            this.labelRed1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.labelBlue);
            this.groupBox1.Controls.Add(this.labelRed6);
            this.groupBox1.Controls.Add(this.labelRed5);
            this.groupBox1.Controls.Add(this.labelRed4);
            this.groupBox1.Controls.Add(this.labelRed3);
            this.groupBox1.Controls.Add(this.labelRed2);
            this.groupBox1.Controls.Add(this.labelRed1);
            this.groupBox1.Location = new System.Drawing.Point(28, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Running Result";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(448, 190);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 40);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(122, 190);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(128, 40);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.ForeColor = System.Drawing.Color.Blue;
            this.labelBlue.Location = new System.Drawing.Point(644, 74);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(27, 20);
            this.labelBlue.TabIndex = 6;
            this.labelBlue.Text = "00";
            // 
            // labelRed6
            // 
            this.labelRed6.AutoSize = true;
            this.labelRed6.ForeColor = System.Drawing.Color.Red;
            this.labelRed6.Location = new System.Drawing.Point(517, 74);
            this.labelRed6.Name = "labelRed6";
            this.labelRed6.Size = new System.Drawing.Size(27, 20);
            this.labelRed6.TabIndex = 5;
            this.labelRed6.Text = "00";
            // 
            // labelRed5
            // 
            this.labelRed5.AutoSize = true;
            this.labelRed5.ForeColor = System.Drawing.Color.Red;
            this.labelRed5.Location = new System.Drawing.Point(423, 74);
            this.labelRed5.Name = "labelRed5";
            this.labelRed5.Size = new System.Drawing.Size(27, 20);
            this.labelRed5.TabIndex = 4;
            this.labelRed5.Text = "00";
            // 
            // labelRed4
            // 
            this.labelRed4.AutoSize = true;
            this.labelRed4.ForeColor = System.Drawing.Color.Red;
            this.labelRed4.Location = new System.Drawing.Point(333, 74);
            this.labelRed4.Name = "labelRed4";
            this.labelRed4.Size = new System.Drawing.Size(27, 20);
            this.labelRed4.TabIndex = 3;
            this.labelRed4.Text = "00";
            // 
            // labelRed3
            // 
            this.labelRed3.AutoSize = true;
            this.labelRed3.ForeColor = System.Drawing.Color.Red;
            this.labelRed3.Location = new System.Drawing.Point(239, 74);
            this.labelRed3.Name = "labelRed3";
            this.labelRed3.Size = new System.Drawing.Size(27, 20);
            this.labelRed3.TabIndex = 2;
            this.labelRed3.Text = "00";
            // 
            // labelRed2
            // 
            this.labelRed2.AutoSize = true;
            this.labelRed2.ForeColor = System.Drawing.Color.Red;
            this.labelRed2.Location = new System.Drawing.Point(138, 74);
            this.labelRed2.Name = "labelRed2";
            this.labelRed2.Size = new System.Drawing.Size(27, 20);
            this.labelRed2.TabIndex = 1;
            this.labelRed2.Text = "00";
            // 
            // labelRed1
            // 
            this.labelRed1.AutoSize = true;
            this.labelRed1.ForeColor = System.Drawing.Color.Red;
            this.labelRed1.Location = new System.Drawing.Point(45, 74);
            this.labelRed1.Name = "labelRed1";
            this.labelRed1.Size = new System.Drawing.Size(27, 20);
            this.labelRed1.TabIndex = 0;
            this.labelRed1.Text = "00";
            // 
            // FormLottory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormLottory";
            this.Text = "Lottery";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label labelRed6;
        private System.Windows.Forms.Label labelRed5;
        private System.Windows.Forms.Label labelRed4;
        private System.Windows.Forms.Label labelRed3;
        private System.Windows.Forms.Label labelRed2;
        private System.Windows.Forms.Label labelRed1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
    }
}

