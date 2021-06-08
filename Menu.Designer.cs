
namespace TRexGame
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.playLbl = new System.Windows.Forms.Label();
            this.controlsLbl = new System.Windows.Forms.Label();
            this.bestScoreLbl = new System.Windows.Forms.Label();
            this.exitLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // playLbl
            // 
            this.playLbl.AutoSize = true;
            this.playLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playLbl.Location = new System.Drawing.Point(112, 164);
            this.playLbl.Name = "playLbl";
            this.playLbl.Size = new System.Drawing.Size(121, 55);
            this.playLbl.TabIndex = 0;
            this.playLbl.Text = "Play";
            this.playLbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playLbl_MouseClick);
            this.playLbl.MouseEnter += new System.EventHandler(this.playLbl_MouseEnter);
            this.playLbl.MouseLeave += new System.EventHandler(this.playLbl_MouseLeave);
            // 
            // controlsLbl
            // 
            this.controlsLbl.AutoSize = true;
            this.controlsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlsLbl.Location = new System.Drawing.Point(89, 350);
            this.controlsLbl.Name = "controlsLbl";
            this.controlsLbl.Size = new System.Drawing.Size(211, 55);
            this.controlsLbl.TabIndex = 0;
            this.controlsLbl.Text = "Controls";
            this.controlsLbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.controlsLbl_MouseClick);
            this.controlsLbl.MouseEnter += new System.EventHandler(this.controlsLbl_MouseEnter);
            this.controlsLbl.MouseLeave += new System.EventHandler(this.controlsLbl_MouseLeave);
            // 
            // bestScoreLbl
            // 
            this.bestScoreLbl.AutoSize = true;
            this.bestScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestScoreLbl.Location = new System.Drawing.Point(355, 164);
            this.bestScoreLbl.Name = "bestScoreLbl";
            this.bestScoreLbl.Size = new System.Drawing.Size(269, 55);
            this.bestScoreLbl.TabIndex = 0;
            this.bestScoreLbl.Text = "Best Score";
            this.bestScoreLbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bestScoreLbl_MouseClick);
            this.bestScoreLbl.MouseEnter += new System.EventHandler(this.bestScoreLbl_MouseEnter);
            this.bestScoreLbl.MouseLeave += new System.EventHandler(this.bestScoreLbl_MouseLeave);
            // 
            // exitLbl
            // 
            this.exitLbl.AutoSize = true;
            this.exitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLbl.Location = new System.Drawing.Point(448, 350);
            this.exitLbl.Name = "exitLbl";
            this.exitLbl.Size = new System.Drawing.Size(107, 55);
            this.exitLbl.TabIndex = 0;
            this.exitLbl.Text = "Exit";
            this.exitLbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitLbl_MouseClick);
            this.exitLbl.MouseEnter += new System.EventHandler(this.exitLbl_MouseEnter);
            this.exitLbl.MouseLeave += new System.EventHandler(this.exitLbl_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TRexGame.Properties.Resources.running;
            this.pictureBox1.Location = new System.Drawing.Point(326, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(684, 481);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitLbl);
            this.Controls.Add(this.bestScoreLbl);
            this.Controls.Add(this.controlsLbl);
            this.Controls.Add(this.playLbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playLbl;
        private System.Windows.Forms.Label controlsLbl;
        private System.Windows.Forms.Label bestScoreLbl;
        private System.Windows.Forms.Label exitLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}