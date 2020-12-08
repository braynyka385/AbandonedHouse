namespace AbandonedHouse
{
    partial class Form1
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.yellowTextLabel = new System.Windows.Forms.Label();
            this.greenTextLabel = new System.Windows.Forms.Label();
            this.blueTextLabel = new System.Windows.Forms.Label();
            this.redTextLabel = new System.Windows.Forms.Label();
            this.yellowButtonLabel = new System.Windows.Forms.Label();
            this.greenButtonLabel = new System.Windows.Forms.Label();
            this.blueButtonLabel = new System.Windows.Forms.Label();
            this.redButtonLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(13, 13);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(460, 224);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "You are at the door to an abandoned house. There is a window to your left. You fe" +
    "el a radiant energy.";
            // 
            // yellowTextLabel
            // 
            this.yellowTextLabel.AutoSize = true;
            this.yellowTextLabel.ForeColor = System.Drawing.Color.White;
            this.yellowTextLabel.Location = new System.Drawing.Point(66, 419);
            this.yellowTextLabel.Name = "yellowTextLabel";
            this.yellowTextLabel.Size = new System.Drawing.Size(37, 13);
            this.yellowTextLabel.TabIndex = 6;
            this.yellowTextLabel.Text = "Leave";
            // 
            // greenTextLabel
            // 
            this.greenTextLabel.AutoSize = true;
            this.greenTextLabel.ForeColor = System.Drawing.Color.White;
            this.greenTextLabel.Location = new System.Drawing.Point(66, 373);
            this.greenTextLabel.Name = "greenTextLabel";
            this.greenTextLabel.Size = new System.Drawing.Size(106, 13);
            this.greenTextLabel.TabIndex = 7;
            this.greenTextLabel.Text = "Look for a back door";
            // 
            // blueTextLabel
            // 
            this.blueTextLabel.AutoSize = true;
            this.blueTextLabel.ForeColor = System.Drawing.Color.White;
            this.blueTextLabel.Location = new System.Drawing.Point(66, 328);
            this.blueTextLabel.Name = "blueTextLabel";
            this.blueTextLabel.Size = new System.Drawing.Size(110, 13);
            this.blueTextLabel.TabIndex = 8;
            this.blueTextLabel.Text = "Jump through window";
            // 
            // redTextLabel
            // 
            this.redTextLabel.AutoSize = true;
            this.redTextLabel.ForeColor = System.Drawing.Color.White;
            this.redTextLabel.Location = new System.Drawing.Point(66, 286);
            this.redTextLabel.Name = "redTextLabel";
            this.redTextLabel.Size = new System.Drawing.Size(74, 13);
            this.redTextLabel.TabIndex = 9;
            this.redTextLabel.Text = "Enter the door";
            // 
            // yellowButtonLabel
            // 
            this.yellowButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.yellowButtonLabel.Image = global::AbandonedHouse.Properties.Resources.yellow_50x50;
            this.yellowButtonLabel.Location = new System.Drawing.Point(3, 404);
            this.yellowButtonLabel.Name = "yellowButtonLabel";
            this.yellowButtonLabel.Size = new System.Drawing.Size(73, 46);
            this.yellowButtonLabel.TabIndex = 5;
            // 
            // greenButtonLabel
            // 
            this.greenButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.greenButtonLabel.Image = global::AbandonedHouse.Properties.Resources.green_50x50;
            this.greenButtonLabel.Location = new System.Drawing.Point(3, 358);
            this.greenButtonLabel.Name = "greenButtonLabel";
            this.greenButtonLabel.Size = new System.Drawing.Size(73, 46);
            this.greenButtonLabel.TabIndex = 4;
            // 
            // blueButtonLabel
            // 
            this.blueButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.blueButtonLabel.Image = global::AbandonedHouse.Properties.Resources.blue_50x50;
            this.blueButtonLabel.Location = new System.Drawing.Point(3, 312);
            this.blueButtonLabel.Name = "blueButtonLabel";
            this.blueButtonLabel.Size = new System.Drawing.Size(73, 46);
            this.blueButtonLabel.TabIndex = 3;
            // 
            // redButtonLabel
            // 
            this.redButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.redButtonLabel.Image = global::AbandonedHouse.Properties.Resources.red_50x50;
            this.redButtonLabel.Location = new System.Drawing.Point(3, 265);
            this.redButtonLabel.Name = "redButtonLabel";
            this.redButtonLabel.Size = new System.Drawing.Size(73, 47);
            this.redButtonLabel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AbandonedHouse.Properties.Resources.maxresdefault;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(454, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 288);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.redTextLabel);
            this.Controls.Add(this.blueTextLabel);
            this.Controls.Add(this.greenTextLabel);
            this.Controls.Add(this.yellowTextLabel);
            this.Controls.Add(this.yellowButtonLabel);
            this.Controls.Add(this.greenButtonLabel);
            this.Controls.Add(this.blueButtonLabel);
            this.Controls.Add(this.redButtonLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label redButtonLabel;
        private System.Windows.Forms.Label blueButtonLabel;
        private System.Windows.Forms.Label greenButtonLabel;
        private System.Windows.Forms.Label yellowButtonLabel;
        private System.Windows.Forms.Label yellowTextLabel;
        private System.Windows.Forms.Label greenTextLabel;
        private System.Windows.Forms.Label blueTextLabel;
        private System.Windows.Forms.Label redTextLabel;
    }
}

