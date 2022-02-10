
namespace PopMe
{
    partial class Medium
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medium));
            this.briedisSeja1 = new System.Windows.Forms.PictureBox();
            this.briedisSeja2 = new System.Windows.Forms.PictureBox();
            this.briedisSeja3 = new System.Windows.Forms.PictureBox();
            this.bomb = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.rotate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.briedisSeja1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.briedisSeja2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.briedisSeja3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).BeginInit();
            this.SuspendLayout();
            // 
            // briedisSeja1
            // 
            this.briedisSeja1.BackColor = System.Drawing.Color.Transparent;
            this.briedisSeja1.Image = global::PopMe.Properties.Resources.briedisSeja1;
            this.briedisSeja1.Location = new System.Drawing.Point(48, 211);
            this.briedisSeja1.Name = "briedisSeja1";
            this.briedisSeja1.Size = new System.Drawing.Size(90, 115);
            this.briedisSeja1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.briedisSeja1.TabIndex = 0;
            this.briedisSeja1.TabStop = false;
            this.briedisSeja1.Tag = "face";
            this.briedisSeja1.Click += new System.EventHandler(this.PopFace);
            this.briedisSeja1.MouseEnter += new System.EventHandler(this.briedisSeja1_MouseEnter);
            this.briedisSeja1.MouseLeave += new System.EventHandler(this.briedisSeja1_MouseLeave);
            // 
            // briedisSeja2
            // 
            this.briedisSeja2.BackColor = System.Drawing.Color.Transparent;
            this.briedisSeja2.Image = global::PopMe.Properties.Resources.briedisSeja1;
            this.briedisSeja2.Location = new System.Drawing.Point(275, 272);
            this.briedisSeja2.Name = "briedisSeja2";
            this.briedisSeja2.Size = new System.Drawing.Size(90, 115);
            this.briedisSeja2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.briedisSeja2.TabIndex = 0;
            this.briedisSeja2.TabStop = false;
            this.briedisSeja2.Tag = "face";
            this.briedisSeja2.Click += new System.EventHandler(this.PopFace);
            // 
            // briedisSeja3
            // 
            this.briedisSeja3.BackColor = System.Drawing.Color.Transparent;
            this.briedisSeja3.Image = global::PopMe.Properties.Resources.briedisSeja1;
            this.briedisSeja3.Location = new System.Drawing.Point(84, 440);
            this.briedisSeja3.Name = "briedisSeja3";
            this.briedisSeja3.Size = new System.Drawing.Size(90, 115);
            this.briedisSeja3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.briedisSeja3.TabIndex = 0;
            this.briedisSeja3.TabStop = false;
            this.briedisSeja3.Tag = "face";
            this.briedisSeja3.Click += new System.EventHandler(this.PopFace);
            // 
            // bomb
            // 
            this.bomb.BackColor = System.Drawing.Color.Transparent;
            this.bomb.Image = global::PopMe.Properties.Resources.bomb;
            this.bomb.Location = new System.Drawing.Point(176, 94);
            this.bomb.Name = "bomb";
            this.bomb.Size = new System.Drawing.Size(85, 135);
            this.bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bomb.TabIndex = 1;
            this.bomb.TabStop = false;
            this.bomb.Tag = "bomb";
            this.bomb.Click += new System.EventHandler(this.Boom);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 50;
            this.gameTimer.Tick += new System.EventHandler(this.MainTimer);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(12, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(83, 25);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score: 0";
            // 
            // rotate
            // 
            this.rotate.Tick += new System.EventHandler(this.rotationTimer);
            // 
            // Medium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 870);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.bomb);
            this.Controls.Add(this.briedisSeja3);
            this.Controls.Add(this.briedisSeja2);
            this.Controls.Add(this.briedisSeja1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Medium";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POP ME";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.briedisSeja1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.briedisSeja2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.briedisSeja3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox briedisSeja1;
        private System.Windows.Forms.PictureBox briedisSeja2;
        private System.Windows.Forms.PictureBox briedisSeja3;
        private System.Windows.Forms.PictureBox bomb;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer rotate;
    }
}