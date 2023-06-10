namespace Infection
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.menuLabel = new System.Windows.Forms.Label();
            this.Light = new System.Windows.Forms.Button();
            this.Dark = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.BackColor = System.Drawing.Color.Transparent;
            this.menuLabel.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold);
            this.menuLabel.ForeColor = System.Drawing.Color.Black;
            this.menuLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuLabel.Location = new System.Drawing.Point(144, 39);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(417, 40);
            this.menuLabel.TabIndex = 2;
            this.menuLabel.Text = "Оберіть колір теми програми";
            this.menuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Light
            // 
            this.Light.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Light.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.Light.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Light.Location = new System.Drawing.Point(151, 137);
            this.Light.Name = "Light";
            this.Light.Size = new System.Drawing.Size(153, 68);
            this.Light.TabIndex = 6;
            this.Light.Text = "Світла";
            this.Light.UseVisualStyleBackColor = false;
            this.Light.Click += new System.EventHandler(this.Light_Click);
            // 
            // Dark
            // 
            this.Dark.BackColor = System.Drawing.Color.LightSlateGray;
            this.Dark.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.Dark.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dark.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Dark.Location = new System.Drawing.Point(408, 137);
            this.Dark.Name = "Dark";
            this.Dark.Size = new System.Drawing.Size(153, 68);
            this.Dark.TabIndex = 7;
            this.Dark.Text = "Темна";
            this.Dark.UseVisualStyleBackColor = false;
            this.Dark.Click += new System.EventHandler(this.Dark_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(294, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(692, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dark);
            this.Controls.Add(this.Light);
            this.Controls.Add(this.menuLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Infection";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Button Light;
        private System.Windows.Forms.Button Dark;
        private System.Windows.Forms.Button button1;
    }
}