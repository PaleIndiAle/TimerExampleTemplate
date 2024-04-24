namespace TimerExample
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.counterLabel = new System.Windows.Forms.Label();
            this.debugLabel2 = new System.Windows.Forms.Label();
            this.debugLabel1 = new System.Windows.Forms.Label();
            this.colourLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeOutput = new System.Windows.Forms.Label();
            this.countTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, -1);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(258, 36);
            this.titleLabel.TabIndex = 16;
            this.titleLabel.Text = "Timer Examples";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(96, 203);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(68, 34);
            this.startButton.TabIndex = 20;
            this.startButton.Text = "Start";
            this.startButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLabel.ForeColor = System.Drawing.Color.White;
            this.counterLabel.Location = new System.Drawing.Point(159, 59);
            this.counterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(20, 24);
            this.counterLabel.TabIndex = 19;
            this.counterLabel.Text = "0";
            // 
            // debugLabel2
            // 
            this.debugLabel2.AutoSize = true;
            this.debugLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugLabel2.ForeColor = System.Drawing.Color.White;
            this.debugLabel2.Location = new System.Drawing.Point(85, 101);
            this.debugLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.debugLabel2.Name = "debugLabel2";
            this.debugLabel2.Size = new System.Drawing.Size(68, 24);
            this.debugLabel2.TabIndex = 18;
            this.debugLabel2.Text = "colour:";
            // 
            // debugLabel1
            // 
            this.debugLabel1.AutoSize = true;
            this.debugLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugLabel1.ForeColor = System.Drawing.Color.White;
            this.debugLabel1.Location = new System.Drawing.Point(92, 59);
            this.debugLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.debugLabel1.Name = "debugLabel1";
            this.debugLabel1.Size = new System.Drawing.Size(67, 24);
            this.debugLabel1.TabIndex = 17;
            this.debugLabel1.Text = "count: ";
            // 
            // colourLabel
            // 
            this.colourLabel.BackColor = System.Drawing.Color.White;
            this.colourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colourLabel.ForeColor = System.Drawing.Color.White;
            this.colourLabel.Location = new System.Drawing.Point(159, 101);
            this.colourLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(20, 24);
            this.colourLabel.TabIndex = 21;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(31, 144);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(122, 24);
            this.timeLabel.TabIndex = 22;
            this.timeLabel.Text = "elapsed time:";
            // 
            // timeOutput
            // 
            this.timeOutput.AutoSize = true;
            this.timeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOutput.ForeColor = System.Drawing.Color.White;
            this.timeOutput.Location = new System.Drawing.Point(159, 144);
            this.timeOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeOutput.Name = "timeOutput";
            this.timeOutput.Size = new System.Drawing.Size(20, 24);
            this.timeOutput.TabIndex = 23;
            this.timeOutput.Text = "0";
            // 
            // countTimer
            // 
            this.countTimer.Interval = 1000;
            this.countTimer.Tick += new System.EventHandler(this.countTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(255, 286);
            this.Controls.Add(this.timeOutput);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.colourLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.debugLabel2);
            this.Controls.Add(this.debugLabel1);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.Label debugLabel2;
        private System.Windows.Forms.Label debugLabel1;
        private System.Windows.Forms.Label colourLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeOutput;
        private System.Windows.Forms.Timer countTimer;
    }
}

