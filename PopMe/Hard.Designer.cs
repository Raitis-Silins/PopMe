
namespace PopMe
{
    partial class Hard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hard));
            this.sandrisSeja3 = new System.Windows.Forms.PictureBox();
            this.sandrisSeja1 = new System.Windows.Forms.PictureBox();
            this.sandrisSeja2 = new System.Windows.Forms.PictureBox();
            this.bomb = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.rotate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sandrisSeja3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sandrisSeja1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sandrisSeja2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).BeginInit();
            this.SuspendLayout();
            // 
            // sandrisSeja3
            // 
            this.sandrisSeja3.BackColor = System.Drawing.Color.Transparent;
            this.sandrisSeja3.Image = global::PopMe.Properties.Resources.sandrisSeja;
            this.sandrisSeja3.Location = new System.Drawing.Point(221, 254);
            this.sandrisSeja3.Name = "sandrisSeja3";
            this.sandrisSeja3.Size = new System.Drawing.Size(95, 128);
            this.sandrisSeja3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sandrisSeja3.TabIndex = 0;
            this.sandrisSeja3.TabStop = false;
            this.sandrisSeja3.Tag = "face";
            this.sandrisSeja3.Click += new System.EventHandler(this.PopFace);
            // 
            // sandrisSeja1
            // 
            this.sandrisSeja1.BackColor = System.Drawing.Color.Transparent;
            this.sandrisSeja1.Image = global::PopMe.Properties.Resources.sandrisSeja;
            this.sandrisSeja1.Location = new System.Drawing.Point(12, 439);
            this.sandrisSeja1.Name = "sandrisSeja1";
            this.sandrisSeja1.Size = new System.Drawing.Size(95, 128);
            this.sandrisSeja1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sandrisSeja1.TabIndex = 0;
            this.sandrisSeja1.TabStop = false;
            this.sandrisSeja1.Tag = "face";
            this.sandrisSeja1.Click += new System.EventHandler(this.PopFace);
            // 
            // sandrisSeja2
            // 
            this.sandrisSeja2.BackColor = System.Drawing.Color.Transparent;
            this.sandrisSeja2.Image = global::PopMe.Properties.Resources.sandrisSeja21;
            this.sandrisSeja2.Location = new System.Drawing.Point(420, 464);
            this.sandrisSeja2.Name = "sandrisSeja2";
            this.sandrisSeja2.Size = new System.Drawing.Size(66, 90);
            this.sandrisSeja2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sandrisSeja2.TabIndex = 0;
            this.sandrisSeja2.TabStop = false;
            this.sandrisSeja2.Tag = "face";
            this.sandrisSeja2.Click += new System.EventHandler(this.PopFace);
            this.sandrisSeja2.MouseEnter += new System.EventHandler(this.sandrisSeja2_MouseEnter);
            this.sandrisSeja2.MouseLeave += new System.EventHandler(this.sandrisSeja2_MouseLeave);
            // 
            // bomb
            // 
            this.bomb.BackColor = System.Drawing.Color.Transparent;
            this.bomb.Image = global::PopMe.Properties.Resources.bomb;
            this.bomb.Location = new System.Drawing.Point(221, 606);
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
            this.gameTimer.Interval = 20;
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
            this.txtScore.Text = "Score: 0";
            // 
            // rotate
            // 
            this.rotate.Tick += new System.EventHandler(this.rotationTimer);
            // 
            // Hard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 870);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.bomb);
            this.Controls.Add(this.sandrisSeja2);
            this.Controls.Add(this.sandrisSeja1);
            this.Controls.Add(this.sandrisSeja3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Hard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POP ME";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.sandrisSeja3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sandrisSeja1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sandrisSeja2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sandrisSeja3;
        private System.Windows.Forms.PictureBox sandrisSeja1;
        private System.Windows.Forms.PictureBox sandrisSeja2;
        private System.Windows.Forms.PictureBox bomb;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer rotate;
    }
}