namespace Game
{
    partial class IntroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroForm));
            this.Play_Btn = new System.Windows.Forms.Button();
            this.GameName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Play_Btn
            // 
            this.Play_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Play_Btn.BackgroundImage")));
            this.Play_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Play_Btn.Enabled = true;
            this.Play_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Play_Btn.FlatAppearance.BorderSize = 0;
            this.Play_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Play_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Play_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play_Btn.Location = new System.Drawing.Point(235, 138);
            this.Play_Btn.Name = "Play_Btn";
            this.Play_Btn.Size = new System.Drawing.Size(114, 41);
            this.Play_Btn.TabIndex = 10;
            this.Play_Btn.UseVisualStyleBackColor = true;
            this.Play_Btn.Click += new System.EventHandler(this.Play_Btn_Click);
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameName.ForeColor = System.Drawing.Color.DarkOrange;
            this.GameName.Location = new System.Drawing.Point(84, 9);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(426, 45);
            this.GameName.TabIndex = 11;
            this.GameName.Text = "WORLD OF TANCHIKI";
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(567, 191);
            this.Controls.Add(this.GameName);
            this.Controls.Add(this.Play_Btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IntroForm";
            this.Text = "IntroForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Play_Btn;
        private System.Windows.Forms.Label GameName;
    }
}