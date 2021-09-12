namespace _5eGenRebuild
{
    partial class FormBackground
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
            this.TxtDisplayInfo = new System.Windows.Forms.RichTextBox();
            this.ListBackgrounds = new System.Windows.Forms.ListBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblLanguage = new System.Windows.Forms.Label();
            this.LblLanguagePlural = new System.Windows.Forms.Label();
            this.LblSelectType2 = new System.Windows.Forms.Label();
            this.LblGaming = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboLanguage1 = new System.Windows.Forms.ComboBox();
            this.ComboGaming = new System.Windows.Forms.ComboBox();
            this.ComboArtisan = new System.Windows.Forms.ComboBox();
            this.ComboInstrument1 = new System.Windows.Forms.ComboBox();
            this.ComboLanguage2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblArtisan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblInstrumentPlural = new System.Windows.Forms.Label();
            this.LblInstrument = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ComboInstrument2 = new System.Windows.Forms.ComboBox();
            this.ComboInstrument4 = new System.Windows.Forms.ComboBox();
            this.ComboInstrument3 = new System.Windows.Forms.ComboBox();
            this.ComboLanguage3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TxtDisplayInfo
            // 
            this.TxtDisplayInfo.BackColor = System.Drawing.Color.White;
            this.TxtDisplayInfo.CausesValidation = false;
            this.TxtDisplayInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplayInfo.Location = new System.Drawing.Point(139, 13);
            this.TxtDisplayInfo.Name = "TxtDisplayInfo";
            this.TxtDisplayInfo.ReadOnly = true;
            this.TxtDisplayInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TxtDisplayInfo.Size = new System.Drawing.Size(397, 232);
            this.TxtDisplayInfo.TabIndex = 44;
            this.TxtDisplayInfo.Text = "";
            // 
            // ListBackgrounds
            // 
            this.ListBackgrounds.FormattingEnabled = true;
            this.ListBackgrounds.Items.AddRange(new object[] {
            "Acolyte",
            "Charlatan",
            "Criminal",
            "Entertainer",
            "Folk Hero",
            "Guild Artisan",
            "Hermit",
            "Noble",
            "Outlander",
            "Sage",
            "Sailor",
            "Solider",
            "Urchin"});
            this.ListBackgrounds.Location = new System.Drawing.Point(13, 13);
            this.ListBackgrounds.Name = "ListBackgrounds";
            this.ListBackgrounds.Size = new System.Drawing.Size(120, 186);
            this.ListBackgrounds.TabIndex = 45;
            this.ListBackgrounds.SelectedIndexChanged += new System.EventHandler(this.ListBackgrounds_SelectedIndexChanged);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirm.Location = new System.Drawing.Point(13, 205);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(120, 41);
            this.BtnConfirm.TabIndex = 46;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(542, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Select";
            // 
            // LblLanguage
            // 
            this.LblLanguage.AutoSize = true;
            this.LblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLanguage.Location = new System.Drawing.Point(595, 16);
            this.LblLanguage.Name = "LblLanguage";
            this.LblLanguage.Size = new System.Drawing.Size(16, 17);
            this.LblLanguage.TabIndex = 68;
            this.LblLanguage.Text = "0";
            // 
            // LblLanguagePlural
            // 
            this.LblLanguagePlural.AutoSize = true;
            this.LblLanguagePlural.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLanguagePlural.Location = new System.Drawing.Point(617, 16);
            this.LblLanguagePlural.Name = "LblLanguagePlural";
            this.LblLanguagePlural.Size = new System.Drawing.Size(78, 17);
            this.LblLanguagePlural.TabIndex = 69;
            this.LblLanguagePlural.Text = "languages:";
            // 
            // LblSelectType2
            // 
            this.LblSelectType2.AutoSize = true;
            this.LblSelectType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelectType2.Location = new System.Drawing.Point(617, 131);
            this.LblSelectType2.Name = "LblSelectType2";
            this.LblSelectType2.Size = new System.Drawing.Size(77, 17);
            this.LblSelectType2.TabIndex = 92;
            this.LblSelectType2.Text = "gaming set";
            // 
            // LblGaming
            // 
            this.LblGaming.AutoSize = true;
            this.LblGaming.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGaming.Location = new System.Drawing.Point(595, 131);
            this.LblGaming.Name = "LblGaming";
            this.LblGaming.Size = new System.Drawing.Size(16, 17);
            this.LblGaming.TabIndex = 91;
            this.LblGaming.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(542, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 70;
            this.label4.Text = "Select";
            // 
            // ComboLanguage1
            // 
            this.ComboLanguage1.Enabled = false;
            this.ComboLanguage1.FormattingEnabled = true;
            this.ComboLanguage1.Items.AddRange(new object[] {
            "Abyssal",
            "Celestial",
            "Deep Speech",
            "Draconic",
            "Dwarvish",
            "Elvish",
            "Giant",
            "Gnomish",
            "Goblin",
            "Halfling",
            "Infernal",
            "Orc",
            "Primordial",
            "Sylvan",
            "Undercommon"});
            this.ComboLanguage1.Location = new System.Drawing.Point(545, 36);
            this.ComboLanguage1.Name = "ComboLanguage1";
            this.ComboLanguage1.Size = new System.Drawing.Size(121, 21);
            this.ComboLanguage1.TabIndex = 94;
            this.ComboLanguage1.SelectedIndexChanged += new System.EventHandler(this.ComboLanguage1_SelectedIndexChanged);
            // 
            // ComboGaming
            // 
            this.ComboGaming.Enabled = false;
            this.ComboGaming.FormattingEnabled = true;
            this.ComboGaming.Items.AddRange(new object[] {
            "Dice set",
            "Playing card set",
            "Three dragon ante set",
            "Dragonchess set"});
            this.ComboGaming.Location = new System.Drawing.Point(545, 151);
            this.ComboGaming.Name = "ComboGaming";
            this.ComboGaming.Size = new System.Drawing.Size(121, 21);
            this.ComboGaming.TabIndex = 95;
            this.ComboGaming.SelectedIndexChanged += new System.EventHandler(this.ComboGaming_SelectedIndexChanged);
            // 
            // ComboArtisan
            // 
            this.ComboArtisan.Enabled = false;
            this.ComboArtisan.FormattingEnabled = true;
            this.ComboArtisan.Items.AddRange(new object[] {
            "Alchemist’s supplies",
            "Tinker’s tools",
            "Glassblower’s tools",
            "Jeweler’s tools",
            "Brewer’s supplies",
            "Smith’s tools",
            "Cartographer’s tools",
            "Mason’s tools",
            "Calligrapher’s Supplies",
            "Painter’s supplies",
            "Potter’s tools",
            "Carpenter’s tools",
            "Cobbler’s tools",
            "Leatherworker’s tools",
            "Cook’s utensils",
            "Weaver’s tools",
            "Woodcarver’s tools"});
            this.ComboArtisan.Location = new System.Drawing.Point(545, 107);
            this.ComboArtisan.Name = "ComboArtisan";
            this.ComboArtisan.Size = new System.Drawing.Size(121, 21);
            this.ComboArtisan.TabIndex = 97;
            this.ComboArtisan.SelectedIndexChanged += new System.EventHandler(this.ComboArtisan_SelectedIndexChanged);
            // 
            // ComboInstrument1
            // 
            this.ComboInstrument1.Enabled = false;
            this.ComboInstrument1.FormattingEnabled = true;
            this.ComboInstrument1.Items.AddRange(new object[] {
            "Bagpipes",
            "Birdpipes",
            "Drum",
            "Dulcimer",
            "Flute",
            "Glaur",
            "Longhorn",
            "Lute",
            "Lyre",
            "Horn",
            "Pan flute",
            "Shawm",
            "Songhorn",
            "Tantan",
            "Thelarr",
            "Tocken",
            "Viola",
            "Wargong",
            "Yarting",
            "Zulkoon"});
            this.ComboInstrument1.Location = new System.Drawing.Point(545, 195);
            this.ComboInstrument1.Name = "ComboInstrument1";
            this.ComboInstrument1.Size = new System.Drawing.Size(121, 21);
            this.ComboInstrument1.TabIndex = 96;
            this.ComboInstrument1.SelectedIndexChanged += new System.EventHandler(this.ComboInstrument1_SelectedIndexChanged);
            // 
            // ComboLanguage2
            // 
            this.ComboLanguage2.Enabled = false;
            this.ComboLanguage2.FormattingEnabled = true;
            this.ComboLanguage2.Location = new System.Drawing.Point(672, 36);
            this.ComboLanguage2.Name = "ComboLanguage2";
            this.ComboLanguage2.Size = new System.Drawing.Size(121, 21);
            this.ComboLanguage2.TabIndex = 98;
            this.ComboLanguage2.SelectedIndexChanged += new System.EventHandler(this.ComboLanguage2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(617, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 101;
            this.label2.Text = "artisan\'s tools";
            // 
            // LblArtisan
            // 
            this.LblArtisan.AutoSize = true;
            this.LblArtisan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArtisan.Location = new System.Drawing.Point(595, 87);
            this.LblArtisan.Name = "LblArtisan";
            this.LblArtisan.Size = new System.Drawing.Size(16, 17);
            this.LblArtisan.TabIndex = 100;
            this.LblArtisan.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(542, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 99;
            this.label5.Text = "Select";
            // 
            // LblInstrumentPlural
            // 
            this.LblInstrumentPlural.AutoSize = true;
            this.LblInstrumentPlural.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInstrumentPlural.Location = new System.Drawing.Point(617, 175);
            this.LblInstrumentPlural.Name = "LblInstrumentPlural";
            this.LblInstrumentPlural.Size = new System.Drawing.Size(74, 17);
            this.LblInstrumentPlural.TabIndex = 104;
            this.LblInstrumentPlural.Text = "instrument";
            // 
            // LblInstrument
            // 
            this.LblInstrument.AutoSize = true;
            this.LblInstrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInstrument.Location = new System.Drawing.Point(595, 175);
            this.LblInstrument.Name = "LblInstrument";
            this.LblInstrument.Size = new System.Drawing.Size(16, 17);
            this.LblInstrument.TabIndex = 103;
            this.LblInstrument.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(542, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 102;
            this.label8.Text = "Select";
            // 
            // ComboInstrument2
            // 
            this.ComboInstrument2.Enabled = false;
            this.ComboInstrument2.FormattingEnabled = true;
            this.ComboInstrument2.Items.AddRange(new object[] {
            "Bagpipes",
            "Birdpipes",
            "Drum",
            "Dulcimer",
            "Flute",
            "Glaur",
            "Longhorn",
            "Lute",
            "Lyre",
            "Horn",
            "Pan flute",
            "Shawm",
            "Songhorn",
            "Tantan",
            "Thelarr",
            "Tocken",
            "Viola",
            "Wargong",
            "Yarting",
            "Zulkoon"});
            this.ComboInstrument2.Location = new System.Drawing.Point(672, 195);
            this.ComboInstrument2.Name = "ComboInstrument2";
            this.ComboInstrument2.Size = new System.Drawing.Size(121, 21);
            this.ComboInstrument2.TabIndex = 105;
            this.ComboInstrument2.SelectedIndexChanged += new System.EventHandler(this.ComboInstrument2_SelectedIndexChanged);
            // 
            // ComboInstrument4
            // 
            this.ComboInstrument4.Enabled = false;
            this.ComboInstrument4.FormattingEnabled = true;
            this.ComboInstrument4.Items.AddRange(new object[] {
            "Bagpipes",
            "Birdpipes",
            "Drum",
            "Dulcimer",
            "Flute",
            "Glaur",
            "Longhorn",
            "Lute",
            "Lyre",
            "Horn",
            "Pan flute",
            "Shawm",
            "Songhorn",
            "Tantan",
            "Thelarr",
            "Tocken",
            "Viola",
            "Wargong",
            "Yarting",
            "Zulkoon"});
            this.ComboInstrument4.Location = new System.Drawing.Point(672, 222);
            this.ComboInstrument4.Name = "ComboInstrument4";
            this.ComboInstrument4.Size = new System.Drawing.Size(121, 21);
            this.ComboInstrument4.TabIndex = 107;
            this.ComboInstrument4.SelectedIndexChanged += new System.EventHandler(this.ComboInstrument4_SelectedIndexChanged);
            // 
            // ComboInstrument3
            // 
            this.ComboInstrument3.Enabled = false;
            this.ComboInstrument3.FormattingEnabled = true;
            this.ComboInstrument3.Items.AddRange(new object[] {
            "Bagpipes",
            "Birdpipes",
            "Drum",
            "Dulcimer",
            "Flute",
            "Glaur",
            "Longhorn",
            "Lute",
            "Lyre",
            "Horn",
            "Pan flute",
            "Shawm",
            "Songhorn",
            "Tantan",
            "Thelarr",
            "Tocken",
            "Viola",
            "Wargong",
            "Yarting",
            "Zulkoon"});
            this.ComboInstrument3.Location = new System.Drawing.Point(545, 222);
            this.ComboInstrument3.Name = "ComboInstrument3";
            this.ComboInstrument3.Size = new System.Drawing.Size(121, 21);
            this.ComboInstrument3.TabIndex = 106;
            this.ComboInstrument3.SelectedIndexChanged += new System.EventHandler(this.ComboInstrument3_SelectedIndexChanged);
            // 
            // ComboLanguage3
            // 
            this.ComboLanguage3.Enabled = false;
            this.ComboLanguage3.FormattingEnabled = true;
            this.ComboLanguage3.Location = new System.Drawing.Point(545, 63);
            this.ComboLanguage3.Name = "ComboLanguage3";
            this.ComboLanguage3.Size = new System.Drawing.Size(121, 21);
            this.ComboLanguage3.TabIndex = 108;
            this.ComboLanguage3.Visible = false;
            this.ComboLanguage3.SelectedIndexChanged += new System.EventHandler(this.ComboLanguage3_SelectedIndexChanged);
            // 
            // FormBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 255);
            this.Controls.Add(this.ComboLanguage3);
            this.Controls.Add(this.ComboInstrument4);
            this.Controls.Add(this.ComboInstrument3);
            this.Controls.Add(this.ComboInstrument2);
            this.Controls.Add(this.LblInstrumentPlural);
            this.Controls.Add(this.LblInstrument);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblArtisan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboLanguage2);
            this.Controls.Add(this.ComboArtisan);
            this.Controls.Add(this.ComboInstrument1);
            this.Controls.Add(this.ComboGaming);
            this.Controls.Add(this.ComboLanguage1);
            this.Controls.Add(this.LblSelectType2);
            this.Controls.Add(this.LblGaming);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblLanguagePlural);
            this.Controls.Add(this.LblLanguage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.ListBackgrounds);
            this.Controls.Add(this.TxtDisplayInfo);
            this.Name = "FormBackground";
            this.Text = "Select character background";
            this.Load += new System.EventHandler(this.FormBackground_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TxtDisplayInfo;
        private System.Windows.Forms.ListBox ListBackgrounds;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblLanguage;
        private System.Windows.Forms.Label LblLanguagePlural;
        private System.Windows.Forms.Label LblSelectType2;
        private System.Windows.Forms.Label LblGaming;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboLanguage1;
        private System.Windows.Forms.ComboBox ComboGaming;
        private System.Windows.Forms.ComboBox ComboArtisan;
        private System.Windows.Forms.ComboBox ComboInstrument1;
        private System.Windows.Forms.ComboBox ComboLanguage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblArtisan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblInstrumentPlural;
        private System.Windows.Forms.Label LblInstrument;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComboInstrument2;
        private System.Windows.Forms.ComboBox ComboInstrument4;
        private System.Windows.Forms.ComboBox ComboInstrument3;
        private System.Windows.Forms.ComboBox ComboLanguage3;
    }
}