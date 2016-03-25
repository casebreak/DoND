namespace DealorNoDeal
{
    partial class DoND
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
            this.deal_button = new System.Windows.Forms.Button();
            this.noDeal_button = new System.Windows.Forms.Button();
            this.currentOfferNumber_lbl = new System.Windows.Forms.Label();
            this.currentOffer_lbl = new System.Windows.Forms.Label();
            this.logo_pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // deal_button
            // 
            this.deal_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deal_button.BackColor = System.Drawing.Color.LawnGreen;
            this.deal_button.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deal_button.Location = new System.Drawing.Point(60, 311);
            this.deal_button.Name = "deal_button";
            this.deal_button.Size = new System.Drawing.Size(203, 63);
            this.deal_button.TabIndex = 5;
            this.deal_button.Text = "DEAL";
            this.deal_button.UseVisualStyleBackColor = false;
            this.deal_button.Click += new System.EventHandler(this.deal_button_Click);
            // 
            // noDeal_button
            // 
            this.noDeal_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.noDeal_button.BackColor = System.Drawing.Color.Crimson;
            this.noDeal_button.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noDeal_button.ForeColor = System.Drawing.Color.Black;
            this.noDeal_button.Location = new System.Drawing.Point(352, 311);
            this.noDeal_button.Name = "noDeal_button";
            this.noDeal_button.Size = new System.Drawing.Size(203, 63);
            this.noDeal_button.TabIndex = 6;
            this.noDeal_button.Text = "NO DEAL";
            this.noDeal_button.UseVisualStyleBackColor = false;
            this.noDeal_button.Click += new System.EventHandler(this.noDeal_button_Click);
            // 
            // currentOfferNumber_lbl
            // 
            this.currentOfferNumber_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.currentOfferNumber_lbl.AutoSize = true;
            this.currentOfferNumber_lbl.BackColor = System.Drawing.Color.Gray;
            this.currentOfferNumber_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentOfferNumber_lbl.Font = new System.Drawing.Font("Razer Text Regular", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOfferNumber_lbl.ForeColor = System.Drawing.Color.Cyan;
            this.currentOfferNumber_lbl.Location = new System.Drawing.Point(161, 199);
            this.currentOfferNumber_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentOfferNumber_lbl.Name = "currentOfferNumber_lbl";
            this.currentOfferNumber_lbl.Size = new System.Drawing.Size(53, 60);
            this.currentOfferNumber_lbl.TabIndex = 102;
            this.currentOfferNumber_lbl.Text = "0";
            // 
            // currentOffer_lbl
            // 
            this.currentOffer_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.currentOffer_lbl.AutoSize = true;
            this.currentOffer_lbl.BackColor = System.Drawing.Color.Khaki;
            this.currentOffer_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentOffer_lbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOffer_lbl.Location = new System.Drawing.Point(161, 149);
            this.currentOffer_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentOffer_lbl.Name = "currentOffer_lbl";
            this.currentOffer_lbl.Size = new System.Drawing.Size(273, 50);
            this.currentOffer_lbl.TabIndex = 101;
            this.currentOffer_lbl.Text = "Banker\'s Offer : ";
            // 
            // logo_pb
            // 
            this.logo_pb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo_pb.Image = global::DealorNoDeal.Properties.Resources.Dond_logo;
            this.logo_pb.Location = new System.Drawing.Point(13, 12);
            this.logo_pb.Name = "logo_pb";
            this.logo_pb.Size = new System.Drawing.Size(597, 78);
            this.logo_pb.TabIndex = 4;
            this.logo_pb.TabStop = false;
            // 
            // DoND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 400);
            this.Controls.Add(this.currentOfferNumber_lbl);
            this.Controls.Add(this.currentOffer_lbl);
            this.Controls.Add(this.noDeal_button);
            this.Controls.Add(this.deal_button);
            this.Controls.Add(this.logo_pb);
            this.Location = new System.Drawing.Point(500, 210);
            this.Name = "DoND";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Deal or No Deal?";
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_pb;
        private System.Windows.Forms.Button deal_button;
        private System.Windows.Forms.Button noDeal_button;
        private System.Windows.Forms.Label currentOfferNumber_lbl;
        private System.Windows.Forms.Label currentOffer_lbl;
    }
}