
namespace projectgomoku
{
    partial class winner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winner));
            this.playagainbut = new System.Windows.Forms.Button();
            this.exitbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playagainbut
            // 
            this.playagainbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playagainbut.Location = new System.Drawing.Point(37, 91);
            this.playagainbut.Name = "playagainbut";
            this.playagainbut.Size = new System.Drawing.Size(130, 58);
            this.playagainbut.TabIndex = 1;
            this.playagainbut.Text = "PLAY AGAIN!";
            this.playagainbut.UseVisualStyleBackColor = true;
            this.playagainbut.Click += new System.EventHandler(this.playagainbut_Click);
            // 
            // exitbut
            // 
            this.exitbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbut.Location = new System.Drawing.Point(245, 91);
            this.exitbut.Name = "exitbut";
            this.exitbut.Size = new System.Drawing.Size(130, 58);
            this.exitbut.TabIndex = 2;
            this.exitbut.Text = "EXIT";
            this.exitbut.UseVisualStyleBackColor = true;
            this.exitbut.Click += new System.EventHandler(this.exitbut_Click);
            // 
            // winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(439, 250);
            this.Controls.Add(this.exitbut);
            this.Controls.Add(this.playagainbut);
            this.Name = "winner";
            this.Text = "Congratulations!";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button playagainbut;
        private System.Windows.Forms.Button exitbut;
    }
}