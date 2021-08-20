namespace _5eGenRebuild
{
    partial class FormSelectAttribute
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
            this.lblSelectionNumber = new System.Windows.Forms.Label();
            this.lblTotalSelections = new System.Windows.Forms.Label();
            this.CheckStrength = new System.Windows.Forms.CheckBox();
            this.CheckDexterity = new System.Windows.Forms.CheckBox();
            this.CheckConstitution = new System.Windows.Forms.CheckBox();
            this.CheckCharisma = new System.Windows.Forms.CheckBox();
            this.CheckWisdom = new System.Windows.Forms.CheckBox();
            this.CheckIntelligence = new System.Windows.Forms.CheckBox();
            this.BtnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectionNumber
            // 
            this.lblSelectionNumber.AutoSize = true;
            this.lblSelectionNumber.Location = new System.Drawing.Point(9, 13);
            this.lblSelectionNumber.Name = "lblSelectionNumber";
            this.lblSelectionNumber.Size = new System.Drawing.Size(91, 13);
            this.lblSelectionNumber.TabIndex = 0;
            this.lblSelectionNumber.Text = "Selection Number";
            // 
            // lblTotalSelections
            // 
            this.lblTotalSelections.AutoSize = true;
            this.lblTotalSelections.Location = new System.Drawing.Point(9, 164);
            this.lblTotalSelections.Name = "lblTotalSelections";
            this.lblTotalSelections.Size = new System.Drawing.Size(109, 13);
            this.lblTotalSelections.TabIndex = 8;
            this.lblTotalSelections.Text = "Selections Remaining";
            // 
            // CheckStrength
            // 
            this.CheckStrength.AutoSize = true;
            this.CheckStrength.Location = new System.Drawing.Point(12, 29);
            this.CheckStrength.Name = "CheckStrength";
            this.CheckStrength.Size = new System.Drawing.Size(66, 17);
            this.CheckStrength.TabIndex = 9;
            this.CheckStrength.Text = "Strength";
            this.CheckStrength.UseVisualStyleBackColor = true;
            this.CheckStrength.CheckedChanged += new System.EventHandler(this.CheckStrength_CheckedChanged);
            // 
            // CheckDexterity
            // 
            this.CheckDexterity.AutoSize = true;
            this.CheckDexterity.Location = new System.Drawing.Point(12, 52);
            this.CheckDexterity.Name = "CheckDexterity";
            this.CheckDexterity.Size = new System.Drawing.Size(67, 17);
            this.CheckDexterity.TabIndex = 10;
            this.CheckDexterity.Text = "Dexterity";
            this.CheckDexterity.UseVisualStyleBackColor = true;
            this.CheckDexterity.CheckedChanged += new System.EventHandler(this.CheckDexterity_CheckedChanged);
            // 
            // CheckConstitution
            // 
            this.CheckConstitution.AutoSize = true;
            this.CheckConstitution.Location = new System.Drawing.Point(12, 75);
            this.CheckConstitution.Name = "CheckConstitution";
            this.CheckConstitution.Size = new System.Drawing.Size(81, 17);
            this.CheckConstitution.TabIndex = 11;
            this.CheckConstitution.Text = "Constitution";
            this.CheckConstitution.UseVisualStyleBackColor = true;
            this.CheckConstitution.CheckedChanged += new System.EventHandler(this.CheckConstitution_CheckedChanged);
            // 
            // CheckCharisma
            // 
            this.CheckCharisma.AutoSize = true;
            this.CheckCharisma.Location = new System.Drawing.Point(12, 144);
            this.CheckCharisma.Name = "CheckCharisma";
            this.CheckCharisma.Size = new System.Drawing.Size(69, 17);
            this.CheckCharisma.TabIndex = 14;
            this.CheckCharisma.Text = "Charisma";
            this.CheckCharisma.UseVisualStyleBackColor = true;
            this.CheckCharisma.CheckedChanged += new System.EventHandler(this.CheckCharisma_CheckedChanged);
            // 
            // CheckWisdom
            // 
            this.CheckWisdom.AutoSize = true;
            this.CheckWisdom.Location = new System.Drawing.Point(12, 121);
            this.CheckWisdom.Name = "CheckWisdom";
            this.CheckWisdom.Size = new System.Drawing.Size(64, 17);
            this.CheckWisdom.TabIndex = 13;
            this.CheckWisdom.Text = "Wisdom";
            this.CheckWisdom.UseVisualStyleBackColor = true;
            this.CheckWisdom.CheckedChanged += new System.EventHandler(this.CheckWisdom_CheckedChanged);
            // 
            // CheckIntelligence
            // 
            this.CheckIntelligence.AutoSize = true;
            this.CheckIntelligence.Location = new System.Drawing.Point(12, 98);
            this.CheckIntelligence.Name = "CheckIntelligence";
            this.CheckIntelligence.Size = new System.Drawing.Size(80, 17);
            this.CheckIntelligence.TabIndex = 12;
            this.CheckIntelligence.Text = "Intelligence";
            this.CheckIntelligence.UseVisualStyleBackColor = true;
            this.CheckIntelligence.CheckedChanged += new System.EventHandler(this.CheckIntelligence_CheckedChanged);
            // 
            // BtnContinue
            // 
            this.BtnContinue.Location = new System.Drawing.Point(12, 180);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(75, 23);
            this.BtnContinue.TabIndex = 15;
            this.BtnContinue.Text = "Continue";
            this.BtnContinue.UseVisualStyleBackColor = true;
            this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // FormSelectAttribute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 213);
            this.Controls.Add(this.BtnContinue);
            this.Controls.Add(this.CheckCharisma);
            this.Controls.Add(this.CheckWisdom);
            this.Controls.Add(this.CheckIntelligence);
            this.Controls.Add(this.CheckConstitution);
            this.Controls.Add(this.CheckDexterity);
            this.Controls.Add(this.CheckStrength);
            this.Controls.Add(this.lblTotalSelections);
            this.Controls.Add(this.lblSelectionNumber);
            this.Name = "FormSelectAttribute";
            this.Text = "Select attribute bonuses";
            this.Load += new System.EventHandler(this.FormSelectAttribute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectionNumber;
        private System.Windows.Forms.Label lblTotalSelections;
        private System.Windows.Forms.CheckBox CheckStrength;
        private System.Windows.Forms.CheckBox CheckDexterity;
        private System.Windows.Forms.CheckBox CheckConstitution;
        private System.Windows.Forms.CheckBox CheckCharisma;
        private System.Windows.Forms.CheckBox CheckWisdom;
        private System.Windows.Forms.CheckBox CheckIntelligence;
        private System.Windows.Forms.Button BtnContinue;
    }
}