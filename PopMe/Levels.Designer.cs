
namespace PopMe
{
    partial class Levels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Levels));
            this.EasyLevel = new System.Windows.Forms.Button();
            this.HardLevel = new System.Windows.Forms.Button();
            this.MediumLevel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EasyLevel
            // 
            this.EasyLevel.BackColor = System.Drawing.Color.Black;
            this.EasyLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EasyLevel.FlatAppearance.BorderSize = 0;
            this.EasyLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EasyLevel.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyLevel.ForeColor = System.Drawing.Color.White;
            this.EasyLevel.Location = new System.Drawing.Point(119, 262);
            this.EasyLevel.Name = "EasyLevel";
            this.EasyLevel.Size = new System.Drawing.Size(279, 112);
            this.EasyLevel.TabIndex = 0;
            this.EasyLevel.Text = "Easy";
            this.EasyLevel.UseVisualStyleBackColor = false;
            this.EasyLevel.Click += new System.EventHandler(this.EasyLevel_Click);
            // 
            // HardLevel
            // 
            this.HardLevel.BackColor = System.Drawing.Color.Black;
            this.HardLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HardLevel.FlatAppearance.BorderSize = 0;
            this.HardLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HardLevel.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardLevel.ForeColor = System.Drawing.Color.White;
            this.HardLevel.Location = new System.Drawing.Point(119, 560);
            this.HardLevel.Name = "HardLevel";
            this.HardLevel.Size = new System.Drawing.Size(279, 112);
            this.HardLevel.TabIndex = 1;
            this.HardLevel.Text = "Hard";
            this.HardLevel.UseVisualStyleBackColor = false;
            this.HardLevel.Click += new System.EventHandler(this.HardLevel_Click);
            // 
            // MediumLevel
            // 
            this.MediumLevel.BackColor = System.Drawing.Color.Black;
            this.MediumLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MediumLevel.FlatAppearance.BorderSize = 0;
            this.MediumLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MediumLevel.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumLevel.ForeColor = System.Drawing.Color.White;
            this.MediumLevel.Location = new System.Drawing.Point(119, 404);
            this.MediumLevel.Name = "MediumLevel";
            this.MediumLevel.Size = new System.Drawing.Size(279, 112);
            this.MediumLevel.TabIndex = 2;
            this.MediumLevel.Text = "Medium";
            this.MediumLevel.UseVisualStyleBackColor = false;
            this.MediumLevel.Click += new System.EventHandler(this.MediumLevel_Click);
            // 
            // Levels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 870);
            this.Controls.Add(this.MediumLevel);
            this.Controls.Add(this.HardLevel);
            this.Controls.Add(this.EasyLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Levels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POP ME";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EasyLevel;
        private System.Windows.Forms.Button HardLevel;
        private System.Windows.Forms.Button MediumLevel;
    }
}