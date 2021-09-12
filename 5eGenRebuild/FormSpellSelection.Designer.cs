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
            this.ListSpellsAvailable0 = new System.Windows.Forms.ListBox();
            this.TxtDisplayInfo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListSelectedSpells1 = new System.Windows.Forms.ListBox();
            this.BtnContinue = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnDeselect = new System.Windows.Forms.Button();
            this.TabGroupAvailable = new System.Windows.Forms.TabControl();
            this.TabAvailableCantrips = new System.Windows.Forms.TabPage();
            this.TabAvailableLevel1 = new System.Windows.Forms.TabPage();
            this.ListSpellsAvailable1 = new System.Windows.Forms.ListBox();
            this.TabGroupSelected = new System.Windows.Forms.TabControl();
            this.TabSelectedCantrips = new System.Windows.Forms.TabPage();
            this.ListSelectedSpells0 = new System.Windows.Forms.ListBox();
            this.TabSelectedLevel1 = new System.Windows.Forms.TabPage();
            this.LblAvailable0Text = new System.Windows.Forms.Label();
            this.LblAvailable1Text = new System.Windows.Forms.Label();
            this.LblAvailableCantrips = new System.Windows.Forms.Label();
            this.LblAvailableLevel1 = new System.Windows.Forms.Label();
            this.TabGroupAvailable.SuspendLayout();
            this.TabAvailableCantrips.SuspendLayout();
            this.TabAvailableLevel1.SuspendLayout();
            this.TabGroupSelected.SuspendLayout();
            this.TabSelectedCantrips.SuspendLayout();
            this.TabSelectedLevel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListSpellsAvailable0
            // 
            this.ListSpellsAvailable0.FormattingEnabled = true;
            this.ListSpellsAvailable0.Location = new System.Drawing.Point(0, 0);
            this.ListSpellsAvailable0.Name = "ListSpellsAvailable0";
            this.ListSpellsAvailable0.Size = new System.Drawing.Size(171, 316);
            this.ListSpellsAvailable0.TabIndex = 0;
            this.ListSpellsAvailable0.SelectedIndexChanged += new System.EventHandler(this.ListSpellsAvailable0_SelectedIndexChanged);
            // 
            // TxtDisplayInfo
            // 
            this.TxtDisplayInfo.BackColor = System.Drawing.Color.White;
            this.TxtDisplayInfo.CausesValidation = false;
            this.TxtDisplayInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplayInfo.Location = new System.Drawing.Point(436, 9);
            this.TxtDisplayInfo.Name = "TxtDisplayInfo";
            this.TxtDisplayInfo.ReadOnly = true;
            this.TxtDisplayInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TxtDisplayInfo.Size = new System.Drawing.Size(383, 418);
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
            this.label2.Location = new System.Drawing.Point(276, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Selected spells:";
            // 
            // ListSelectedSpells1
            // 
            this.ListSelectedSpells1.FormattingEnabled = true;
            this.ListSelectedSpells1.Location = new System.Drawing.Point(-4, 0);
            this.ListSelectedSpells1.Name = "ListSelectedSpells1";
            this.ListSelectedSpells1.Size = new System.Drawing.Size(178, 316);
            this.ListSelectedSpells1.TabIndex = 47;
            this.ListSelectedSpells1.SelectedIndexChanged += new System.EventHandler(this.ListSelectedSpells1_SelectedIndexChanged);
            // 
            // BtnContinue
            // 
            this.BtnContinue.Location = new System.Drawing.Point(16, 381);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(148, 46);
            this.BtnContinue.TabIndex = 48;
            this.BtnContinue.Text = "Continue";
            this.BtnContinue.UseVisualStyleBackColor = true;
            this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(201, 184);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(35, 23);
            this.BtnSelect.TabIndex = 49;
            this.BtnSelect.Text = ">";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnDeselect
            // 
            this.BtnDeselect.Location = new System.Drawing.Point(201, 213);
            this.BtnDeselect.Name = "BtnDeselect";
            this.BtnDeselect.Size = new System.Drawing.Size(35, 23);
            this.BtnDeselect.TabIndex = 50;
            this.BtnDeselect.Text = "<";
            this.BtnDeselect.UseVisualStyleBackColor = true;
            this.BtnDeselect.Click += new System.EventHandler(this.BtnDeselect_Click);
            // 
            // TabGroupAvailable
            // 
            this.TabGroupAvailable.Controls.Add(this.TabAvailableCantrips);
            this.TabGroupAvailable.Controls.Add(this.TabAvailableLevel1);
            this.TabGroupAvailable.ItemSize = new System.Drawing.Size(50, 18);
            this.TabGroupAvailable.Location = new System.Drawing.Point(16, 37);
            this.TabGroupAvailable.Name = "TabGroupAvailable";
            this.TabGroupAvailable.SelectedIndex = 0;
            this.TabGroupAvailable.Size = new System.Drawing.Size(179, 338);
            this.TabGroupAvailable.TabIndex = 51;
            // 
            // TabAvailableCantrips
            // 
            this.TabAvailableCantrips.Controls.Add(this.ListSpellsAvailable0);
            this.TabAvailableCantrips.Location = new System.Drawing.Point(4, 22);
            this.TabAvailableCantrips.Name = "TabAvailableCantrips";
            this.TabAvailableCantrips.Padding = new System.Windows.Forms.Padding(3);
            this.TabAvailableCantrips.Size = new System.Drawing.Size(171, 312);
            this.TabAvailableCantrips.TabIndex = 0;
            this.TabAvailableCantrips.Text = "Cantrips";
            this.TabAvailableCantrips.UseVisualStyleBackColor = true;
            // 
            // TabAvailableLevel1
            // 
            this.TabAvailableLevel1.Controls.Add(this.ListSpellsAvailable1);
            this.TabAvailableLevel1.Location = new System.Drawing.Point(4, 22);
            this.TabAvailableLevel1.Name = "TabAvailableLevel1";
            this.TabAvailableLevel1.Padding = new System.Windows.Forms.Padding(3);
            this.TabAvailableLevel1.Size = new System.Drawing.Size(171, 312);
            this.TabAvailableLevel1.TabIndex = 1;
            this.TabAvailableLevel1.Text = "Level 1";
            this.TabAvailableLevel1.UseVisualStyleBackColor = true;
            // 
            // ListSpellsAvailable1
            // 
            this.ListSpellsAvailable1.FormattingEnabled = true;
            this.ListSpellsAvailable1.Location = new System.Drawing.Point(0, 0);
            this.ListSpellsAvailable1.Name = "ListSpellsAvailable1";
            this.ListSpellsAvailable1.Size = new System.Drawing.Size(171, 316);
            this.ListSpellsAvailable1.TabIndex = 53;
            this.ListSpellsAvailable1.SelectedIndexChanged += new System.EventHandler(this.ListSpellsAvailable1_SelectedIndexChanged);
            // 
            // TabGroupSelected
            // 
            this.TabGroupSelected.Controls.Add(this.TabSelectedCantrips);
            this.TabGroupSelected.Controls.Add(this.TabSelectedLevel1);
            this.TabGroupSelected.Location = new System.Drawing.Point(242, 37);
            this.TabGroupSelected.Name = "TabGroupSelected";
            this.TabGroupSelected.SelectedIndex = 0;
            this.TabGroupSelected.Size = new System.Drawing.Size(182, 338);
            this.TabGroupSelected.TabIndex = 52;
            // 
            // TabSelectedCantrips
            // 
            this.TabSelectedCantrips.Controls.Add(this.ListSelectedSpells0);
            this.TabSelectedCantrips.Location = new System.Drawing.Point(4, 22);
            this.TabSelectedCantrips.Name = "TabSelectedCantrips";
            this.TabSelectedCantrips.Padding = new System.Windows.Forms.Padding(3);
            this.TabSelectedCantrips.Size = new System.Drawing.Size(174, 312);
            this.TabSelectedCantrips.TabIndex = 0;
            this.TabSelectedCantrips.Text = "Cantrips";
            this.TabSelectedCantrips.UseVisualStyleBackColor = true;
            // 
            // ListSelectedSpells0
            // 
            this.ListSelectedSpells0.FormattingEnabled = true;
            this.ListSelectedSpells0.Location = new System.Drawing.Point(-4, 0);
            this.ListSelectedSpells0.Name = "ListSelectedSpells0";
            this.ListSelectedSpells0.Size = new System.Drawing.Size(178, 316);
            this.ListSelectedSpells0.TabIndex = 0;
            this.ListSelectedSpells0.SelectedIndexChanged += new System.EventHandler(this.ListSelectedSpells0_SelectedIndexChanged);
            // 
            // TabSelectedLevel1
            // 
            this.TabSelectedLevel1.Controls.Add(this.ListSelectedSpells1);
            this.TabSelectedLevel1.Location = new System.Drawing.Point(4, 22);
            this.TabSelectedLevel1.Name = "TabSelectedLevel1";
            this.TabSelectedLevel1.Padding = new System.Windows.Forms.Padding(3);
            this.TabSelectedLevel1.Size = new System.Drawing.Size(174, 312);
            this.TabSelectedLevel1.TabIndex = 1;
            this.TabSelectedLevel1.Text = "Level 1";
            this.TabSelectedLevel1.UseVisualStyleBackColor = true;
            // 
            // LblAvailable0Text
            // 
            this.LblAvailable0Text.AutoSize = true;
            this.LblAvailable0Text.Location = new System.Drawing.Point(170, 381);
            this.LblAvailable0Text.Name = "LblAvailable0Text";
            this.LblAvailable0Text.Size = new System.Drawing.Size(100, 13);
            this.LblAvailable0Text.TabIndex = 53;
            this.LblAvailable0Text.Text = "Available Cantrips - ";
            // 
            // LblAvailable1Text
            // 
            this.LblAvailable1Text.AutoSize = true;
            this.LblAvailable1Text.Location = new System.Drawing.Point(171, 398);
            this.LblAvailable1Text.Name = "LblAvailable1Text";
            this.LblAvailable1Text.Size = new System.Drawing.Size(97, 13);
            this.LblAvailable1Text.TabIndex = 54;
            this.LblAvailable1Text.Text = "Available Level 1 - ";
            // 
            // LblAvailableCantrips
            // 
            this.LblAvailableCantrips.AutoSize = true;
            this.LblAvailableCantrips.Location = new System.Drawing.Point(277, 381);
            this.LblAvailableCantrips.Name = "LblAvailableCantrips";
            this.LblAvailableCantrips.Size = new System.Drawing.Size(35, 13);
            this.LblAvailableCantrips.TabIndex = 55;
            this.LblAvailableCantrips.Text = "label5";
            // 
            // LblAvailableLevel1
            // 
            this.LblAvailableLevel1.AutoSize = true;
            this.LblAvailableLevel1.Location = new System.Drawing.Point(277, 398);
            this.LblAvailableLevel1.Name = "LblAvailableLevel1";
            this.LblAvailableLevel1.Size = new System.Drawing.Size(35, 13);
            this.LblAvailableLevel1.TabIndex = 56;
            this.LblAvailableLevel1.Text = "label6";
            // 
            // FormSpellSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 439);
            this.Controls.Add(this.LblAvailableLevel1);
            this.Controls.Add(this.LblAvailableCantrips);
            this.Controls.Add(this.LblAvailable1Text);
            this.Controls.Add(this.LblAvailable0Text);
            this.Controls.Add(this.TabGroupSelected);
            this.Controls.Add(this.TabGroupAvailable);
            this.Controls.Add(this.BtnDeselect);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.BtnContinue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDisplayInfo);
            this.Controls.Add(this.label1);
            this.Name = "FormSpellSelection";
            this.Text = "Spell selection";
            this.TabGroupAvailable.ResumeLayout(false);
            this.TabAvailableCantrips.ResumeLayout(false);
            this.TabAvailableLevel1.ResumeLayout(false);
            this.TabGroupSelected.ResumeLayout(false);
            this.TabSelectedCantrips.ResumeLayout(false);
            this.TabSelectedLevel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListSpellsAvailable0;
        private System.Windows.Forms.RichTextBox TxtDisplayInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListSelectedSpells1;
        private System.Windows.Forms.Button BtnContinue;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnDeselect;
        private System.Windows.Forms.TabControl TabGroupAvailable;
        private System.Windows.Forms.TabPage TabAvailableCantrips;
        private System.Windows.Forms.TabPage TabAvailableLevel1;
        private System.Windows.Forms.TabControl TabGroupSelected;
        private System.Windows.Forms.TabPage TabSelectedCantrips;
        private System.Windows.Forms.ListBox ListSelectedSpells0;
        private System.Windows.Forms.TabPage TabSelectedLevel1;
        private System.Windows.Forms.ListBox ListSpellsAvailable1;
        private System.Windows.Forms.Label LblAvailable0Text;
        private System.Windows.Forms.Label LblAvailable1Text;
        private System.Windows.Forms.Label LblAvailableCantrips;
        private System.Windows.Forms.Label LblAvailableLevel1;
    }
}