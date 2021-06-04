
namespace EsiniBulOyunu
{
    partial class YeniOyunForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniOyunForm));
            this.gboSeviye = new System.Windows.Forms.GroupBox();
            this.rbZor = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbKolay = new System.Windows.Forms.RadioButton();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gboSeviye.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboSeviye
            // 
            this.gboSeviye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboSeviye.BackColor = System.Drawing.Color.Transparent;
            this.gboSeviye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gboSeviye.Controls.Add(this.rbZor);
            this.gboSeviye.Controls.Add(this.rbOrta);
            this.gboSeviye.Controls.Add(this.rbKolay);
            this.gboSeviye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gboSeviye.Location = new System.Drawing.Point(59, 49);
            this.gboSeviye.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gboSeviye.Name = "gboSeviye";
            this.gboSeviye.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gboSeviye.Size = new System.Drawing.Size(236, 274);
            this.gboSeviye.TabIndex = 0;
            this.gboSeviye.TabStop = false;
            this.gboSeviye.Text = "Zorluk Seviyesi";
            // 
            // rbZor
            // 
            this.rbZor.AutoSize = true;
            this.rbZor.Location = new System.Drawing.Point(34, 202);
            this.rbZor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbZor.Name = "rbZor";
            this.rbZor.Size = new System.Drawing.Size(145, 33);
            this.rbZor.TabIndex = 3;
            this.rbZor.TabStop = true;
            this.rbZor.Text = "Zor (8 x 8)";
            this.rbZor.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(34, 135);
            this.rbOrta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(155, 33);
            this.rbOrta.TabIndex = 2;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "Orta (6 x 6)";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbKolay
            // 
            this.rbKolay.AutoSize = true;
            this.rbKolay.Location = new System.Drawing.Point(34, 68);
            this.rbKolay.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbKolay.Name = "rbKolay";
            this.rbKolay.Size = new System.Drawing.Size(169, 33);
            this.rbKolay.TabIndex = 1;
            this.rbKolay.TabStop = true;
            this.rbKolay.Text = "Kolay (4 x 4)";
            this.rbKolay.UseVisualStyleBackColor = true;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBaslat.BackColor = System.Drawing.Color.IndianRed;
            this.btnBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaslat.Location = new System.Drawing.Point(45, 337);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(267, 45);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "OYUNU BAŞLAT";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(45, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "OYUNDAN ÇIK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YeniOyunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(356, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.gboSeviye);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "YeniOyunForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eşini Bul";
            this.gboSeviye.ResumeLayout(false);
            this.gboSeviye.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboSeviye;
        private System.Windows.Forms.RadioButton rbZor;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbKolay;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button button1;
    }
}