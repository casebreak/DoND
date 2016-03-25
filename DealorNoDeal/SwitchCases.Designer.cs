namespace DealorNoDeal
{
    partial class SwitchCases
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
            this.logo_pb = new System.Windows.Forms.PictureBox();
            this.lastRound_lbl = new System.Windows.Forms.Label();
            this.noSwitch_button = new System.Windows.Forms.Button();
            this.switch_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // logo_pb
            // 
            this.logo_pb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo_pb.Image = global::DealorNoDeal.Properties.Resources.Dond_logo;
            this.logo_pb.Location = new System.Drawing.Point(13, 12);
            this.logo_pb.Name = "logo_pb";
            this.logo_pb.Size = new System.Drawing.Size(597, 78);
            this.logo_pb.TabIndex = 5;
            this.logo_pb.TabStop = false;
            // 
            // lastRound_lbl
            // 
            this.lastRound_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lastRound_lbl.AutoSize = true;
            this.lastRound_lbl.BackColor = System.Drawing.Color.Khaki;
            this.lastRound_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastRound_lbl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastRound_lbl.Location = new System.Drawing.Point(52, 136);
            this.lastRound_lbl.Name = "lastRound_lbl";
            this.lastRound_lbl.Padding = new System.Windows.Forms.Padding(7);
            this.lastRound_lbl.Size = new System.Drawing.Size(519, 121);
            this.lastRound_lbl.TabIndex = 6;
            this.lastRound_lbl.Text = "You made it to the final round! You have one choice left to make...\r\n\r\nWill you s" +
    "tick with your gut and open your case?\r\n\r\nOr do you want to switch cases to the " +
    "one available?";
            this.lastRound_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noSwitch_button
            // 
            this.noSwitch_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.noSwitch_button.BackColor = System.Drawing.Color.Crimson;
            this.noSwitch_button.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noSwitch_button.ForeColor = System.Drawing.Color.Black;
            this.noSwitch_button.Location = new System.Drawing.Point(354, 303);
            this.noSwitch_button.Name = "noSwitch_button";
            this.noSwitch_button.Size = new System.Drawing.Size(203, 63);
            this.noSwitch_button.TabIndex = 8;
            this.noSwitch_button.Text = "NO!";
            this.noSwitch_button.UseVisualStyleBackColor = false;
            this.noSwitch_button.Click += new System.EventHandler(this.noSwitch_button_Click);
            // 
            // switch_button
            // 
            this.switch_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.switch_button.BackColor = System.Drawing.Color.LawnGreen;
            this.switch_button.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_button.Location = new System.Drawing.Point(62, 303);
            this.switch_button.Name = "switch_button";
            this.switch_button.Size = new System.Drawing.Size(203, 63);
            this.switch_button.TabIndex = 7;
            this.switch_button.Text = "SWITCH";
            this.switch_button.UseVisualStyleBackColor = false;
            this.switch_button.Click += new System.EventHandler(this.switch_button_Click);
            // 
            // SwitchCases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 400);
            this.Controls.Add(this.noSwitch_button);
            this.Controls.Add(this.switch_button);
            this.Controls.Add(this.lastRound_lbl);
            this.Controls.Add(this.logo_pb);
            this.Location = new System.Drawing.Point(500, 210);
            this.Name = "SwitchCases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FINAL ROUND!";
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_pb;
        private System.Windows.Forms.Label lastRound_lbl;
        private System.Windows.Forms.Button noSwitch_button;
        private System.Windows.Forms.Button switch_button;
    }
}