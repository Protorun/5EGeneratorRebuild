namespace _5eGenRebuild
{
    partial class FormNewToon
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
            this.BtnGender = new System.Windows.Forms.Button();
            this.BtnRace = new System.Windows.Forms.Button();
            this.BtnClass = new System.Windows.Forms.Button();
            this.BtnAttributes = new System.Windows.Forms.Button();
            this.BtnSkills = new System.Windows.Forms.Button();
            this.GroupDisplayToonInfo = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // BtnGender
            // 
            this.BtnGender.Location = new System.Drawing.Point(13, 13);
            this.BtnGender.Name = "BtnGender";
            this.BtnGender.Size = new System.Drawing.Size(142, 46);
            this.BtnGender.TabIndex = 0;
            this.BtnGender.Text = "Gender";
            this.BtnGender.UseVisualStyleBackColor = true;
            this.BtnGender.Click += new System.EventHandler(this.BtnGender_Click);
            // 
            // BtnRace
            // 
            this.BtnRace.Location = new System.Drawing.Point(13, 65);
            this.BtnRace.Name = "BtnRace";
            this.BtnRace.Size = new System.Drawing.Size(142, 46);
            this.BtnRace.TabIndex = 1;
            this.BtnRace.Text = "Race";
            this.BtnRace.UseVisualStyleBackColor = true;
            this.BtnRace.Click += new System.EventHandler(this.BtnRace_Click);
            // 
            // BtnClass
            // 
            this.BtnClass.Location = new System.Drawing.Point(13, 117);
            this.BtnClass.Name = "BtnClass";
            this.BtnClass.Size = new System.Drawing.Size(142, 46);
            this.BtnClass.TabIndex = 2;
            this.BtnClass.Text = "Class";
            this.BtnClass.UseVisualStyleBackColor = true;
            this.BtnClass.Click += new System.EventHandler(this.BtnClass_Click);
            // 
            // BtnAttributes
            // 
            this.BtnAttributes.Location = new System.Drawing.Point(13, 169);
            this.BtnAttributes.Name = "BtnAttributes";
            this.BtnAttributes.Size = new System.Drawing.Size(142, 46);
            this.BtnAttributes.TabIndex = 3;
            this.BtnAttributes.Text = "Attributes";
            this.BtnAttributes.UseVisualStyleBackColor = true;
            this.BtnAttributes.Click += new System.EventHandler(this.BtnAttributes_Click);
            // 
            // BtnSkills
            // 
            this.BtnSkills.Location = new System.Drawing.Point(13, 221);
            this.BtnSkills.Name = "BtnSkills";
            this.BtnSkills.Size = new System.Drawing.Size(142, 46);
            this.BtnSkills.TabIndex = 4;
            this.BtnSkills.Text = "Skills";
            this.BtnSkills.UseVisualStyleBackColor = true;
            this.BtnSkills.Click += new System.EventHandler(this.BtnSkills_Click);
            // 
            // GroupDisplayToonInfo
            // 
            this.GroupDisplayToonInfo.Location = new System.Drawing.Point(162, 13);
            this.GroupDisplayToonInfo.Name = "GroupDisplayToonInfo";
            this.GroupDisplayToonInfo.Size = new System.Drawing.Size(402, 253);
            this.GroupDisplayToonInfo.TabIndex = 5;
            this.GroupDisplayToonInfo.TabStop = false;
            this.GroupDisplayToonInfo.Text = "Character Panel";
            // 
            // FormNewToon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 278);
            this.Controls.Add(this.GroupDisplayToonInfo);
            this.Controls.Add(this.BtnSkills);
            this.Controls.Add(this.BtnAttributes);
            this.Controls.Add(this.BtnClass);
            this.Controls.Add(this.BtnRace);
            this.Controls.Add(this.BtnGender);
            this.Name = "FormNewToon";
            this.Text = "New Character";
            this.Load += new System.EventHandler(this.FormNewToon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGender;
        private System.Windows.Forms.Button BtnRace;
        private System.Windows.Forms.Button BtnClass;
        private System.Windows.Forms.Button BtnAttributes;
        private System.Windows.Forms.Button BtnSkills;
        private System.Windows.Forms.GroupBox GroupDisplayToonInfo;
    }
}