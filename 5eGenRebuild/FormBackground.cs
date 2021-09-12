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
    public partial class FormBackground : Form
    {
        Character ThisToon;
        int RemainingLanguages, MaxLanguages, RemainingInstruments, MaxInstruments, MaxGaming, MaxArtisan, MonkOption;
        List<ComboBox> AllCombos = new List<ComboBox>();
        List<ComboBox> InstrumentCombos = new List<ComboBox>();
        List<ComboBox> LanguageCombos = new List<ComboBox>();

        public FormBackground(Character NewToon)
        {
            InitializeComponent();
            ThisToon = NewToon;
            ThisToon.BackgroundItems.Clear();
            ThisToon.Languages.Clear();
            ThisToon.Languages.Add("Common");
            MaxLanguages = MaxInstruments = MaxGaming = MaxArtisan = MonkOption = 0;
            AllCombos.Add(ComboLanguage1);
            AllCombos.Add(ComboLanguage2);
            AllCombos.Add(ComboLanguage3);
            AllCombos.Add(ComboArtisan);
            AllCombos.Add(ComboGaming);
            AllCombos.Add(ComboInstrument1);
            AllCombos.Add(ComboInstrument2);
            AllCombos.Add(ComboInstrument3);
            AllCombos.Add(ComboInstrument4);

            InstrumentCombos.Add(ComboInstrument1);
            InstrumentCombos.Add(ComboInstrument2);
            InstrumentCombos.Add(ComboInstrument3);
            InstrumentCombos.Add(ComboInstrument4);

            LanguageCombos.Add(ComboLanguage1);
            LanguageCombos.Add(ComboLanguage2);
            LanguageCombos.Add(ComboLanguage3);

            DisableAllCombos();
            CalculateLanguageOptions();
            SetNumbers();
            UpdateNumberLabels();
        }

        private void FormBackground_Load(object sender, EventArgs e)
        {

        }

        private void SetupBackground()
        {
            string Selected = ListBackgrounds.SelectedItem.ToString();
            switch (Selected)
            {
                case "Acolyte":
                    ThisToon.Background = "Acolyte";
                    //ThisToon.SkillProfs.Add("Insight");
                    //ThisToon.SkillProfs.Add("Religion");
                    ThisToon.AddToInventory("Holy Symbol", 1);
                    ThisToon.AddToInventory("Sticks of incense", 5);
                    ThisToon.AddToInventory("Vestment", 1);
                    ThisToon.AddToInventory("Common clothes", 1);
                    ThisToon.Money["Gold"] = 15;
                    break;
                case "Charlatan":
                    ThisToon.Background = "Charlatan";
                    //ThisToon.SkillProfs.Add("Deception");
                    //ThisToon.SkillProfs.Add("Sleight of Hand");
                    ThisToon.ToolProfs.Add("Disguise kit");
                    ThisToon.ToolProfs.Add("Forgery kit");
                    ThisToon.AddToInventory("Fine clothes", 1);
                    ThisToon.AddToInventory("Disguise kit", 1);
                    ThisToon.AddToInventory("Con artist's trinkets", 1);
                    ThisToon.Money["Gold"] = 15;
                    break;
                case "Criminal":
                    ThisToon.Background = "Criminal";
                    //ThisToon.SkillProfs.Add("Deception");
                    //ThisToon.SkillProfs.Add("Stealth");
                    ThisToon.ToolProfs.Add("Thieves' tools");
                    ThisToon.AddToInventory("Crowbar", 1);
                    ThisToon.AddToInventory("Common clothes - dark with hood", 1);
                    ThisToon.Money["Gold"] = 15;
                    break;
                case "Entertainer":
                    ThisToon.Background = "Entertainer";
                    //ThisToon.SkillProfs.Add("Acrobatics");
                    //ThisToon.SkillProfs.Add("Performance");
                    ThisToon.ToolProfs.Add("Disguise kit");
                    ThisToon.AddToInventory("Favor of an admirer", 1);
                    ThisToon.AddToInventory("Costume", 1);
                    ThisToon.Money["Gold"] = 15;
                    break;
                case "Folk Hero":
                    ThisToon.Background = "Folk Hero";
                    //ThisToon.SkillProfs.Add("Animal Handling");
                    //ThisToon.SkillProfs.Add("Survival");
                    ThisToon.ToolProfs.Add("Vehicles (land)");
                    ThisToon.AddToInventory("Shovel", 1);
                    ThisToon.AddToInventory("Iron pot", 1);
                    ThisToon.AddToInventory("Common clothes", 1);
                    ThisToon.Money["Gold"] = 10;
                    break;
                case "Guild Artisan":
                    ThisToon.Background = "Guild Artisan";
                    //ThisToon.SkillProfs.Add("Insight");
                    //ThisToon.SkillProfs.Add("Persuasion");
                    ThisToon.AddToInventory("Letter of introduction", 1);
                    ThisToon.AddToInventory("Traveler's clothes", 1);
                    ThisToon.Money["Gold"] = 15;
                    break;
                case "Hermit":
                    ThisToon.Background = "Hermit";
                    //ThisToon.SkillProfs.Add("Medicine");
                    //ThisToon.SkillProfs.Add("Religion");
                    ThisToon.ToolProfs.Add("Herbalism kit");
                    ThisToon.AddToInventory("Scroll of notes/prayers", 1);
                    ThisToon.AddToInventory("Winter blanket", 1);
                    ThisToon.AddToInventory("Common clothes", 1);
                    ThisToon.AddToInventory("Herbalism kit", 1);
                    ThisToon.Money["Gold"] = 5;
                    break;
                case "Noble":
                    ThisToon.Background = "Noble";
                    //ThisToon.SkillProfs.Add("History");
                    //ThisToon.SkillProfs.Add("Persuasion");
                    ThisToon.AddToInventory("Fine clothes", 1);
                    ThisToon.AddToInventory("Signet ring", 1);
                    ThisToon.AddToInventory("Scroll of pedigree", 1);
                    ThisToon.Money["Gold"] = 25;
                    break;
                case "Outlander":
                    ThisToon.Background = "Outlander";
                    //ThisToon.SkillProfs.Add("Athletics");
                    //ThisToon.SkillProfs.Add("Survival");
                    ThisToon.AddToInventory("Staff", 1);
                    ThisToon.AddToInventory("Hunting trap", 1);
                    ThisToon.AddToInventory("Hunted animal trophy", 1);
                    ThisToon.AddToInventory("Traveler's clothes", 1);
                    ThisToon.Money["Gold"] = 10;
                    break;
                case "Sage":
                    ThisToon.Background = "Sage";
                    //ThisToon.SkillProfs.Add("Arcana");
                    //ThisToon.SkillProfs.Add("History");
                    ThisToon.AddToInventory("Bottle of ink", 1);
                    ThisToon.AddToInventory("Quill", 1);
                    ThisToon.AddToInventory("Small knife", 1);
                    ThisToon.AddToInventory("Letter posing unanswered question", 1);
                    ThisToon.AddToInventory("Common clothes", 1);
                    ThisToon.Money["Gold"] = 10;
                    break;
                case "Sailor":
                    ThisToon.Background = "Sailor";
                    //ThisToon.SkillProfs.Add("Athletics");
                    //ThisToon.SkillProfs.Add("Perception");
                    ThisToon.ToolProfs.Add("Navigator's tools");
                    ThisToon.ToolProfs.Add("Vehicles (water)");
                    ThisToon.AddToInventory("Belaying pin", 1);
                    ThisToon.AddToInventory("50ft rope", 1);
                    ThisToon.AddToInventory("Lucky charm", 1);
                    ThisToon.AddToInventory("Common clothes", 1);
                    ThisToon.Money["Gold"] = 10;
                    break;
                case "Soldier":
                    ThisToon.Background = "Soldier";
                    //ThisToon.SkillProfs.Add("Athletics");
                    //ThisToon.SkillProfs.Add("Intimidation");
                    ThisToon.ToolProfs.Add("Vehicles (land)");
                    ThisToon.AddToInventory("Insignia of rank", 1);
                    ThisToon.AddToInventory("Trophy from fallen enemy", 1);
                    ThisToon.AddToInventory("Common clothes", 1);
                    ThisToon.Money["Gold"] = 10;
                    break;
                case "Urchin":
                    ThisToon.Background = "Urchin";
                    //ThisToon.SkillProfs.Add("Sleight of Hand");
                    //ThisToon.SkillProfs.Add("Stealth");
                    ThisToon.ToolProfs.Add("Disguise kit");
                    ThisToon.ToolProfs.Add("Thieves' tools");
                    ThisToon.AddToInventory("Small knife", 1);
                    ThisToon.AddToInventory("Map of childhood city", 1);
                    ThisToon.AddToInventory("Pet mouse", 1);
                    ThisToon.AddToInventory("Token from parents", 1);
                    ThisToon.AddToInventory("Common clothes", 1);
                    ThisToon.Money["Gold"] = 10;
                    break;
            }
        }

        private void ClearCombos()
        {
            foreach (var thing in AllCombos)
            {
                //thing.ResetText();
                thing.SelectedItem = null;
            }
        }

        private void UpdateNumberLabels()
        {
            LblLanguage.Text = MaxLanguages.ToString();
            if (MaxLanguages > 1)
            {
                LblLanguagePlural.Text = "languages";
            }
            else if (MaxLanguages <= 1)
            {
                LblLanguagePlural.Text = "language";
            }
            LblInstrument.Text = MaxInstruments.ToString();
            if (MaxInstruments > 1)
            {
                LblInstrumentPlural.Text = "instruments";
            }
            else if (MaxInstruments <= 1)
            {
                LblInstrumentPlural.Text = "instrument";
            }
            LblArtisan.Text = MaxArtisan.ToString();
            LblGaming.Text = MaxGaming.ToString();
        }

        private void CalculateLanguageOptions()
        {
            string CharacterRace = ThisToon.Race;
            switch (CharacterRace)
            {
                case "Dragonborn":
                    ComboLanguage1.Items.Remove("Draconic");
                    ThisToon.Languages.Add("Draconic");
                    break;
                case "Dwarf":
                    ComboLanguage1.Items.Remove("Dwarvish");
                    ThisToon.Languages.Add("Dwarvish");
                    break;
                case "Elf":
                    ComboLanguage1.Items.Remove("Elvish");
                    ThisToon.Languages.Add("Elvish");
                    break;
                case "Gnome":
                    ComboLanguage1.Items.Remove("Gnomish");
                    ThisToon.Languages.Add("Gnomish");
                    break;
                case "Half-Elf":
                    ComboLanguage1.Items.Remove("Elvish");
                    ThisToon.Languages.Add("Elvish");
                    MaxLanguages = 1;
                    break;
                case "Half-Orc":
                    ComboLanguage1.Items.Remove("Orc");
                    ThisToon.Languages.Add("Orc");
                    break;
                case "Halfling":
                    ComboLanguage1.Items.Remove("Halfling");
                    ThisToon.Languages.Add("Halfling");
                    break;
                case "Tiefling":
                    ComboLanguage1.Items.Remove("Infernal");
                    ThisToon.Languages.Add("Infernal");
                    break;
            }

            foreach (var thing in ComboLanguage1.Items)
            {
                ComboLanguage2.Items.Add(thing);
                if (ComboLanguage3.Enabled == true)
                {
                    ComboLanguage3.Items.Add(thing);
                }
            }

            if (ThisToon.Class == "Druid")
            {
                ThisToon.AddLanguage("Druidic");
            }
            else if (ThisToon.Class == "Rogue")
            {
                ThisToon.AddLanguage("Thieves' Cant");
            }
        }

        private void DisableAllCombos()
        {
            foreach (var thing in AllCombos)
            {
                thing.Enabled = false;
            }
            if (ThisToon.Race == "Half-Elf")
            {
                ComboLanguage3.Visible = true;
                ComboLanguage3.Enabled = true;
            }
            if (ThisToon.Class == "Bard")
            {
                EnableInstruments(3);
            }
            else if (ThisToon.Class == "Monk")
            {
                EnableInstruments(1);
                ComboArtisan.Enabled = true;
            }
        }

        private void ListBackgrounds_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetNumbers();
            DisableAllCombos();
            string Selected = ListBackgrounds.SelectedItem.ToString();
            switch (Selected)
            {
                case "Acolyte":
                    TxtDisplayInfo.Text = @"You have spent your life in the service of a temple to a specific god or pantheon of gods. You act as an intermediary between the realm of the holy and the mortal world, performing sacred rites and offering sacrifices in order to conduct worshipers into the presence of the divine. You are not necessarily a cleric – performing sacred rites is not the same thing as channeling divine power.

Choose a god, a pantheon of gods, or some other quasi-divine being, and work with your DM to detail the nature of your religious service. Were you a lesser functionary in a temple, raised from childhood to assist the priests in the sacred rites? Or were you a high priest who suddenly experienced a call to serve your god in a different way? Perhaps you were the leader of a small cult outside of any established temple structure, or even an occult group that served a fiendish master that you now deny.

Skill Proficiencies: Insight, Religion
Tool Proficiencies: None
Languages: Two of your choice
Equipment: A holy symbol (a gift to you when you entered the priesthood), a prayer book or prayer wheel, 5 sticks of incense, vestments, a set of common clothes, and a pouch containing 15gp

Shelter of the Faithful
As an acolyte, you command the respect of those who share your faith, and you can perform the religious ceremonies of your deity. You and your adventuring companions can expect to receive free healing and care at a temple, shrine, or other established presence of your faith, though you must provide any material components needed for spells. Those who share your religion will support you (but only you) at a modest lifestyle.

You might also have ties to a specific temple dedicated to your chosen deity or pantheon, and you have a residence there. This could be the temple where you used to serve, if you remain on good terms with it, or a temple where you have found a new home. While near your temple, you can call upon the priests for assistance, provided the assistance you ask for is not hazardous and you remain in good standing with your temple.";
                    EnableLanguages(MaxLanguages);
                    break;
                case "Charlatan":
                    TxtDisplayInfo.Text = @"You have always had a way with people. You know what makes them tick, you can tease out their hearts' desires after a few minutes of conversation, and with a few leading questions you can read them like they were children's books. It's a useful talent, and one that you're perfectly willing to use for your advantage.

You know what people want and you deliver, or rather, you promise to deliver. Common sense should steer people away from things that sound too good to be true, but common sense seems to be in short supply when you're around. The bottle of pink colored liquid will surely cure that unseemly rash, this ointment – nothing more than a bit of fat with a sprinkle of silver dust can restore youth and vigor, and there's a bridge in the city that just happens to be for sale. These marvels sound implausible, but you make them sound like the real deal.

Skill Proficiencies: Deception, Sleight of Hand
Tool Proficiencies: Disguise kit, forgery kit
Languages: None
Equipment: A set of fine clothes, a disguise kit, tools of the con of your choice (ten stoppered bottles filled with colored liquid, a set of weighted dice, a deck of marked cards, or a signet ring of an imaginary duke), and a pouch containing 15gp

False Identity
You have created a second identity that includes documentation, established acquaintances, and disguises that allow you to assume that persona. Additionally, you can forge documents including official papers and personal letters, as long as you have seen an example of the kind of document or the handwriting you are trying to copy.";
                    break;
                case "Criminal":
                    TxtDisplayInfo.Text = @"You are an experienced criminal with a history of breaking the law. You have spent a lot of time among other criminals and still have contacts within the criminal underworld. You're far closer than most people to the world of murder, theft, and violence that pervades the underbelly of civilization, and you have survived up to this point by flouting the rules and regulations of society.

Skill Proficiencies: Deception, Stealth
Tool Proficiencies: One type of gaming set, thieves' tools
Languages: None
Equipment: A crowbar, a set of dark common clothes including a hood, and a pouch containing 15gp

Criminal Contact
You have a reliable and trustworthy contact who acts as your liaison to a network of other criminals. You know how to get messages to and from your contact, even over great distances; specifically, you know the local messengers, corrupt caravan masters, and seedy sailors who can deliver messages for you.";
                    ComboGaming.Enabled = true;
                    break;
                case "Entertainer":
                    TxtDisplayInfo.Text = @"You thrive in front of an audience. You know how to entrance them, entertain them, and even inspire them. Your poetics can stir the hearts of those who hear you, awakening grief or joy, laughter or anger. Your music raises their spirits or captures their sorrow. Your dance steps captivate, your humor cuts to the quick. Whatever techniques you use, your art is your life.

Skill Proficiencies: Acrobatics, Performance
Tool Proficiencies: Disguise kit, one type of musical instrument
Languages: None
Equipment: A musical instrument (one of your choice), the favor of an admirer (love letter, lock of hair, or trinket), a costume, and a pouch containing 15gp

By Popular Demand
You can always find a place to perform, usually in an inn or tavern but possibly with a circus, at a theater, or even in a noble's court. At such a place, you receive free lodging and food of a modest or comfortable standard (depending on the quality of the establishment), as long as you perform each night. In addition, your performance makes you something of a local figure. When strangers recognize you in a town where you have performed, they typically take a liking to you.";
                    EnableInstruments(MaxInstruments);
                    break;
                case "Folk Hero":
                    TxtDisplayInfo.Text = @"You come from a humble social rank, but you are destined for so much more. Already the people of your home village regard you as their champion, and your destiny calls you to stand against the tyrants and monsters that threaten the common folk everywhere.

Skill Proficiencies: Animal Handling, Survival
Tool Proficiencies: One type of artisan's tools, vehicles (land)
Languages: None
Equipment: A set of artisan's tools (one of your choice), a shovel, an iron pot, a set of common clothes, and a pouch containing 10gp

Rustic Hospitality
Since you come from the ranks of the common folk, you fit in among them with ease. You can find a place to hide, rest, or recuperate among other commoners, unless you have shown yourself to be a danger to them. They will shield you from the law or anyone else searching for you, though they will not risk their lives for you.";
                    ComboArtisan.Enabled = true;
                    break;
                case "Guild Artisan":
                    TxtDisplayInfo.Text = @"You are a member of an artisan's guild, skilled in a particular field and closely associated with other artisans. You are a well-established part of the mercantile world, freed by talent and wealth from the constraints of a feudal social order. You learned your skills as an apprentice to a master artisan, under the sponsorship of your guild, until you became a master in your own right.

Skill Proficiencies: Insight, Persuasion
Tool Proficiencies: One type of artisan's tools
Languages: One of your choice
Equipment: A set of artisan's tools (one of your choice), a letter of introduction from your guild, a set of traveler's clothes, and a pouch containing 15gp

Guild Membership
As an established and respected member of a guild, you can rely on certain benefits that membership provides. Your fellow guild members will provide you with lodging and food if necessary, and pay for your funeral if needed. In some cities and towns, a guildhall offers a central place to meet other members of your profession, which can be a good place to meet potential patrons, allies, or hirelings.

Guilds often wield tremendous political power. If you are accused of a crime, your guild will support you if a good case can be made for your innocence or the crime is justifiable. You can also gain access to powerful political figures through the guild, if you are a member in good standing. Such connections might require the donation of money or magic items to the guild's coffers.

You must pay dues of 5 gp per month to the guild. If you miss payments, you must make up back dues to remain in the guild's good graces.";
                    ComboArtisan.Enabled = true;
                    EnableLanguages(MaxLanguages);
                    break;
                case "Hermit":
                    TxtDisplayInfo.Text = @"You lived in seclusion – either in a sheltered community such as a monastery, or entirely alone – for a formative part of your life. In your time apart from the clamor of society, you found quiet, solitude, and perhaps some of the answers you were looking for.

Skill Proficiencies: Medicine, Religion
Tool Proficiencies: Herbalism kit
Languages: One of your choice
Equipment: A scroll case stuffed full of notes from your studies or prayers, a winter blanket, a set of common clothes, an herbalism kit, and 5gp

Discovery
The quiet seclusion of your extended hermitage gave you access to a unique and powerful discovery. The exact nature of this revelation depends on the nature of your seclusion. It might be a great truth about the cosmos, the deities, the powerful beings of the outer planes, or the forces of nature. It could be a site that no one else has ever seen. You might have uncovered a fact that has long been forgotten, or unearthed some relic of the past that could rewrite history. It might be information that would be damaging to the people who or consigned you to exile, and hence the reason for your return to society.

Work with your DM to determine the details of your discovery and its impact on the campaign.";
                    EnableLanguages(MaxLanguages);
                    break;
                case "Noble":
                    TxtDisplayInfo.Text = @"You understand wealth, power, and privilege. You carry a noble title, and your family owns land, collects taxes, and wields significant political influence. You might be a pampered aristocrat unfamiliar with work or discomfort, a former merchant just elevated to the nobility, or a disinherited scoundrel with a disproportionate sense of entitlement. Or you could be an honest, hard-working landowner who cares deeply about the people who live and work on your land, keenly aware of your responsibility to them.

Work with your DM to come up with an appropriate title and determine how much authority that title carries. A noble title doesn't stand on its own-it's connected to an entire family, and whatever title you hold, you will pass it down to your own children. Not only do you need to determine your noble title, but you should also work with the DM to describe your family and their influence on you.

Is your family old and established, or was your title only recently bestowed? How much influence do they wield, and over what area? What kind of reputation does your family have among the other aristocrats of the region? How do the common people regard them?

What's your position in the family? Are you the heir to the head of the family? Have you already inherited the title? How do you feel about that responsibility? Or are you so far down the line of inheritance that no one cares what you do, as long as you don't embarrass the family? How does the head of your family feel about your adventuring career? Are you in your family's good graces, or shunned by the rest of your family?

Does your family have a coat of arms? An insignia you might wear on a signet ring? Particular colors you wear all the time? An animal you regard as a symbol of your line or even a spiritual member of the family?

These details help establish your family and your title as features of the world of the campaign.

Skill Proficiencies: History, Persuasion
Tool Proficiencies: One type of gaming set
Languages: One of your choice
Equipment: A set of fine clothes, a signet ring, a scroll of pedigree, and a purse containing 25gp

Position of Privilege
Thanks to your noble birth, people are inclined to think the best of you. You are welcome in high society, and people assume you have the right to be wherever you are. The common folk make every effort to accommodate you and avoid your displeasure, and other people of high birth treat you as a member of the same social sphere. You can secure an audience with a local noble if you need to.";
                    ComboGaming.Enabled = true;
                    EnableLanguages(MaxLanguages);
                    break;
                case "Outlander":
                    TxtDisplayInfo.Text = @"You grew up in the wilds, far from civilization and the comforts of town and technology. You've witnessed the migration of herds larger than forests, survived weather more extreme than any city-dweller could comprehend, and enjoyed the solitude of being the only thinking creature for miles in any direction. The wilds are in your blood, whether you were a nomad, an explorer, a recluse, a hunter-gatherer, or even a marauder. Even in places where you don't know the specific features of the terrain, you know the ways of the wild.

Skill Proficiencies: Athletics, Survival
Tool Proficiencies: One type of musical instrument
Languages: One of your choice
Equipment: A staff, a hunting trap, a trophy from an animal you killed, a set of traveler's clothes, and a pouch containing 10gp

Wanderer
You have an excellent memory for maps and geography, and you can always recall the general layout of terrain, settlements, and other features around you. In addition, you can find food and fresh water for yourself and up to five other people each day, provided that the land offers berries, small game, water, and so forth.";
                    EnableInstruments(MaxInstruments);
                    EnableLanguages(MaxLanguages);
                    break;
                case "Sage":
                    TxtDisplayInfo.Text = @"You spent years learning the lore of the multiverse. You scoured manuscripts, studied scrolls, and listened to the greatest experts on the subjects that interest you. Your efforts have made you a master in your fields of study.

Skill Proficiencies: Arcana, History
Tool Proficiencies: None
Languages: Two of your choice
Equipment: A bottle of ink, a quill, a small knife, a letter from a dead colleague posing a question you have not yet been able to answer, a set of common clothes, and a pouch containing 10gp

Researcher
When you attempt to learn or recall a piece of lore, if you do not know that information, you often know where and from whom you can obtain it. Usually, this information comes from a library, scriptorium, university, or a sage or other learned person or creature. Your DM might rule that the knowledge you seek is secreted away in an almost inaccessible place, or that it simply cannot be found. Unearthing the deepest secrets of the multiverse can require an adventure or even a whole campaign.";
                    EnableLanguages(MaxLanguages);
                    break;
                case "Sailor":
                    TxtDisplayInfo.Text = @"You sailed on a seagoing vessel for years. In that time, you faced down mighty storms, monsters of the deep, and those who wanted to sink your craft to the bottomless depths. Your first love is the distant line of the horizon, but the time has come to try your hand at something new.

Discuss the nature of the ship you previously sailed with your DM. Was it a merchant ship, a naval vessel, a ship of discovery, or a pirate ship? How famous (or infamous) is it? Is it widely traveled? Is it still sailing, or is it missing and presumed lost with all hands?

What were your duties on board – boatswain, captain, navigator, cook, or some other position? Who were the captain and first mate? Did you leave your ship on good terms with your fellows, or on the run?

Skill Proficiencies: Athletics, Perception
Tool Proficiencies: Navigator's tools, vehicles (water)
Languages: None
Equipment: A belaying pin (club), 50 feet of silk rope, a lucky charm such as a rabbit foot or a small stone with a hole in the center (or you may roll for a random trinket on the Trinkets table in chapter 5), a set of common clothes, and a pouch containing 10gp

Ship's Passage
When you need to, you can secure free passage on a sailing ship for yourself and your adventuring companions. You might sail on the ship you served on, or another ship you have good relations with (perhaps one captained by a former crewmate). Because you're calling in a favor, you can't be certain of a schedule or route that will meet your every need. Your DM will determine how long it takes to get where you need to go. In return for your free passage, you and your companions are expected to assist the crew during the voyage.";
                    break;
                case "Soldier":
                    TxtDisplayInfo.Text = @"War has been your life for as long as you care to remember. You trained as a youth, studied the use of weapons and armor, learned basic survival techniques, including how to stay alive on the battlefield. You might have been part of a standing national army or a mercenary company, or perhaps a member of a local militia who rose to prominence during a recent war.

When you choose this background, work with your DM to determine which military organization you were a part of, how far through its ranks you progressed, and what kind of experiences you had during your military career. Was it a standing army, a town guard, or a village militia? Or it might have been a noble's or merchant's private army, or a mercenary company.

Skill Proficiencies: Athletics, Intimidation
Tool Proficiencies: One type of gaming set, vehicles (land)
Languages: None
Equipment: An insignia of rank, a trophy taken from a fallen enemy (a dagger, broken blade, or piece of a banner), a set of bone dice or a deck of cards, a set of common clothes, and a pouch containing 10gp

Military Rank
You have a military rank from your career as a soldier. Soldiers loyal to your former military organization still recognize your authority and influence, and they defer to you if they are of a lower rank. You can invoke your rank to exert influence over other soldiers and requisition simple equipment or horses for temporary use. You can also usually gain access to friendly military encampments and fortresses where your rank is recognized.";
                    ComboGaming.Enabled = true;
                    break;
                case "Urchin":
                    TxtDisplayInfo.Text = @"You grew up on the streets alone, orphaned, and poor, You had no one to watch over you or to provide for you, so you learned to provide for yourself. You fought fiercely over food and kept a constant watch out for other desperate souls who might steal from you. You slept on rooftops and in alleyways, exposed to the elements, and endured sickness without the advantage of medicine or a place to recuperate. You've survived despite all odds, and did so through cunning, strength, speed, or some combination of each.

You begin your adventuring career with enough money to live modestly but securely for at least ten days. How did you come by that money? What allowed you to break free of your desperate circumstances and embark on a better life?

Skill Proficiencies: Sleight of Hand, Stealth
Tool Proficiencies: Disguise kit, thieves' tools
Languages: None
Equipment: A small knife, a map of the city you grew up in, a pet mouse, a token to remember your parents by, a set of common clothes, and a pouch containing 10gp

City Secrets
You know the secret patterns and flow to cities and can find passages through the urban sprawl that others would miss. When you are not in combat, you (and companions you lead) can travel between any two locations in the city twice as fast as your speed would normally allow.";
                    break;
            }
            SetNumbers();
            ClearCombos();
            UpdateNumberLabels();
        }

        private void SetNumbers()
        {
            MaxLanguages = MaxInstruments = MaxGaming = MaxArtisan = 0;

            if (ThisToon.Class == "Bard")
             {
                 MaxInstruments = 3;
             }
            else if (ThisToon.Class == "Monk")
             {
                 MonkOption = 1;
             }

            if (ThisToon.Race == "Half-Elf")
            {
                MaxLanguages = 1;
            }

            switch (ListBackgrounds.SelectedItem)
            {
                case "Acolyte":
                    MaxLanguages += 2;
                    break;
                case "Criminal":
                    MaxGaming += 1;
                    break;
                case "Entertainer":
                    MaxInstruments += 1;
                    break;
                case "Folk Hero":
                    MaxArtisan += 1;
                    break;
                case "Guild Artisan":
                    MaxArtisan += 1;
                    MaxLanguages += 1;
                    break;
                case "Hermit":
                    MaxLanguages += 1;
                    break;
                case "Noble":
                    MaxGaming += 1;
                    MaxLanguages += 1;
                    break;
                case "Outlander":
                    MaxInstruments += 1;
                    MaxLanguages += 1;
                    break;
                case "Sage":
                    MaxLanguages += 2;
                    break;
                case "Soldier":
                    MaxGaming += 1;
                    break;
            }
        }

        private void ComboLanguage1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboLanguage1.SelectedItem != null)
            {
                LblLanguage.Text = (MaxLanguages - CountLanguages()).ToString();
            }
            else if (ComboLanguage1.SelectedItem == null)
            {
                LblLanguage.Text = (MaxLanguages - CountLanguages()).ToString();
            }

            if (ComboLanguage2.SelectedItem == null || ComboLanguage2.SelectedItem == ComboLanguage1.SelectedItem)
            {
                ComboLanguage2.Items.Clear();
                foreach (var thing in ComboLanguage1.Items)
                {
                    if (thing != ComboLanguage1.SelectedItem)
                    {
                        ComboLanguage2.Items.Add(thing);

                    }
                }
            }

            if (ComboLanguage3.SelectedItem == null || ComboLanguage3.SelectedItem == ComboLanguage1.SelectedItem)
            {
                ComboLanguage3.Items.Clear();
                foreach (var thing in ComboLanguage1.Items)
                {
                    if (thing != ComboLanguage1.SelectedItem)
                    {
                        ComboLanguage3.Items.Add(thing);
                    }
                }
            }


        }

        private void ComboLanguage2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboLanguage2.SelectedItem != null)
            {
                LblLanguage.Text = (MaxLanguages - CountLanguages()).ToString();
            }
            else if (ComboLanguage2.SelectedItem == null)
            {
                LblLanguage.Text = (MaxLanguages - CountLanguages()).ToString();
            }

            if (ComboLanguage1.SelectedItem == null || ComboLanguage1.SelectedItem == ComboLanguage2.SelectedItem)
            {
                ComboLanguage1.Items.Clear();
                foreach (var thing in ComboLanguage2.Items)
                {
                    if (thing != ComboLanguage2.SelectedItem)
                    {
                        ComboLanguage1.Items.Add(thing);
                    }
                }
            }

            if (ComboLanguage3.SelectedItem == null || ComboLanguage3.SelectedItem == ComboLanguage2.SelectedItem)
            {
                ComboLanguage3.Items.Clear();
                foreach (var thing in ComboLanguage2.Items)
                {
                    if (thing != ComboLanguage2.SelectedItem)
                    {
                        ComboLanguage3.Items.Add(thing);
                    }
                }

            }
        }

        private void ComboLanguage3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboLanguage3.SelectedItem != null)
            {
                LblLanguage.Text = (MaxLanguages - CountLanguages()).ToString();
            }
            else if (ComboLanguage3.SelectedItem == null)
            {
                LblLanguage.Text = (MaxLanguages - CountLanguages()).ToString();
            }

            if (ComboLanguage1.SelectedItem == null || ComboLanguage1.SelectedItem == ComboLanguage3.SelectedItem)
            {
                ComboLanguage1.Items.Clear();
                foreach (var thing in ComboLanguage3.Items)
                {
                    if (thing != ComboLanguage3.SelectedItem)
                    {
                        ComboLanguage1.Items.Add(thing);
                    }
                }
            }

            if (ComboLanguage2.SelectedItem == null || ComboLanguage2.SelectedItem == ComboLanguage3.SelectedItem)
            {
                ComboLanguage2.Items.Clear();
                foreach (var thing in ComboLanguage3.Items)
                {
                    if (thing != ComboLanguage3.SelectedItem)
                    {
                        ComboLanguage2.Items.Add(thing);
                    }
                }

            }
        }

        private void ComboArtisan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboGaming_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboInstrument1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboInstrument1.SelectedItem != null)
            {
                MaxInstruments--;
                LblInstrument.Text = (MaxInstruments - CountInstruments()).ToString();
            }
            else if (ComboInstrument1.SelectedItem == null)
            {
                MaxInstruments++;
            }

            if (ComboInstrument2.SelectedItem == null || ComboInstrument2.SelectedItem == ComboInstrument1.SelectedItem)
            {
                ComboInstrument2.Items.Clear();
                foreach (var thing in ComboInstrument1.Items)
                {
                    if (thing != ComboInstrument1.SelectedItem)
                    {
                        ComboInstrument2.Items.Add(thing);
                    }
                }
            }

            if (ComboInstrument3.SelectedItem == null || ComboInstrument3.SelectedItem == ComboInstrument1.SelectedItem)
            {
                ComboInstrument3.Items.Clear();
                foreach (var thing in ComboInstrument1.Items)
                {
                    if (thing != ComboInstrument1.SelectedItem)
                    {
                        ComboInstrument3.Items.Add(thing);
                    }
                }
            }

            if (ComboInstrument4.SelectedItem == null || ComboInstrument4.SelectedItem == ComboInstrument1.SelectedItem)
            {
                ComboInstrument4.Items.Clear();
                foreach (var thing in ComboInstrument1.Items)
                {
                    if (thing != ComboInstrument1.SelectedItem)
                    {
                        ComboInstrument4.Items.Add(thing);
                    }
                }
            }
        }

        private void ComboInstrument2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboInstrument2.SelectedItem != null)
            {
                MaxInstruments--;
            }
            else if (ComboInstrument2.SelectedItem == null)
            {
                MaxInstruments++;
            }

            if (ComboInstrument1.SelectedItem == null || ComboInstrument1.SelectedItem == ComboInstrument2.SelectedItem)
            {
                ComboInstrument1.Items.Clear();
                foreach (var thing in ComboInstrument2.Items)
                {
                    if (thing != ComboInstrument2.SelectedItem)
                    {
                        ComboInstrument1.Items.Add(thing);
                    }
                }
            }

            if (ComboInstrument3.SelectedItem == null || ComboInstrument3.SelectedItem == ComboInstrument2.SelectedItem)
            {
                ComboInstrument3.Items.Clear();
                foreach (var thing in ComboInstrument2.Items)
                {
                    if (thing != ComboInstrument2.SelectedItem)
                    {
                        ComboInstrument3.Items.Add(thing);
                    }
                }
            }

            if (ComboInstrument4.SelectedItem == null || ComboInstrument4.SelectedItem == ComboInstrument2.SelectedItem)
            {
                ComboInstrument4.Items.Clear();
                foreach (var thing in ComboInstrument2.Items)
                {
                    if (thing != ComboInstrument2.SelectedItem)
                    {
                        ComboInstrument4.Items.Add(thing);
                    }
                }
            }

            UpdateNumberLabels();
        }

        private void ComboInstrument3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboInstrument3.SelectedItem != null)
            {
                MaxInstruments--;
            }
            else if (ComboInstrument3.SelectedItem == null)
            {
                MaxInstruments++;
            }

            if (ComboInstrument2.SelectedItem == null || ComboInstrument2.SelectedItem == ComboInstrument3.SelectedItem)
            {
                ComboInstrument2.Items.Clear();
                foreach (var thing in ComboInstrument3.Items)
                {
                    if (thing != ComboInstrument3.SelectedItem)
                    {
                        ComboInstrument2.Items.Add(thing);
                    }
                }
            }

            if (ComboInstrument1.SelectedItem == null || ComboInstrument1.SelectedItem == ComboInstrument3.SelectedItem)
            {
                ComboInstrument1.Items.Clear();
                foreach (var thing in ComboInstrument3.Items)
                {
                    if (thing != ComboInstrument3.SelectedItem)
                    {
                        ComboInstrument1.Items.Add(thing);
                    }
                }
            }

            if (ComboInstrument4.SelectedItem == null || ComboInstrument4.SelectedItem == ComboInstrument3.SelectedItem)
            {
                ComboInstrument4.Items.Clear();
                foreach (var thing in ComboInstrument3.Items)
                {
                    if (thing != ComboInstrument3.SelectedItem)
                    {
                        ComboInstrument4.Items.Add(thing);
                    }
                }
            }

            UpdateNumberLabels();
        }

        private void ComboInstrument4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboInstrument4.SelectedItem != null)
            {
                MaxInstruments--;
            }
            else if (ComboInstrument4.SelectedItem == null)
            {
                MaxInstruments++;
            }

            if (ComboInstrument2.SelectedItem == null || ComboInstrument2.SelectedItem == ComboInstrument1.SelectedItem)
            {
                ComboInstrument2.Items.Clear();
                foreach (var thing in ComboInstrument1.Items)
                {
                    if (thing != ComboInstrument1.SelectedItem)
                    {
                        ComboInstrument2.Items.Add(thing);
                    }
                }
            }

            if (ComboInstrument3.SelectedItem == null || ComboInstrument3.SelectedItem == ComboInstrument1.SelectedItem)
            {
                ComboInstrument3.Items.Clear();
                foreach (var thing in ComboInstrument1.Items)
                {
                    if (thing != ComboInstrument1.SelectedItem)
                    {
                        ComboInstrument3.Items.Add(thing);
                    }
                }
            }

            if (ComboInstrument1.SelectedItem == null || ComboInstrument1.SelectedItem == ComboInstrument4.SelectedItem)
            {
                ComboInstrument1.Items.Clear();
                foreach (var thing in ComboInstrument4.Items)
                {
                    if (thing != ComboInstrument4.SelectedItem)
                    {
                        ComboInstrument1.Items.Add(thing);
                    }
                }
            }

            UpdateNumberLabels();
        }

        private int CountLanguages()
        {
            int Total = 0;
            foreach(var thing in LanguageCombos)
            {
                if (thing.SelectedItem != null)
                {
                    Total++;
                }
            }
            return Total;
        }

        private int CountInstruments()
        {
            int Total = 0;
            foreach(var thing in InstrumentCombos)
            {
                if (thing.SelectedItem != null)
                {
                    Total++;
                }
            }
            return Total;
        }

        private void EnableLanguages(int Number)
        {
            for(int x = 0; x < Number; x++)
            {
                LanguageCombos[x].Enabled = true;
            }
        }

        private void EnableInstruments(int Number)
        {
            for (int x = 0; x < Number; x++)
            {
                InstrumentCombos[x].Enabled = true;
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            SetupBackground();
            Console.WriteLine(ThisToon.Background);
            this.Hide();
            Form MainMenu = new FormNewToon(ThisToon);
            MainMenu.Show();
        }
    }
}
