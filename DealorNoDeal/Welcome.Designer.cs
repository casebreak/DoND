namespace DealorNoDeal
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.welcome_lbl = new System.Windows.Forms.Label();
            this.play_button = new System.Windows.Forms.Button();
            this.wexit_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.BackColor = System.Drawing.Color.Khaki;
            this.welcome_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.welcome_lbl.Font = new System.Drawing.Font("Razer Text Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_lbl.Location = new System.Drawing.Point(49, 130);
            this.welcome_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.welcome_lbl.Size = new System.Drawing.Size(1021, 460);
            this.welcome_lbl.TabIndex = 0;
            this.welcome_lbl.Text = resources.GetString("welcome_lbl.Text");
            this.welcome_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // play_button
            // 
            this.play_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.play_button.Font = new System.Drawing.Font("Razer Text Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_button.Location = new System.Drawing.Point(313, 620);
            this.play_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(181, 59);
            this.play_button.TabIndex = 1;
            this.play_button.Text = "Play";
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // wexit_button
            // 
            this.wexit_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wexit_button.Font = new System.Drawing.Font("Razer Text Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wexit_button.Location = new System.Drawing.Point(607, 620);
            this.wexit_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wexit_button.Name = "wexit_button";
            this.wexit_button.Size = new System.Drawing.Size(181, 59);
            this.wexit_button.TabIndex = 2;
            this.wexit_button.Text = "Exit";
            this.wexit_button.UseVisualStyleBackColor = true;
            this.wexit_button.Click += new System.EventHandler(this.wexit_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::DealorNoDeal.Properties.Resources.Dond_logo;
            this.pictureBox1.Location = new System.Drawing.Point(261, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(597, 78);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 715);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.wexit_button);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.welcome_lbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_lbl;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button wexit_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}