namespace _5eGenRebuild
{
    partial class FormGender
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
            this.BtnMale = new System.Windows.Forms.Button();
            this.BtnFemale = new System.Windows.Forms.Button();
            this.BtnBoth = new System.Windows.Forms.Button();
            this.BtnNone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.LblSelection = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnMale
            // 
            this.BtnMale.Location = new System.Drawing.Point(12, 32);
            this.BtnMale.Name = "BtnMale";
            this.BtnMale.Size = new System.Drawing.Size(142, 46);
            this.BtnMale.TabIndex = 1;
            this.BtnMale.Text = "Male";
            this.BtnMale.UseVisualStyleBackColor = true;
            this.BtnMale.Click += new System.EventHandler(this.BtnMale_Click);
            // 
            // BtnFemale
            // 
            this.BtnFemale.Location = new System.Drawing.Point(160, 32);
            this.BtnFemale.Name = "BtnFemale";
            this.BtnFemale.Size = new System.Drawing.Size(142, 46);
            this.BtnFemale.TabIndex = 2;
            this.BtnFemale.Text = "Female";
            this.BtnFemale.UseVisualStyleBackColor = true;
            this.BtnFemale.Click += new System.EventHandler(this.BtnFemale_Click);
            // 
            // BtnBoth
            // 
            this.BtnBoth.Location = new System.Drawing.Point(12, 84);
            this.BtnBoth.Name = "BtnBoth";
            this.BtnBoth.Size = new System.Drawing.Size(142, 46);
            this.BtnBoth.TabIndex = 3;
            this.BtnBoth.Text = "Both";
            this.BtnBoth.UseVisualStyleBackColor = true;
            this.BtnBoth.Click += new System.EventHandler(this.BtnBoth_Click);
            // 
            // BtnNone
            // 
            this.BtnNone.Location = new System.Drawing.Point(160, 84);
            this.BtnNone.Name = "BtnNone";
            this.BtnNone.Size = new System.Drawing.Size(142, 46);
            this.BtnNone.TabIndex = 4;
            this.BtnNone.Text = "None";
            this.BtnNone.UseVisualStyleBackColor = true;
            this.BtnNone.Click += new System.EventHandler(this.BtnNone_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select gender:";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(92, 136);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnConfirm.Size = new System.Drawing.Size(142, 46);
            this.BtnConfirm.TabIndex = 6;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // LblSelection
            // 
            this.LblSelection.AutoSize = true;
            this.LblSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelection.Location = new System.Drawing.Point(143, 185);
            this.LblSelection.Name = "LblSelection";
            this.LblSelection.Size = new System.Drawing.Size(22, 20);
            this.LblSelection.TabIndex = 17;
            this.LblSelection.Text = " - ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Current selection:";
            // 
            // FormGender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 212);
            this.Controls.Add(this.LblSelection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNone);
            this.Controls.Add(this.BtnBoth);
            this.Controls.Add(this.BtnFemale);
            this.Controls.Add(this.BtnMale);
            this.Name = "FormGender";
            this.Text = "Gender selection";
            this.Load += new System.EventHandler(this.FormGender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMale;
        private System.Windows.Forms.Button BtnFemale;
        private System.Windows.Forms.Button BtnBoth;
        private System.Windows.Forms.Button BtnNone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Label LblSelection;
        private System.Windows.Forms.Label label2;
    }
}