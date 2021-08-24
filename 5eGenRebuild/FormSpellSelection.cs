using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5eGenRebuild
{
    public partial class FormSpellSelection : Form
    {
        Character ThisToon;
        Dictionary<string, Spell> AllSpells = new Dictionary<string, Spell>();

        public FormSpellSelection(Character NewToon)
        {
            InitializeComponent();
            ThisToon = NewToon;
            InitialiseOptions();
        }

        public void InitialiseOptions()
        {
            if (ThisToon.Class == "Bard")
            {
                this.Text = "Spell selection (Bard)";
                ListSpellsAvailable.Items.Add("Blade Ward");
            }

            else if (ThisToon.Class == "Cleric")
            {
                ListSpellsAvailable.Items.Add("");

                if (ThisToon.Domain == "Knowledge")
                {
                    this.Text = "Spell selection (Cleric - Knowledge)";
                    ListSelectedSpells.Items.Add("");
                }
                else if (ThisToon.Domain == "Light")
                {
                    this.Text = "Spell selection (Cleric - Light)";
                    ListSelectedSpells.Items.Add("Light");
                }
                else if (ThisToon.Domain == "Life")
                {
                    this.Text = "Spell selection (Cleric - Life)";
                    ListSelectedSpells.Items.Add("");
                }
                else if (ThisToon.Domain == "Nature")
                {
                    this.Text = "Spell selection (Cleric - Nature)";
                    ListSelectedSpells.Items.Add("");
                }
                else if (ThisToon.Domain == "Tempest")
                {
                    this.Text = "Spell selection (Cleric - Tempest)";
                    ListSelectedSpells.Items.Add("");
                }
                else if (ThisToon.Domain == "Trickery")
                {
                    this.Text = "Spell selection (Cleric - Trickery)";
                    ListSelectedSpells.Items.Add("");
                }
                else if (ThisToon.Domain == "War")
                {
                    this.Text = "Spell selection (Cleric - War)";
                    ListSelectedSpells.Items.Add("");
                }
            }

            else if (ThisToon.Class == "Druid")
            {
                this.Text = "Spell selection (Druid)";
            }

            else if (ThisToon.Class == "Sorcerer")
            {
                this.Text = "Spell selection (Sorcerer)";
            }

            else if (ThisToon.Class == "Warlock")
            {
                this.Text = "Spell selection (Warlock)";
            }

            else if (ThisToon.Class == "Wizard")
            {
                this.Text = "Spell selection (Wizard)";
            }
        }

        public void InitialiseSpells()
        {
            Spell ThisSpell = new Spell(0, "Blade Ward", "You extend your hand and trace a sigil of warding in the air. Until the end of your next turn, you have resistance against bludgeoning, piercing, and slashing damage dealt by weapon attacks.", "Abjuration", false, 0, "1 round", true, true, false);
            AllSpells.Add("Blade Ward", ThisSpell);
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            ListSelectedSpells.Items.Add(ListSpellsAvailable.SelectedItem);
            ListSpellsAvailable.Items.Remove(ListSpellsAvailable.SelectedItem);
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            //EXCEPTIONS
            if (ThisToon.Class == "Cleric")
            {
                if (ThisToon.Domain == "Knowledge")
                {

                }
                else if (ThisToon.Domain == "Life")
                {

                }
                else if (ThisToon.Domain == "Light")
                {
                    if (ListSelectedSpells.GetItemText(ListSelectedSpells.SelectedItem) == "Light")
                    {
                        MessageBox.Show("This is a domain spell", "Cannot deselect spell");
                    }
                }
            }

            else if (ThisToon.SubRace == "Dark Elf")
            {
                if (ListSelectedSpells.GetItemText(ListSelectedSpells.SelectedItem) == "Dancing Lights")
                {
                    MessageBox.Show("This is a racial spell", "Cannot deselect spell");
                }
            }

            else if (ThisToon.Race == "Tiefling")
            {
                if (ListSelectedSpells.GetItemText(ListSelectedSpells.SelectedItem) == "Thaumaturgy")
                {
                    MessageBox.Show("This is a racial spell", "Cannot deselect spell");
                }
            }

            else if (ThisToon.SubRace == "Forest Gnome")
            {
                if (ListSelectedSpells.GetItemText(ListSelectedSpells.SelectedItem) == "Minor Illusion")
                {
                    MessageBox.Show("This is a racial spell", "Cannot deselect spell");
                }
            }

            else
            {
                ListSpellsAvailable.Items.Add(ListSelectedSpells.SelectedItem);
                ListSelectedSpells.Items.Remove(ListSelectedSpells.SelectedItem);
            }
        }

        private void ListSpellsAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListSelectedSpells.ClearSelected();
            TxtDisplayInfo.Clear();
            if (ListSpellsAvailable.GetItemText(ListSpellsAvailable.SelectedItem) == "Blade Ward")
            {
                TxtDisplayInfo.Text = @"Abjuration cantrip

Casting Time: 1 action
Range: Self
Components: V, S
Duration: 1 round

You extend your hand and trace a sigil of warding in the air. Until the end of your next turn, you have resistance against bludgeoning, piercing, and slashing damage dealt by weapon attacks.";
            }
            else if (ListSpellsAvailable.GetItemText(ListSpellsAvailable.SelectedItem) == "")
            {
                TxtDisplayInfo.Text = @"";
            }
        }

        private void ListSelectedSpells_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListSpellsAvailable.ClearSelected();
            TxtDisplayInfo.Clear();
            if (ListSpellsAvailable.GetItemText(ListSpellsAvailable.SelectedItem) == "Blade Ward")
            {
                TxtDisplayInfo.Text = @"Abjuration cantrip

Casting Time: 1 action
Range: Self
Components: V, S
Duration: 1 round

You extend your hand and trace a sigil of warding in the air. Until the end of your next turn, you have resistance against bludgeoning, piercing, and slashing damage dealt by weapon attacks.";
            }
            else if (ListSpellsAvailable.GetItemText(ListSpellsAvailable.SelectedItem) == "")
            {
                TxtDisplayInfo.Text = @"";
            }
        }
    }
}
