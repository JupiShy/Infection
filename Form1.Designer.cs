namespace Infection
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
            this.menuLabel = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.Theme = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.underTheme = new System.Windows.Forms.Label();
            this.zagolovok = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuLabel
            // 
            resources.ApplyResources(this.menuLabel, "menuLabel");
            this.menuLabel.BackColor = System.Drawing.Color.Transparent;
            this.menuLabel.ForeColor = System.Drawing.Color.Black;
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Start
            // 
            resources.ApplyResources(this.Start, "Start");
            this.Start.Name = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Info
            // 
            resources.ApplyResources(this.Info, "Info");
            this.Info.Name = "Info";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.button2_Click);
            // 
            // Theme
            // 
            resources.ApplyResources(this.Theme, "Theme");
            this.Theme.Name = "Theme";
            this.Theme.UseVisualStyleBackColor = true;
            this.Theme.Click += new System.EventHandler(this.Theme_Click);
            // 
            // Exit
            // 
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.Name = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // underTheme
            // 
            resources.ApplyResources(this.underTheme, "underTheme");
            this.underTheme.BackColor = System.Drawing.Color.Transparent;
            this.underTheme.ForeColor = System.Drawing.Color.Black;
            this.underTheme.Name = "underTheme";
            this.underTheme.Click += new System.EventHandler(this.label2_Click);
            // 
            // zagolovok
            // 
            this.zagolovok.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.zagolovok, "zagolovok");
            this.zagolovok.ForeColor = System.Drawing.Color.Black;
            this.zagolovok.Name = "zagolovok";
            this.zagolovok.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zagolovok);
            this.Controls.Add(this.underTheme);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Theme);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.menuLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Button Theme;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label underTheme;
        private System.Windows.Forms.Label zagolovok;
        private System.Windows.Forms.Label label1;
    }
}

