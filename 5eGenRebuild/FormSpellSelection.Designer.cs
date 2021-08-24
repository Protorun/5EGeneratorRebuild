namespace _5eGenRebuild
{
    partial class FormSpellSelection
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
            this.ListSpellsAvailable = new System.Windows.Forms.ListBox();
            this.TxtDisplayInfo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListSelectedSpells = new System.Windows.Forms.ListBox();
            this.BtnContinue = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnDeselect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListSpellsAvailable
            // 
            this.ListSpellsAvailable.FormattingEnabled = true;
            this.ListSpellsAvailable.Location = new System.Drawing.Point(16, 32);
            this.ListSpellsAvailable.Name = "ListSpellsAvailable";
            this.ListSpellsAvailable.Size = new System.Drawing.Size(106, 290);
            this.ListSpellsAvailable.TabIndex = 0;
            this.ListSpellsAvailable.SelectedIndexChanged += new System.EventHandler(this.ListSpellsAvailable_SelectedIndexChanged);
            // 
            // TxtDisplayInfo
            // 
            this.TxtDisplayInfo.BackColor = System.Drawing.Color.White;
            this.TxtDisplayInfo.CausesValidation = false;
            this.TxtDisplayInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplayInfo.Location = new System.Drawing.Point(292, 11);
            this.TxtDisplayInfo.Name = "TxtDisplayInfo";
            this.TxtDisplayInfo.ReadOnly = true;
            this.TxtDisplayInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TxtDisplayInfo.Size = new System.Drawing.Size(377, 368);
            this.TxtDisplayInfo.TabIndex = 45;
            this.TxtDisplayInfo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Available spells:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Selected spells:";
            // 
            // ListSelectedSpells
            // 
            this.ListSelectedSpells.FormattingEnabled = true;
            this.ListSelectedSpells.Location = new System.Drawing.Point(169, 32);
            this.ListSelectedSpells.Name = "ListSelectedSpells";
            this.ListSelectedSpells.Size = new System.Drawing.Size(107, 290);
            this.ListSelectedSpells.TabIndex = 47;
            this.ListSelectedSpells.SelectedIndexChanged += new System.EventHandler(this.ListSelectedSpells_SelectedIndexChanged);
            // 
            // BtnContinue
            // 
            this.BtnContinue.Location = new System.Drawing.Point(12, 333);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(148, 46);
            this.BtnContinue.TabIndex = 48;
            this.BtnContinue.Text = "Continue";
            this.BtnContinue.UseVisualStyleBackColor = true;
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(128, 135);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(35, 23);
            this.BtnSelect.TabIndex = 49;
            this.BtnSelect.Text = ">";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnDeselect
            // 
            this.BtnDeselect.Location = new System.Drawing.Point(128, 164);
            this.BtnDeselect.Name = "BtnDeselect";
            this.BtnDeselect.Size = new System.Drawing.Size(35, 23);
            this.BtnDeselect.TabIndex = 50;
            this.BtnDeselect.Text = "<";
            this.BtnDeselect.UseVisualStyleBackColor = true;
            this.BtnDeselect.Click += new System.EventHandler(this.BtnDeselect_Click);
            // 
            // FormSpellSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 392);
            this.Controls.Add(this.BtnDeselect);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.BtnContinue);
            this.Controls.Add(this.ListSelectedSpells);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDisplayInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListSpellsAvailable);
            this.Name = "FormSpellSelection";
            this.Text = "Spell selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListSpellsAvailable;
        private System.Windows.Forms.RichTextBox TxtDisplayInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListSelectedSpells;
        private System.Windows.Forms.Button BtnContinue;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnDeselect;
    }
}