
namespace CourseworkForAri
{
    partial class settingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userModeButton = new System.Windows.Forms.RadioButton();
            this.psyhoModeButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lightThemeButton = new System.Windows.Forms.RadioButton();
            this.darkThemeButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.userModeButton);
            this.groupBox1.Controls.Add(this.psyhoModeButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим програми";
            // 
            // userModeButton
            // 
            this.userModeButton.AutoSize = true;
            this.userModeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.userModeButton.ForeColor = System.Drawing.Color.Red;
            this.userModeButton.Location = new System.Drawing.Point(144, 32);
            this.userModeButton.Name = "userModeButton";
            this.userModeButton.Size = new System.Drawing.Size(89, 18);
            this.userModeButton.TabIndex = 1;
            this.userModeButton.Text = "Користувач";
            this.userModeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userModeButton.UseVisualStyleBackColor = true;
            this.userModeButton.Click += new System.EventHandler(this.userModeButton_Click);
            // 
            // psyhoModeButton
            // 
            this.psyhoModeButton.AutoSize = true;
            this.psyhoModeButton.Checked = true;
            this.psyhoModeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.psyhoModeButton.ForeColor = System.Drawing.Color.Red;
            this.psyhoModeButton.Location = new System.Drawing.Point(16, 32);
            this.psyhoModeButton.Name = "psyhoModeButton";
            this.psyhoModeButton.Size = new System.Drawing.Size(79, 18);
            this.psyhoModeButton.TabIndex = 0;
            this.psyhoModeButton.TabStop = true;
            this.psyhoModeButton.Text = "Психолог";
            this.psyhoModeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.psyhoModeButton.UseVisualStyleBackColor = false;
            this.psyhoModeButton.Click += new System.EventHandler(this.psyhoModeButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lightThemeButton);
            this.groupBox2.Controls.Add(this.darkThemeButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(0, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кольорова тема";
            // 
            // lightThemeButton
            // 
            this.lightThemeButton.AutoSize = true;
            this.lightThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lightThemeButton.ForeColor = System.Drawing.Color.Red;
            this.lightThemeButton.Location = new System.Drawing.Point(184, 24);
            this.lightThemeButton.Name = "lightThemeButton";
            this.lightThemeButton.Size = new System.Drawing.Size(63, 18);
            this.lightThemeButton.TabIndex = 1;
            this.lightThemeButton.Text = "Світла";
            this.lightThemeButton.UseVisualStyleBackColor = true;
            this.lightThemeButton.Click += new System.EventHandler(this.lightThemeButton_Click);
            // 
            // darkThemeButton
            // 
            this.darkThemeButton.AutoSize = true;
            this.darkThemeButton.Checked = true;
            this.darkThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.darkThemeButton.ForeColor = System.Drawing.Color.Red;
            this.darkThemeButton.Location = new System.Drawing.Point(16, 24);
            this.darkThemeButton.Name = "darkThemeButton";
            this.darkThemeButton.Size = new System.Drawing.Size(64, 18);
            this.darkThemeButton.TabIndex = 0;
            this.darkThemeButton.TabStop = true;
            this.darkThemeButton.Text = "Темна";
            this.darkThemeButton.UseVisualStyleBackColor = true;
            this.darkThemeButton.Click += new System.EventHandler(this.darkThemeButton_Click);
            // 
            // settingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::CourseworkForAri.Properties.Resources.SingleRoseNullBackground_removebg_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(248, 142);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settingForm";
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton userModeButton;
        private System.Windows.Forms.RadioButton psyhoModeButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton lightThemeButton;
        private System.Windows.Forms.RadioButton darkThemeButton;
    }
}