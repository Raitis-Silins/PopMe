
namespace PopMe
{
    partial class Easy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Easy));
            this.EdgarFace1 = new System.Windows.Forms.PictureBox();
            this.EdgarFace3 = new System.Windows.Forms.PictureBox();
            this.EdgarFace2 = new System.Windows.Forms.PictureBox();
            this.EdgarFace4 = new System.Windows.Forms.PictureBox();
            this.bomb = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EdgarFace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgarFace3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgarFace2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgarFace4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).BeginInit();
            this.SuspendLayout();
            // 
            // EdgarFace1
            // 
            this.EdgarFace1.BackColor = System.Drawing.Color.Transparent;
            this.EdgarFace1.Image = global::PopMe.Properties.Resources.edgaraSeja;
            this.EdgarFace1.Location = new System.Drawing.Point(90, 71);
            this.EdgarFace1.Name = "EdgarFace1";
            this.EdgarFace1.Size = new System.Drawing.Size(69, 91);
            this.EdgarFace1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.EdgarFace1.TabIndex = 0;
            this.EdgarFace1.TabStop = false;
            this.EdgarFace1.Tag = "face";
            this.EdgarFace1.Click += new System.EventHandler(this.PopFace);
            // 
            // EdgarFace3
            // 
            this.EdgarFace3.BackColor = System.Drawing.Color.Transparent;
            this.EdgarFace3.Image = global::PopMe.Properties.Resources.edgaraSeja;
            this.EdgarFace3.Location = new System.Drawing.Point(12, 633);
            this.EdgarFace3.Name = "EdgarFace3";
            this.EdgarFace3.Size = new System.Drawing.Size(69, 91);
            this.EdgarFace3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.EdgarFace3.TabIndex = 0;
            this.EdgarFace3.TabStop = false;
            this.EdgarFace3.Tag = "face";
            this.EdgarFace3.Click += new System.EventHandler(this.PopFace);
            // 
            // EdgarFace2
            // 
            this.EdgarFace2.BackColor = System.Drawing.Color.Transparent;
            this.EdgarFace2.Image = global::PopMe.Properties.Resources.edgaraSeja;
            this.EdgarFace2.Location = new System.Drawing.Point(426, 269);
            this.EdgarFace2.Name = "EdgarFace2";
            this.EdgarFace2.Size = new System.Drawing.Size(69, 91);
            this.EdgarFace2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.EdgarFace2.TabIndex = 0;
            this.EdgarFace2.TabStop = false;
            this.EdgarFace2.Tag = "face";
            this.EdgarFace2.Click += new System.EventHandler(this.PopFace);
            // 
            // EdgarFace4
            // 
            this.EdgarFace4.BackColor = System.Drawing.Color.Transparent;
            this.EdgarFace4.Image = global::PopMe.Properties.Resources.edgaraSeja;
            this.EdgarFace4.Location = new System.Drawing.Point(354, 673);
            this.EdgarFace4.Name = "EdgarFace4";
            this.EdgarFace4.Size = new System.Drawing.Size(69, 91);
            this.EdgarFace4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.EdgarFace4.TabIndex = 0;
            this.EdgarFace4.TabStop = false;
            this.EdgarFace4.Tag = "face";
            this.EdgarFace4.Click += new System.EventHandler(this.PopFace);
            // 
            // bomb
            // 
            this.bomb.BackColor = System.Drawing.Color.Transparent;
            this.bomb.Image = global::PopMe.Properties.Resources.bomb;
            this.bomb.Location = new System.Drawing.Point(209, 334);
            this.bomb.Name = "bomb";
            this.bomb.Size = new System.Drawing.Size(85, 135);
            this.bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bomb.TabIndex = 1;
            this.bomb.TabStop = false;
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
            this.txtScore.Location = new System.Drawing.Point(7, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(83, 25);
            this.txtScore.TabIndex = 2;
            this.txtScore.Tag = "";
            this.txtScore.Text = "Score: 0";
            // 
            // Easy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 870);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.bomb);
            this.Controls.Add(this.EdgarFace4);
            this.Controls.Add(this.EdgarFace2);
            this.Controls.Add(this.EdgarFace3);
            this.Controls.Add(this.EdgarFace1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Easy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POP ME";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.EdgarFace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgarFace3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgarFace2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgarFace4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox EdgarFace1;
        private System.Windows.Forms.PictureBox EdgarFace3;
        private System.Windows.Forms.PictureBox EdgarFace2;
        private System.Windows.Forms.PictureBox EdgarFace4;
        private System.Windows.Forms.PictureBox bomb;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label txtScore;
    }
}