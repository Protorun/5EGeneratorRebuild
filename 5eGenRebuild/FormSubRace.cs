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
    public partial class FormSubRace : Form
    {
        Character ThisToon;

        public FormSubRace(Character NewToon)
        {
            InitializeComponent();
            ThisToon = NewToon;
        }

        private void FormSubRace_Load(object sender, EventArgs e)
        {
            if (ThisToon.Race == "Dragonborn")
            {
                BtnSub1.Text = "Black Dragonborn";
                BtnSub1.Visible = true;
                BtnSub2.Text = "Blue Dragonborn";
                BtnSub2.Visible = true;
                BtnSub3.Text = "Brass Dragonborn";
                BtnSub3.Visible = true;
                BtnSub4.Text = "Bronze Dragonborn";
                BtnSub4.Visible = true;
                BtnSub5.Text = "Copper Dragonborn";
                BtnSub5.Visible = true;
                BtnSub6.Text = "Gold Dragonborn";
                BtnSub6.Visible = true;
                BtnSub7.Text = "Green Dragonborn";
                BtnSub7.Visible = true;
                BtnSub8.Text = "Red Dragonborn";
                BtnSub8.Visible = true;
                BtnSub9.Text = "Silver Dragonborn";
                BtnSub9.Visible = true;
                BtnSub10.Text = "White Dragonborn";
                BtnSub10.Visible = true;
            }

            if (ThisToon.Race == "Dwarf")
            {
                BtnSub1.Text = "Hill Dwarf";
                BtnSub1.Visible = true;
                BtnSub2.Text = "Mountain Dwarf";
                BtnSub2.Visible = true;
            }

            if (ThisToon.Race == "Halfling")
            {
                BtnSub1.Text = "Lightfoot Halfling";
                BtnSub1.Visible = true;
                BtnSub2.Text = "Stout Halfling";
                BtnSub2.Visible = true;
            }

            if (ThisToon.Race == "Elf")
            {
                BtnSub1.Text = "High Elf";
                BtnSub1.Visible = true;
                BtnSub2.Text = "Wood Elf";
                BtnSub2.Visible = true;
                BtnSub3.Text = "Dark Elf";
                BtnSub3.Visible = true;
            }

            if (ThisToon.Race == "Gnome")
            {
                BtnSub1.Text = "Forest Gnome";
                BtnSub1.Visible = true;
                BtnSub2.Text = "Rock Gnome";
                BtnSub2.Visible = true;
            }
        }

        private void BtnSub1_Click(object sender, EventArgs e)
        {
            LblSelection.Text = BtnSub1.Text;
            if (BtnSub1.Text == "Black Dragonborn")
            {
                TxtDisplayInfo.Text = @"Breath Weapon
You can use your action to exhale destructive energy. It deals damage in an area according to your ancestry. When you use your breath weapon, all creatures in the area must make a saving throw, the type of which is determined by your ancestry. The DC of this saving throw is 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest. HBInstead, you may use your breath weapon a number of times equal to your Constitution modifier. You regain expended uses on a short or long rest.

Black - Acid - 5' by 30' line (Dex save)";
            }
            else if (BtnSub1.Text == "Hill Dwarf")
            {
                TxtDisplayInfo.Text = @"Ability Score Increase:
Your Wisdom score increases by 1.

Dwarven Toughness:
Your hit point maximum increases by 1, and it increases by 1 every time you gain a level.";
            }
            else if (BtnSub1.Text == "Lightfoot Halfling")
            {
                TxtDisplayInfo.Text = @"Ability Score Increase:
Your Charisma score increases by 1.

Naturally Stealthy:
You can attempt to hide even when you are only obscured by a creature that is at least one size larger than you.";
            }
            else if (BtnSub1.Text == "High Elf")
            {
                TxtDisplayInfo.Text = @"Ability Score Increase:
Your Intelligence score increases by 1.

Cantrip:
You know one cantrip of your choice from the Wizard spell list. Intelligence is your spellcasting ability for it.

Elf Weapon Training:
You have proficiency with the longsword, shortsword, shortbow, and longbow.

Extra Language:
You can read, speak, and write one additional language of your choice.";
            }
            else if (BtnSub1.Text == "Forest Gnome")
            {
                TxtDisplayInfo.Text = @"Ability Score Increase:
Your Dexterity score increases by 1.

Natural Illusionist:
You know the Minor Illusion cantrip. Intelligence is your spellcasting modifier for it.

Speak with Small Beasts:
Through sound and gestures, you may communicate simple ideas with Small or smaller beasts.";
            }
        }

        private void BtnSub2_Click(object sender, EventArgs e)
        {
            LblSelection.Text = BtnSub2.Text;
            if (BtnSub2.Text == "Blue Dragonborn")
            {
                TxtDisplayInfo.Text = @"Breath Weapon
You can use your action to exhale destructive energy. It deals damage in an area according to your ancestry. When you use your breath weapon, all creatures in the area must make a saving throw, the type of which is determined by your ancestry. The DC of this saving throw is 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest. HBInstead, you may use your breath weapon a number of times equal to your Constitution modifier. You regain expended uses on a short or long rest.

Blue - Lightning - 5' by 30' line (Dex save)";
            }
            else if (BtnSub2.Text == "Mountain Dwarf")
            {
                TxtDisplayInfo.Text = @"Ability Score Increase:
Your Strength score increases by 2.

Dwarven Armor Training:
You have proficiency with light and medium armor.";
            }
            else if (BtnSub2.Text == "Stout Halfling")
            {
                TxtDisplayInfo.Text = @"Ability Score Increase:
Your Constitution score increases by 1.

Stout Resilience:
You have advantage on saving throws against poison, and you have resistance to poison damage.";
            }
            else if (BtnSub2.Text == "Wood Elf")
            {
                TxtDisplayInfo.Text = @"Ability Score Increase:
Your Wisdom score increases by 1.

Elf Weapon Training:
You have proficiency with the longsword, shortsword, shortbow, and longbow.

Fleet of Foot:
Your base walking speed increases to 35 feet.

Mask of the Wild:
You can attempt to hide even when you are only lightly obscured by foliage, heavy rain, falling snow, mist, and other natural phenomena.";
            }
            else if (BtnSub2.Text == "Rock Gnome")
            {
                TxtDisplayInfo.Text = @"Ability Score Increase:
Your Constitution score increases by 1.

Artificer's Lore:
Whenever you make an Intelligence (History) check related to magical, alchemical, or technological items, you can add twice your proficiency bonus instead of any other proficiency bonus that may apply.

Tinker:
You have proficiency with artisan tools (tinker's tools). Using those tools, you can spend 1 hour and 10 gp worth of materials to construct a Tiny clockwork device (AC 5, 1 hp). The device ceases to function after 24 hours (unless you spend 1 hour repairing it to keep the device functioning), or when you use your action to dismantle it; at that time, you can reclaim the materials used to create it. You can have up to three such devices active at a time. When you create a device, choose one of the following options:

Clockwork Toy - This toy is a clockwork animal, monster, or person, such as a frog, mouse, bird, dragon, or soldier. When placed on the ground, the toy moves 5 feet across the ground on each of your turns in a random direction. It makes noises as appropriate to the creature it represents.
Fire Starter - The device produces a miniature flame, which you can use to light a candle, torch, or campfire. Using the device requires your action.
Music Box - When opened, this music box plays a single song at a moderate volume. The box stops playing when it reaches the song's end or when it is closed.

At your DM's discretion, you may make other objects with effects similar in power to these. The Prestidigitation cantrip is a good baseline for such effects.";
            }
        }

        private void BtnSub3_Click(object sender, EventArgs e)
        {
            LblSelection.Text = BtnSub3.Text;
            if (BtnSub3.Text == "Brass Dragonborn")
            {
                TxtDisplayInfo.Text = @"Breath Weapon
You can use your action to exhale destructive energy. It deals damage in an area according to your ancestry. When you use your breath weapon, all creatures in the area must make a saving throw, the type of which is determined by your ancestry. The DC of this saving throw is 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest. HBInstead, you may use your breath weapon a number of times equal to your Constitution modifier. You regain expended uses on a short or long rest.

Brass - Fire - 5' by 30' line (Dex save)";
            }
            else if (BtnSub3.Text == "Dark Elf")
            {
                TxtDisplayInfo.Text = @"Ability Score Increase:
Your Charisma score increases by 1.

Superior Darkvision:
Your darkvision has a range of 120 feet, instead of 60.

Sunlight Sensitivity:
You have disadvantage on attack rolls and Wisdom (Perception) checks that rely on sight when you, the target of the attack, or whatever you are trying to perceive is in direct sunlight.

Drow Magic:
You know the Dancing Lights cantrip. When you reach 3rd level, you can cast the Faerie Fire spell once with this trait and regain the ability to do so when you finish a long rest. When you reach 5th level, you can cast the Darkness spell onceand regain the ability to do so when you finish a long rest. Charisma is your spellcasting ability for these spells.

Drow Weapon Training:
You have proficiency with rapiers, shortswords, and hand crossbows.";
            }
        }

        private void BtnSub4_Click(object sender, EventArgs e)
        {
            LblSelection.Text = BtnSub4.Text;
            if (BtnSub4.Text == "Bronze Dragonborn")
            {
                TxtDisplayInfo.Text = @"Breath Weapon
You can use your action to exhale destructive energy. It deals damage in an area according to your ancestry. When you use your breath weapon, all creatures in the area must make a saving throw, the type of which is determined by your ancestry. The DC of this saving throw is 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest. HBInstead, you may use your breath weapon a number of times equal to your Constitution modifier. You regain expended uses on a short or long rest.

Bronze - Lightning - 5' by 30' line (Dex save)";
            }
        }

        private void BtnSub5_Click(object sender, EventArgs e)
        {
            LblSelection.Text = BtnSub5.Text;
            if (BtnSub5.Text == "Copper Dragonborn")
            {
                TxtDisplayInfo.Text = @"Breath Weapon
You can use your action to exhale destructive energy. It deals damage in an area according to your ancestry. When you use your breath weapon, all creatures in the area must make a saving throw, the type of which is determined by your ancestry. The DC of this saving throw is 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest. HBInstead, you may use your breath weapon a number of times equal to your Constitution modifier. You regain expended uses on a short or long rest.

Copper - Acid - 5' by 30' line (Dex save)";
            }
        }

        private void BtnSub6_Click(object sender, EventArgs e)
        {
            LblSelection.Text = BtnSub6.Text;
            if (BtnSub6.Text == "Gold Dragonborn")
            {
                TxtDisplayInfo.Text = @"Breath Weapon
You can use your action to exhale destructive energy. It deals damage in an area according to your ancestry. When you use your breath weapon, all creatures in the area must make a saving throw, the type of which is determined by your ancestry. The DC of this saving throw is 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest. HBInstead, you may use your breath weapon a number of times equal to your Constitution modifier. You regain expended uses on a short or long rest.

Gold - Fire - 15' cone (CON save)";
            }
        }

        private void BtnSub7_Click(object sender, EventArgs e)
        {
            LblSelection.Text = BtnSub7.Text;
            if (BtnSub7.Text == "Green Dragonborn")
            {
                TxtDisplayInfo.Text = @"Breath Weapon
You can use your action to exhale destructive energy. It deals damage in an area according to your ancestry. When you use your breath weapon, all creatures in the area must make a saving throw, the type of which is determined by your ancestry. The DC of this saving throw is 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest. HBInstead, you may use your breath weapon a number of times equal to your Constitution modifier. You regain expended uses on a short or long rest.

Green - Poison - 15' cone (CON save)";
            }
        }

        private void BtnSub8_Click(object sender, EventArgs e)
        {
            LblSelection.Text = BtnSub8.Text;
            if (BtnSub8.Text == "Red Dragonborn")
            {
                TxtDisplayInfo.Text = @"Breath Weapon
You can use your action to exhale destructive energy. It deals damage in an area according to your ancestry. When you use your breath weapon, all creatures in the area must make a saving throw, the type of which is determined by your ancestry. The DC of this saving throw is 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest. HBInstead, you may use your breath weapon a number of times equal to your Constitution modifier. You regain expended uses on a short or long rest.

Red - Fire - 15' cone (CON save)";
            }
        }

        private void BtnSub9_Click(object sender, EventArgs e)
        {
            LblSelection.Text = BtnSub9.Text;
            if (BtnSub9.Text == "Silver Dragonborn")
            {
                TxtDisplayInfo.Text = @"Breath Weapon
You can use your action to exhale destructive energy. It deals damage in an area according to your ancestry. When you use your breath weapon, all creatures in the area must make a saving throw, the type of which is determined by your ancestry. The DC of this saving throw is 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest. HBInstead, you may use your breath weapon a number of times equal to your Constitution modifier. You regain expended uses on a short or long rest.

Silver - Cold - 15' cone (CON save)";
            }
        }

        private void BtnSub10_Click(object sender, EventArgs e)
        {
            LblSelection.Text = BtnSub10.Text;
            if (BtnSub10.Text == "White Dragonborn")
            {
                TxtDisplayInfo.Text = @"Breath Weapon
You can use your action to exhale destructive energy. It deals damage in an area according to your ancestry. When you use your breath weapon, all creatures in the area must make a saving throw, the type of which is determined by your ancestry. The DC of this saving throw is 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest. HBInstead, you may use your breath weapon a number of times equal to your Constitution modifier. You regain expended uses on a short or long rest.

White - Cold - 15' cone (CON save)";
            }
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            ThisToon.SetSubRace(ThisToon, LblSelection.Text);
            if (ThisToon.SubRace == "Wood Elf")
            {
                ThisToon.Speed = 35;
            }

            if (ThisToon.SubRace != " - ")
            {
                this.Hide();
                FormNewToon NewToonMenu = new FormNewToon(ThisToon);
                NewToonMenu.Show();
            }
            else
            {
                MessageBox.Show("Please select a subrace", "No subrace selected");
            }
        }

    }
}
