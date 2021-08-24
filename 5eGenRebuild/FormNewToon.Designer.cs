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
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.LblSubrace = new System.Windows.Forms.Label();
            this.LblRace = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.BtnBackground = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnAddFireball = new System.Windows.Forms.Button();
            this.BtnFeat = new System.Windows.Forms.Button();
            this.BtnSpells = new System.Windows.Forms.Button();
            this.LblClass = new System.Windows.Forms.Label();
            this.GroupDisplayToonInfo.SuspendLayout();
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
            this.BtnSkills.Location = new System.Drawing.Point(13, 273);
            this.BtnSkills.Name = "BtnSkills";
            this.BtnSkills.Size = new System.Drawing.Size(142, 46);
            this.BtnSkills.TabIndex = 4;
            this.BtnSkills.Text = "Skills";
            this.BtnSkills.UseVisualStyleBackColor = true;
            this.BtnSkills.Click += new System.EventHandler(this.BtnSkills_Click);
            // 
            // GroupDisplayToonInfo
            // 
            this.GroupDisplayToonInfo.Controls.Add(this.LblClass);
            this.GroupDisplayToonInfo.Controls.Add(this.BtnFeat);
            this.GroupDisplayToonInfo.Controls.Add(this.BtnAddFireball);
            this.GroupDisplayToonInfo.Controls.Add(this.TxtLastName);
            this.GroupDisplayToonInfo.Controls.Add(this.TxtFirstName);
            this.GroupDisplayToonInfo.Controls.Add(this.LblSubrace);
            this.GroupDisplayToonInfo.Controls.Add(this.LblRace);
            this.GroupDisplayToonInfo.Controls.Add(this.LblGender);
            this.GroupDisplayToonInfo.Location = new System.Drawing.Point(162, 13);
            this.GroupDisplayToonInfo.Name = "GroupDisplayToonInfo";
            this.GroupDisplayToonInfo.Size = new System.Drawing.Size(402, 358);
            this.GroupDisplayToonInfo.TabIndex = 5;
            this.GroupDisplayToonInfo.TabStop = false;
            this.GroupDisplayToonInfo.Text = "Character Panel";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(113, 195);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(100, 20);
            this.TxtLastName.TabIndex = 4;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(7, 195);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(100, 20);
            this.TxtFirstName.TabIndex = 3;
            // 
            // LblSubrace
            // 
            this.LblSubrace.AutoSize = true;
            this.LblSubrace.Location = new System.Drawing.Point(7, 46);
            this.LblSubrace.Name = "LblSubrace";
            this.LblSubrace.Size = new System.Drawing.Size(47, 13);
            this.LblSubrace.TabIndex = 2;
            this.LblSubrace.Text = "Subrace";
            // 
            // LblRace
            // 
            this.LblRace.AutoSize = true;
            this.LblRace.Location = new System.Drawing.Point(7, 33);
            this.LblRace.Name = "LblRace";
            this.LblRace.Size = new System.Drawing.Size(33, 13);
            this.LblRace.TabIndex = 1;
            this.LblRace.Text = "Race";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Location = new System.Drawing.Point(7, 20);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(42, 13);
            this.LblGender.TabIndex = 0;
            this.LblGender.Text = "Gender";
            // 
            // BtnBackground
            // 
            this.BtnBackground.Location = new System.Drawing.Point(13, 221);
            this.BtnBackground.Name = "BtnBackground";
            this.BtnBackground.Size = new System.Drawing.Size(142, 46);
            this.BtnBackground.TabIndex = 6;
            this.BtnBackground.Text = "Background";
            this.BtnBackground.UseVisualStyleBackColor = true;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(13, 377);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(142, 46);
            this.BtnConfirm.TabIndex = 8;
            this.BtnConfirm.Text = "Confirm Character";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // BtnAddFireball
            // 
            this.BtnAddFireball.Location = new System.Drawing.Point(113, 222);
            this.BtnAddFireball.Name = "BtnAddFireball";
            this.BtnAddFireball.Size = new System.Drawing.Size(75, 23);
            this.BtnAddFireball.TabIndex = 5;
            this.BtnAddFireball.Text = "Add Fireball";
            this.BtnAddFireball.UseVisualStyleBackColor = true;
            this.BtnAddFireball.Click += new System.EventHandler(this.BtnAddFireball_Click);
            // 
            // BtnFeat
            // 
            this.BtnFeat.Location = new System.Drawing.Point(113, 252);
            this.BtnFeat.Name = "BtnFeat";
            this.BtnFeat.Size = new System.Drawing.Size(75, 23);
            this.BtnFeat.TabIndex = 6;
            this.BtnFeat.Text = "Add a feat";
            this.BtnFeat.UseVisualStyleBackColor = true;
            this.BtnFeat.Click += new System.EventHandler(this.BtnFeat_Click);
            // 
            // BtnSpells
            // 
            this.BtnSpells.Enabled = false;
            this.BtnSpells.Location = new System.Drawing.Point(14, 325);
            this.BtnSpells.Name = "BtnSpells";
            this.BtnSpells.Size = new System.Drawing.Size(142, 46);
            this.BtnSpells.TabIndex = 9;
            this.BtnSpells.Text = "Spells";
            this.BtnSpells.UseVisualStyleBackColor = true;
            this.BtnSpells.Click += new System.EventHandler(this.BtnSpells_Click);
            // 
            // LblClass
            // 
            this.LblClass.AutoSize = true;
            this.LblClass.Location = new System.Drawing.Point(7, 59);
            this.LblClass.Name = "LblClass";
            this.LblClass.Size = new System.Drawing.Size(32, 13);
            this.LblClass.TabIndex = 7;
            this.LblClass.Text = "Class";
            // 
            // FormNewToon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 430);
            this.Controls.Add(this.BtnSpells);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnBackground);
            this.Controls.Add(this.GroupDisplayToonInfo);
            this.Controls.Add(this.BtnSkills);
            this.Controls.Add(this.BtnAttributes);
            this.Controls.Add(this.BtnClass);
            this.Controls.Add(this.BtnRace);
            this.Controls.Add(this.BtnGender);
            this.Name = "FormNewToon";
            this.Text = "New Character";
            this.Load += new System.EventHandler(this.FormNewToon_Load);
            this.GroupDisplayToonInfo.ResumeLayout(false);
            this.GroupDisplayToonInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGender;
        private System.Windows.Forms.Button BtnRace;
        private System.Windows.Forms.Button BtnClass;
        private System.Windows.Forms.Button BtnAttributes;
        private System.Windows.Forms.Button BtnSkills;
        private System.Windows.Forms.GroupBox GroupDisplayToonInfo;
        private System.Windows.Forms.Label LblRace;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label LblSubrace;
        private System.Windows.Forms.Button BtnBackground;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Button BtnAddFireball;
        private System.Windows.Forms.Button BtnFeat;
        private System.Windows.Forms.Button BtnSpells;
        private System.Windows.Forms.Label LblClass;
    }
}