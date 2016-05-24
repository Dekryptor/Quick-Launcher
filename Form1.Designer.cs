namespace BetterLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.altis = new System.Windows.Forms.PictureBox();
            this.ts = new System.Windows.Forms.PictureBox();
            this.site = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.altis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.site)).BeginInit();
            this.SuspendLayout();
            // 
            // altis
            // 
            this.altis.Location = new System.Drawing.Point(12, 72);
            this.altis.Name = "altis";
            this.altis.Size = new System.Drawing.Size(464, 81);
            this.altis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.altis.TabIndex = 0;
            this.altis.TabStop = false;
            this.altis.DoubleClick += new System.EventHandler(this.clickHandler);
            // 
            // ts
            // 
            this.ts.Location = new System.Drawing.Point(12, 159);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(464, 81);
            this.ts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ts.TabIndex = 1;
            this.ts.TabStop = false;
            this.ts.DoubleClick += new System.EventHandler(this.clickHandler);
            // 
            // site
            // 
            this.site.Location = new System.Drawing.Point(12, 246);
            this.site.Name = "site";
            this.site.Size = new System.Drawing.Size(464, 81);
            this.site.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.site.TabIndex = 2;
            this.site.TabStop = false;
            this.site.DoubleClick += new System.EventHandler(this.clickHandler);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 338);
            this.Controls.Add(this.site);
            this.Controls.Add(this.ts);
            this.Controls.Add(this.altis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Easy\'s Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.altis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.site)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox altis;
        private System.Windows.Forms.PictureBox ts;
        private System.Windows.Forms.PictureBox site;
    }
}

