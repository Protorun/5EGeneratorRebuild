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
    public partial class FormRace : Form
    {
        Character ThisToon;

        public FormRace(Character NewToon)
        {
            InitializeComponent();
            ThisToon = NewToon;
        }

        private void FormRace_Load(object sender, EventArgs e)
        {

        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            List<string> racelist = new List<string> { "Human", "Half-Elf", "Tiefling", "Half-Orc" };
            foreach (string Race in racelist)
            {
                Console.WriteLine(Race);
            }
            Console.WriteLine(ThisToon.Race);
            if(racelist.Contains(ThisToon.Race))
            {
                Console.WriteLine("THIS SHOULD WORK");
                this.Hide();
                FormNewToon NewToonMenu = new FormNewToon(ThisToon);
                NewToonMenu.Show();
            }
            if(ThisToon.Race == "Half-Elf")
            {
                this.Hide();
                FormSelectAttribute AttributeSelection = new FormSelectAttribute(ThisToon);
                AttributeSelection.Show();
            }
            else
            {
                Console.WriteLine("THIS SHOUDN'T BE HAPPENING");
                this.Hide();
                FormSubRace SubRaceMenu = new FormSubRace(ThisToon);
                SubRaceMenu.Show();
            }
        }

        private void BtnHuman_Click(object sender, EventArgs e)
        {
            ThisToon.SetRace(ThisToon, "Human");
            ThisToon.SetSubRace(ThisToon, "No Subrace");
            LblSelection.Text = ThisToon.Race;
            ThisToon.Attributes["Strength"] = ThisToon.Attributes["Strength"] + 1;
            ThisToon.Attributes["Dexterity"] = ThisToon.Attributes["Dexterity"] + 1;
            ThisToon.Attributes["Constitution"] = ThisToon.Attributes["Constitution"] + 1;
            ThisToon.Attributes["Intelligence"] = ThisToon.Attributes["Intelligence"] + 1;
            ThisToon.Attributes["Wisdom"] = ThisToon.Attributes["Wisdom"] + 1;
            ThisToon.Attributes["Charisma"] = ThisToon.Attributes["Charisma"] + 1;
            TxtDisplayInfo.Text = @"Ability Score Increase
Your ability scores each increase by 1.

Age
Humans reach adulthood in their late teens and live less than a century.

Alignment
Humans tend toward no particular alignment. The best and the worst are found among them.

Size
Humans vary widely in height and build, from barely 5 feet to well over 6 feet tall. Regardless of your position in that range, your size is Medium.

Speed
Your base walking speed is 30 feet.

Languages
You can speak, read, and write Common and one extra language of your choice. Humans typically learn the languages of other peoples they deal with, including obscure dialects. They are fond of sprinkling their speech with words borrowed from other tongues: Orc curses, Elvish musical expressions, Dwarvish military phrases, and so on.";
        }

        private void BtnElf_Click(object sender, EventArgs e)
        {
            ThisToon.SetRace(ThisToon, "Elf");
            LblSelection.Text = ThisToon.Race;
            TxtDisplayInfo.Text = @"Ability Score Increase
Your Dexterity score increases by 2.

Age
Although elves reach physical maturity at about the same age as humans, the elven understanding of adulthood goes beyond physical growth to encompass worldly experience. An elf typically claims adulthood and an adult name around the age of 100 and can live to be 750 years old.

Alignment
Elves love freedom, variety, and self-expression, so they lean strongly towards the gentler aspects of chaos. They value and protect others' freedom as well as their own, and are good more often than not. Drow are an exception; their exile into the Underdark has made them vicious and dangerous. Drow are more often evil than not.

Size
Elves range from under 5 to over 6 feet tall and have slender builds. Your size is Medium.

Speed
Your base walking speed is 30 feet.

Darkvision
Accustomed to twilit forests and the night sky, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can't discern color in darkness, only shades of gray.

Fey Ancestry
You have advantage on saving throws against being charmed, and magic can't put you to sleep.

Trance
Elves do not sleep. Instead they meditate deeply, remaining semi-conscious, for 4 hours a day. The Common word for this meditation is trance. While meditating, you dream after a fashion; such dreams are actually mental exercises that have become reflexive after years of practice. After resting in this way, you gain the same benefit a human would from 8 hours of sleep.

Keen Senses
You have proficiency in the Perception skill.

Languages
You can speak, read, and write Common and Elven.";
        }

        private void BtnHalfElf_Click(object sender, EventArgs e)
        {
            ThisToon.SetRace(ThisToon, "Half-Elf");
            ThisToon.SetSubRace(ThisToon, "No Subrace");
            LblSelection.Text = ThisToon.Race;
            ThisToon.Attributes["Charisma"] = ThisToon.Attributes["Charisma"] + 2;

            // ALLOW SELECTION OF WHICH 2 ABILITY SCORES ARE INCREASED
            FormSelectAttribute AttributeSelection = new FormSelectAttribute(ThisToon);
            AttributeSelection.Show();

            TxtDisplayInfo.Text = @"Ability Score Increase
Your Charisma score increases by 2, and two other ability scores of your choice each increase by 1.

Age
Half-elves age at much the same rate as humans, reaching adulthood at the age of 20. They live much longer than humans, however, often exceeding 180 years.

Alignment
Half-elves share the chaotic bent of their elven heritage. They both value personal freedom and creative expression, demonstrating neither love of leaders nor desire for followers. They chafe at rules, resent others' demands, and sometimes prove unreliable, or at least unpredictable. They are good and evil in equal numbers, a trait they share with their human parents.

Size
Half-elves are more or less the same size as humans, ranging from 5 to 6 feet tall. Your size is Medium.

Speed
Your base walking speed is 30 feet.

Darkvision
Thanks to your elven heritage, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can't discern color in darkness, only shades of gray.

Fey Ancestry
You have advantage on saving throws against being charmed, and magic can't put you to sleep.

Languages
You can read, speak, and write Common, Elven, and one language of your choice.

Half-Elf Versatility
You gain proficiency in two skills of your choice.";
        }

        private void BtnDwarf_Click(object sender, EventArgs e)
        {
            ThisToon.SetRace(ThisToon, "Dwarf");
            LblSelection.Text = ThisToon.Race;
        }

        private void BtnDragonborn_Click(object sender, EventArgs e)
        {
            ThisToon.SetRace(ThisToon, "Dragonborn");
            LblSelection.Text = ThisToon.Race;
            TxtDisplayInfo.Text = @"Ability Score Increase
Your Strength score increases by 2, and your Charisma score increases by 1.

Damage Resistance
You have resistance to the damage type associated with your ancestry.

Age
Young dragonborn grow quickly. They walk hours after hatching, attain the size and development of a 10-year-old human child by the age of 3, and reach adulthood by 15. They live to be around 80.

Alignment
Dragonborn tend towards extremes, making a conscious choice for one side or the other between Good and Evil (represented by Bahamut and Tiamat, respectively). More side with Bahamut than Tiamat (whose non-dragon followers are mostly kobolds), but villainous dragonborn can be quite terrible indeed. Some rare few choose to devote themselves to lesser dragon deities, such as Chronepsis (Neutral), and fewer still choose to worship Io, the Ninefold Dragon, who is all alignments at once.

Size
Dragonborn are taller and heavier than humans, standing well over 6 feet tall and averaging almost 250 pounds. Your size is Medium.

Speed
Your base walking speed is 30 feet.

Breath Weapon
You can use your action to exhale destructive energy. It deals damage in an area according to your ancestry. When you use your breath weapon, all creatures in the area must make a saving throw, the type of which is determined by your ancestry. The DC of this saving throw is 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest. HBInstead, you may use your breath weapon a number of times equal to your Constitution modifier. You regain expended uses on a short or long rest.

Languages
You can read, speak, and write Common and Draconic.

Draconic Ancestry
You are distantly related to a particular kind of dragon. Choose a type of dragon from the below list; this determines the damage and area of your breath weapon, and the type of damage resistance you gain.

Black - Acid - 5' by 30' line (Dex save)
Blue - Lightning - 5' by 30' line (Dex save)
Brass - Fire - 5' by 30' line (Dex save)
Bronze - Lightning - 5' by 30' line (Dex save)
Copper - Acid - 5' by 30' line (Dex save)
Gold - Fire - 15' cone (CON save)
Green - Poison - 15' cone (CON save)
Red - Fire - 15' cone (CON save)
Silver - Cold - 15' cone (CON save)
White - Cold - 15' cone (CON save)";

        }

        private void BtnTiefling_Click(object sender, EventArgs e)
        {
            ThisToon.SetRace(ThisToon, "Tiefling");
            ThisToon.SetSubRace(ThisToon, "No Subrace");
            LblSelection.Text = ThisToon.Race;
        }

        private void BtnHalfling_Click(object sender, EventArgs e)
        {
            ThisToon.SetRace(ThisToon, "Halfling");
            LblSelection.Text = ThisToon.Race;
        }

        private void TxtDisplayInfo_TextChanged(object sender, EventArgs e)
        {
            TxtDisplayInfo.ScrollToCaret();
        }

        private void BtnHalfOrc_Click(object sender, EventArgs e)
        {
            ThisToon.SetRace(ThisToon, "Half-Orc");
            ThisToon.SetSubRace(ThisToon, "No Subrace");
            LblSelection.Text = ThisToon.Race;
            ThisToon.Attributes["Strength"] = ThisToon.Attributes["Strength"] + 2;
            ThisToon.Attributes["Constitution"] = ThisToon.Attributes["Constitution"] + 1;
            TxtDisplayInfo.Text = @"Ability Score Increase
Your Strength score increases by 2, and your Constitution score increases by 1.

Age
Half-orcs mature a little faster than humans, reaching adulthood around age 14. They age noticeably faster and rarely live longer than 75 years.

Alignment
Half-orcs inherit a tendency toward chaos from their orc parents and are not strongly inclined toward good. Half-orcs raised among orcs and willing to live out their lives among them are usually evil.

Size
Half-orcs are somewhat larger and bulkier than humans, and they range from 5 to well over 6 feet tall. Your size is Medium.

Speed
Your base walking speed is 30 feet.

Darkvision
Thanks to your orc blood, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can't discern color in darkness, only shades of gray.

Menacing
You gain proficiency in the Intimidation skill.

Relentless Endurance
When you are reduced to 0 hit points but not killed outright, you can drop to 1 hit point instead. You can't use this feature again until you finish a long rest.

Savage Attacks
When you score a critical hit with a melee weapon attack, you can roll one of the weapon's damage dice one additional time and add it to the extra damage of the critical hit.

Languages
You can speak, read, and write Common and Orc. Orc is a harsh, grating language with hard consonants. It has no script of its own but is written in the Dwarvish script.";
        }

        private void BtnGnome_Click(object sender, EventArgs e)
        {
            ThisToon.SetRace(ThisToon, "Gnome");
            LblSelection.Text = ThisToon.Race;
            ThisToon.Attributes["Intelligence"] = ThisToon.Attributes["Intelligence"] + 2;
            TxtDisplayInfo.Text = @"Ability Score Increase
Your Intelligence score increases by 2.

Age
Gnomes mature at the same rate as humans, and most are expected to settle into adult life around the age of 40. They can live to 350 years on average, but it's not too uncommon for them to reach 500 years of age.

Alignment
Gnomes are generally Good. Those who tend towards Law are sages, engineers, researchers, scholars, investigators, or inventors. Those who tend towards Chaos are often minstrels, tricksters, wanderers, or fanciful jewelers. Gnomes are light-hearted, and even the tricksters amongst them favor harmless pranks over vicious schemes.

Size
Gnomes are between 3 and 4 feet tall and weigh around 40 pounds. Your size is Small.

Speed
Your base walking speed is 25 feet.

Darkvision
Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can't discern color in darkness, only shades of gray.

Gnome Cunning
You have advantage on all Intelligence, Wisdom, and Charisma saves against magic.

Languages
You can read, speak, and write Common and Gnomish.";
        }
    }
}
