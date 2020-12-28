namespace _5eGenRebuild
{
    partial class FormMainMenu
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
            this.BtnNewToon = new System.Windows.Forms.Button();
            this.BtnLoadToon = new System.Windows.Forms.Button();
            this.BtnDeleteToon = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnNewToon
            // 
            this.BtnNewToon.Location = new System.Drawing.Point(78, 12);
            this.BtnNewToon.Name = "BtnNewToon";
            this.BtnNewToon.Size = new System.Drawing.Size(185, 64);
            this.BtnNewToon.TabIndex = 0;
            this.BtnNewToon.Text = "New Character";
            this.BtnNewToon.UseVisualStyleBackColor = true;
            this.BtnNewToon.Click += new System.EventHandler(this.BtnNewToon_Click);
            // 
            // BtnLoadToon
            // 
            this.BtnLoadToon.Location = new System.Drawing.Point(78, 82);
            this.BtnLoadToon.Name = "BtnLoadToon";
            this.BtnLoadToon.Size = new System.Drawing.Size(185, 64);
            this.BtnLoadToon.TabIndex = 4;
            this.BtnLoadToon.Text = "Edit/Load Character";
            this.BtnLoadToon.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteToon
            // 
            this.BtnDeleteToon.Location = new System.Drawing.Point(78, 152);
            this.BtnDeleteToon.Name = "BtnDeleteToon";
            this.BtnDeleteToon.Size = new System.Drawing.Size(185, 64);
            this.BtnDeleteToon.TabIndex = 5;
            this.BtnDeleteToon.Text = "Delete Character";
            this.BtnDeleteToon.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(78, 222);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(185, 64);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 301);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnDeleteToon);
            this.Controls.Add(this.BtnLoadToon);
            this.Controls.Add(this.BtnNewToon);
            this.Name = "FormMainMenu";
            this.Text = "D&D 5th Edition Character Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNewToon;
        private System.Windows.Forms.Button BtnLoadToon;
        private System.Windows.Forms.Button BtnDeleteToon;
        private System.Windows.Forms.Button BtnClose;
    }
}

