namespace Clock
{
    partial class AlarmSet
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
            this.label1 = new System.Windows.Forms.Label();
            this.SET = new System.Windows.Forms.Label();
            this.AlarmTime = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set Alarm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // SET
            // 
            this.SET.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SET.AutoSize = true;
            this.SET.Font = new System.Drawing.Font("Geometr212 BkCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SET.ForeColor = System.Drawing.Color.PaleGreen;
            this.SET.Location = new System.Drawing.Point(176, 71);
            this.SET.Name = "SET";
            this.SET.Size = new System.Drawing.Size(57, 26);
            this.SET.TabIndex = 5;
            this.SET.Text = "SET";
            this.SET.Click += new System.EventHandler(this.SET_Click);
            // 
            // AlarmTime
            // 
            this.AlarmTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AlarmTime.CustomFormat = "hh:mm:t";
            this.AlarmTime.Font = new System.Drawing.Font("Geometr212 BkCn BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AlarmTime.Location = new System.Drawing.Point(12, 51);
            this.AlarmTime.Name = "AlarmTime";
            this.AlarmTime.ShowUpDown = true;
            this.AlarmTime.Size = new System.Drawing.Size(152, 51);
            this.AlarmTime.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AlarmSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(245, 114);
            this.Controls.Add(this.AlarmTime);
            this.Controls.Add(this.SET);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlarmSet";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SET;
        private System.Windows.Forms.DateTimePicker AlarmTime;
        private System.Windows.Forms.Timer timer1;
    }
}