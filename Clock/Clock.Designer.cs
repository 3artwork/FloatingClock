namespace Clock
{
    partial class Clock
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this._pm = new System.Windows.Forms.Label();
            this.CountDown = new System.Windows.Forms.ProgressBar();
            this.TimeHR = new System.Windows.Forms.Label();
            this.colon = new System.Windows.Forms.Label();
            this.TimeMIN = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // _pm
            // 
            this._pm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._pm.AutoSize = true;
            this._pm.BackColor = System.Drawing.Color.Black;
            this._pm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._pm.Font = new System.Drawing.Font("Geometr212 BkCn BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._pm.ForeColor = System.Drawing.Color.PaleGreen;
            this._pm.Location = new System.Drawing.Point(257, 73);
            this._pm.Name = "_pm";
            this._pm.Size = new System.Drawing.Size(74, 40);
            this._pm.TabIndex = 12;
            this._pm.Text = "AM";
            this._pm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Clock_MouseDown);
            // 
            // CountDown
            // 
            this.CountDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountDown.Location = new System.Drawing.Point(12, 120);
            this.CountDown.Name = "CountDown";
            this.CountDown.Size = new System.Drawing.Size(319, 23);
            this.CountDown.TabIndex = 14;
            this.CountDown.Value = 50;
            this.CountDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Clock_MouseDown);
            // 
            // TimeHR
            // 
            this.TimeHR.BackColor = System.Drawing.Color.Black;
            this.TimeHR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TimeHR.Font = new System.Drawing.Font("Geometr212 BkCn BT", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeHR.ForeColor = System.Drawing.Color.LimeGreen;
            this.TimeHR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TimeHR.Location = new System.Drawing.Point(9, 9);
            this.TimeHR.Margin = new System.Windows.Forms.Padding(0);
            this.TimeHR.Name = "TimeHR";
            this.TimeHR.Size = new System.Drawing.Size(110, 119);
            this.TimeHR.TabIndex = 20;
            this.TimeHR.Text = "00";
            this.TimeHR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TimeHR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Clock_MouseDown);
            // 
            // colon
            // 
            this.colon.BackColor = System.Drawing.Color.Black;
            this.colon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colon.Font = new System.Drawing.Font("Geometr212 BkCn BT", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colon.ForeColor = System.Drawing.Color.LimeGreen;
            this.colon.Location = new System.Drawing.Point(119, 9);
            this.colon.Margin = new System.Windows.Forms.Padding(0);
            this.colon.Name = "colon";
            this.colon.Size = new System.Drawing.Size(27, 119);
            this.colon.TabIndex = 0;
            this.colon.Text = ":";
            this.colon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.colon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Clock_MouseDown);
            // 
            // TimeMIN
            // 
            this.TimeMIN.BackColor = System.Drawing.Color.Black;
            this.TimeMIN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TimeMIN.Font = new System.Drawing.Font("Geometr212 BkCn BT", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeMIN.ForeColor = System.Drawing.Color.LimeGreen;
            this.TimeMIN.Location = new System.Drawing.Point(146, 9);
            this.TimeMIN.Margin = new System.Windows.Forms.Padding(0);
            this.TimeMIN.Name = "TimeMIN";
            this.TimeMIN.Size = new System.Drawing.Size(116, 119);
            this.TimeMIN.TabIndex = 22;
            this.TimeMIN.Text = "00";
            this.TimeMIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimeMIN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Clock_MouseDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.GreenYellow;
            this.checkBox1.Location = new System.Drawing.Point(12, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "on top";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Clock.Properties.Resources.alarm_light;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(264, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseHover);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Clock.Properties.Resources.x_light;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(306, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseHover);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(343, 155);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this._pm);
            this.Controls.Add(this.CountDown);
            this.Controls.Add(this.TimeMIN);
            this.Controls.Add(this.colon);
            this.Controls.Add(this.TimeHR);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clock";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Clock_FormClosing);
            this.Load += new System.EventHandler(this.Clock_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Clock_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label _pm;
        private System.Windows.Forms.ProgressBar CountDown;
        private System.Windows.Forms.Label TimeHR;
        private System.Windows.Forms.Label colon;
        private System.Windows.Forms.Label TimeMIN;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

