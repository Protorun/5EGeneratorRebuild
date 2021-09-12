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
    public partial class FormDomain : Form
    {
        Character ThisToon;

        public FormDomain(Character NewToon)
        {
            InitializeComponent();
            ThisToon = NewToon;
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            //SetDomainSpells(); METHOD DOESN'T CURRENTLY EXIST, MAYBE BUILD IT DEPENDING HOW SPELL SELECTION GOES
            ThisToon.Domain = LblSelection.Text;
            this.Hide();
            FormNewToon NewToonMenu = new FormNewToon(ThisToon);
            NewToonMenu.Show();
        }

        private void BtnKnowledge_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Knowledge";
            TxtDisplayInfo.Text = @"The gods of knowledge – including Oghma, Boccob, Gilean, Aureon, and Thoth – value learning and understanding above all. Some teach that knowledge is to be gathered and shared in libraries and universities, or promote the practical knowledge of craft and invention. Some deities hoard knowledge and keep its secrets to themselves. And some promise their followers that they will gain tremendous power if they unlock the secrets of the multiverse. Followers of these gods study esoteric lore, collect old tomes, delve into the secret places of the earth, and learn all they can. Some gods of knowledge promote the practical knowledge of craft and invention, including smith deities like Gond, Reorx, Onatar, Moradin, Hephaestus, and Goibhniu.

Knowledge Domain spells:
1st level - Command, Identify
3rd level - Augury, Suggestion
5th level - Nondetection, Speak with Dead
7th level - Arcane Eye, Confusion
9th level - Legend Lore, Scrying

Blessings of Knowledge
At 1st level, you learn two languages of your choice. You also become proficient in your choice of two of the following skills: Arcana, History, Nature, or Religion.

Your proficiency bonus is doubled for any ability check you make that uses either of those skills.

Channel Divinity: Knowledge of the Ages
Starting at 2nd level, you can use your Channel Divinity to tap into a divine well of knowledge. As an action, you choose one skill or tool. For 10 minutes, you have proficiency with the chosen skill or tool.

Channel Divinity: Read Thoughts
At 6th level, you can use your Channel Divinity to read a creature's thoughts. You can then use your access to the creature's mind to command it.

As an action, choose one creature that you can see within 60 feet of you. That creature must make a Wisdom saving throw. If the creature succeeds on the saving throw, you can't use this feature on it again until you finish a long rest.

If the creature fails its save, you can read its surface thoughts (those foremost in its mind, reflecting its current emotions and what it is actively thinking about) when it is within 60 feet of you. This effect lasts for 1 minute.

During that time, you can use your action to end this effect and cast the Suggestion spell on the creature without expending a spell slot. The target automatically fails its saving throw against the spell.

Potent Spellcasting
Starting at 8th level, you add your Wisdom modifier to the damage you deal with any cleric cantrip.

Visions of the Past
Starting at 17th level, you can call up visions of the past that relate to an object you hold or your immediate surroundings. You spend at least 1 minute in meditation and prayer, then receive dreamlike, shadowy glimpses of recent events. You can meditate in this way for a number of minutes equal to your Wisdom score and must maintain concentration during that time, as if you were casting a spell.

Once you use this feature, you can't use it again until you finish a short or long rest.

Object Reading:
Holding an object as you meditate, you can see visions of the object's previous owner. After meditating for 1 minute, you learn how the owner acquired and lost the object, as well as the most recent significant event involving the object and that owner. If the object was owned by another creature in the recent past (within a number of days equal to your Wisdom score), you can spend 1 additional minute for each owner to learn the same information about that creature.

Area Reading:
As you meditate, you see visions of recent events in your immediate vicinity (a room, street, tunnel, clearing, or the like, up to a 50-foot cube), going back a number of days equal to your Wisdom score. For each minute you meditate, you learn about one significant event, beginning with the most recent. Significant events typically involve powerful emotions, such as battles and betrayals, marriages and murders, births and funerals. However, they might also include more mundane events that are nevertheless important in your current situation.";
        }

        private void BtnLife_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Life";
            TxtDisplayInfo.Text = @"The Life domain focuses on the vibrant positive energy – one of the fundamental forces of the universe – that sustains all life. The gods of life promote vitality and health through healing the sick and wounded, caring for those in need, and driving away the forces of death and undeath. Almost any non-evil deity can claim influence over this domain, particularly agricultural deities (such as Chauntea, Arawai, and Demeter), sun gods (such as Lathander, Pelor, and Re-Horakhty), gods of healing or endurance (such as Ilmater, Mishakal, Apollo, and Diancecht), and gods of home and community (such as Hestia, Hathor, and Boldrci).

Life Domain spells:
1st level - Bless, Cure Wounds
3rd level - Lesser Restoration, Spiritual Weapon
5th level - Beacon of Hope, Revivify
7th level - Death Ward, Guardian of Faith
9th level - Mass Cure Wounds, Raise Dead

Bonus Proficiency
When you choose this domain at 1st level, you gain proficiency with heavy armor.

Disciple of Life
Also starting at 1st level, your healing spells are more effective. Whenever you use a spell of 1st level or higher to restore hit points to a creature, the creature regains additional hit points equal to 2 + the spell's level.

Channel Divinity: Preserve Life
Starting at 2nd level, you can use your Channel Divinity to heal the badly injured.

As an action, you present your holy symbol and evoke healing energy that can restore a number of hit points equal to five times your cleric level. Choose any creatures within 30 feet of you, and divide those hit points among them. This feature can restore a creature to no more than half of its hit point maximum. You can't use this feature on an undead or a construct.

Blessed Healer
Beginning at 6th level, the healing spells you cast on others heal you as well. When you cast a spell of 1st level or higher that restores hit points to a creature other than you, you regain hit points equal to 2 + the spell's level.

Divine Strike
At 8th level, you gain the ability to infuse your weapon strikes with divine energy. Once on each of your turns when you hit a creature with a weapon attack, you can cause the attack to deal an extra 1d8 radiant damage to the target. When you reach 14th level, the extra damage increases to 2d8.

Supreme Healing
Starting at 17th level, when you would normally roll one or more dice to restore hit points with a spell, you instead use the highest number possible for each die. For example, instead of restoring 2d6 hit points to a creature, you restore 12.";
        }

        private void BtnLight_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Light";
            TxtDisplayInfo.Text = @"Gods of light – including Helm, Lathander, Pholtus, Branchala, the Silver Flame, Belenus, Apollo, and Re-Horakhty – promote the ideals of rebirth and renewal, truth, vigilance, and beauty, often using the symbol of the sun. Some of these gods are portrayed as the sun itself or as a charioteer who guides the sun across the sky. Others are tireless sentinels whose eyes pierce every shadow and see through every deception. Some are deities of beauty and artistry, who teach that art is a vehicle for the soul's improvement. Clerics of a god of light are enlightened souls infused with radiance and the power of their gods' discerning vision, charged with chasing away lies and burning away darkness.

Light Domain spells:
1st level - Burning Hands, Faerie Fire
3rd level - Flaming Sphere, Scorching Ray
5th level - Daylight, Fireball
7th level - Guardian of Faith, Wall of Fire
9th level - Flame Strike, Scrying

Bonus Cantrip
When you choose this domain at 1st level, you gain the Light cantrip if you don't already know it.

Warding Flare
Also at 1st level, you can interpose divine light between yourself and an attacking enemy. When you are attacked by a creature within 30 feet of you that you can see, you can use your reaction to impose disadvantage on the attack roll, causing light to flare before the attacker before it hits or misses. An attacker that can't be blinded is immune to this feature.

You can use this feature a number of times equal to your Wisdom modifier (a minimum of once). You regain all expended uses when you finish a long rest.

Channel Divinity: Radiance of the Dawn
Starting at 2nd level, you can use your Channel Divinity to harness sunlight, banishing darkness and dealing radiant damage to your foes.

As an action, you present your holy symbol, and any magical darkness within 30 feet of you is dispelled. Additionally, each hostile creature within 30 feet of you must make a Constitution saving throw. A creature takes radiant damage equal to 2d10 + your cleric level on a failed saving throw, and half as much damage on a successful one. A creature that has total cover from you is not affected.

Improved Flare
Starting at 6th level, you can also use your Warding Flare feature when a creature that you can see within 30 feet of you attacks a creature other than you.

Potent Spellcasting
Starting at 8th level, you add your Wisdom modifier to the damage you deal with any cleric cantrip.

Corona of Light
Starting at 17th level, you can use your action to activate an aura of sunlight that lasts for 1 minute or until you dismiss it using another action. You emit bright light in a 60-foot radius and dim light 30 feet beyond that. Your enemies in the bright light have disadvantage on saving throws against any spell that deals fire or radiant damage.";
        }

        private void BtnNature_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Nature";
            TxtDisplayInfo.Text = @"Gods of nature are as varied as the natural world itself; from inscrutable gods of the deep forests (such as Silvanus, Obad-Hai, Chislev, Balinor, and Pan) to friendly deities associated with particular springs and groves (such as Eldath). Druids revere nature as a whole and might serve one of these deities, practicing mysterious rites and reciting all-but-forgotten prayers in their own secret tongue. But many of these gods have clerics as well, champions who take a more active role in advancing the interests of a particular nature god. These clerics might hunt the evil monstrosities that despoil the woodlands, bless the harvest of the faithful, or wither the crops of those who anger their gods.

Nature Domain spells:
1st level - Animal Friendship, Speak with Animals
3rd level - Barkskin, Spike Growth
5th level - Plant Growth, Wind Wall
7th level - Dominate Beast, Grasping Vine
9th level - Insect Plague, Tree Stride

Acolyte of Nature
At 1st level, you learn one cantrip of your choice from the druid spell list. You also gain proficiency in one of the following skills of your choice: Animal Handling, Nature, or Survival.

Bonus Proficiency
Also at 1st level, you gain proficiency with heavy armor.

Channel Divinity: Charm Animals and Plants
Starting at 2nd level, you can use your Channel Divinity to charm animals and plants.

As an action, you present your holy symbol and invoke the name of your deity. Each beast or plant creature that can see you within 30 feet of you must make a Wisdom saving throw. If the creature fails its saving throw, it is charmed by you for 1 minute or until it takes damage. While it is charmed by you, it is friendly to you and other creatures you designate.

Dampen Elements
Starting at 6th level, when you or a creature within 30 feet of you takes acid, cold, fire, lightning, or thunder damage, you can use your reaction to grant resistance to the creature against that instance of the damage.

Divine Strike
At 8th level, you gain the ability to infuse your weapon strikes with divine energy. Once on each of your turns when you hit a creature with a weapon attack, you can cause the attack to deal an extra 1d8 cold, fire, or lightning damage (your choice) to the target. When you reach 14th level, the extra damage increases to 2d8.

Master of Nature
At 17th level, you gain the ability to command animals and plant creatures. While creatures are charmed by your Charm Animals and Plants feature, you can take a bonus action on your turn to verbally command what each of those creatures will do on its next turn.";
        }

        private void BtnTempest_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Tempest";
            TxtDisplayInfo.Text = @"Gods whose portfolios include the Tempest domain – including Talos, Umberlee, Kord, Zeboim, the Devourer, Zeus, and Thor – govern storms, sea, and, sky. They include gods of lightning and thunder, gods of earthquakes, some fire gods, and certain gods of violence, physical strength, and courage. In some pantheons, a god of this domain rules over other deities and is known for swift justice delivered by thunderbolts. In the pantheons of seafaring people, gods of this domain are ocean deities and the patrons of sailors. Tempest gods send their clerics to inspire fear in the common folk, either to keep those folk on the path of righteousness or to encourage them to offer sacrifices of propitiation to ward off divine wrath.

Tempest Domain spells:
1st level - Fog Cloud, Thunderwave
3rd level - Gust of Wind, Shatter
5th level - Call Lightning, Sleet Storm
7th level - Control Water, Ice Storm
9th level - Destructive Wave, Insect Plague

Bonus Proficiencies
At 1st level, you gain proficiency with martial weapons and heavy armor.

Wrath of the Storm
Also at 1st level, you can thunderously rebuke attackers. When a creature within 5 feet of you that you can see hits you with an attack, you can use your reaction to cause the creature to make a Dexterity saving throw. The creature takes 2d8 lightning or thunder damage (your choice) on a failed saving throw, and half as much damage on a successful one.

You can use this feature a number of times equal to your Wisdom modifier (a minimum of once). You regain all expended uses when you finish a long rest.

Channel Divinity: Destructive Wrath
Starting at 2nd level, you can use your Channel Divinity to wield the power of the storm with unchecked ferocity.

When you roll lightning or thunder damage, you can use your Channel Divinity to deal maximum damage, instead of rolling.

Thunderous Strike
At 6th level, when you deal lightning damage to a Large or smaller creature, you can also push it up to 10 feet away from you.

Divine Strike
At 8th level, you gain the ability to infuse your weapon strikes with divine energy. Once on each of your turns when you hit a creature with a weapon attack, you can cause the attack to deal an extra 1d8 thunder damage to the target. When you reach 14th level, the extra damage increases to 2d8.

Stormborn
At 17th level, you have a flying speed equal to your current walking speed whenever you are not underground or indoors.";
        }

        private void BtnTrickery_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Trickery";
            TxtDisplayInfo.Text = @"Gods of trickery – such as Tymora, Beshaba, Olidammara, the Traveler, Garl Glittergold, and Loki – are mischief-makers and instigators who stand as a constant challenge to the accepted order among both gods and mortals. They're patrons of thieves, scoundrels, gamblers, rebels, and liberators. Their clerics are a disruptive force in the world, puncturing pride, mocking tyrants, stealing from the rich, freeing captives, and flouting hollow traditions. They prefer subterfuge, pranks, deception, and theft rather than direct confrontation.

Trickery Domain spells:
1st level - Charm Person, Disguise Self
3rd level - Mirror Image, Pass without Trace
5th level - Blink, Dispel Magic
7th level - Dimension Door, Polymorph
9th level - Dominate Person, Modify Memory

Blessing of the Trickster
Starting when you choose this domain at 1st level, you can use your action to touch a willing creature other than yourself to give it advantage on Dexterity (Stealth) checks. This blessing lasts for 1 hour or until you use this feature again.

Channel Divinity: Invoke Duplicity
Starting at 2nd level, you can use your Channel Divinity to create an illusory duplicate of yourself.

As an action, you create a perfect illusion of yourself that lasts for 1 minute, or until you lose your concentration (as if you were concentrating on a spell). The illusion appears in an unoccupied space that you can see within 30 feet of you. As a bonus action on your turn, you can move the illusion up to 30 feet to a space you can see, but it must remain within 120 feet of you.

For the duration, you can cast spells as though you were in the illusion's space, but you must use your own senses. Additionally, when both you and your illusion are within 5 feet of a creature that can see the illusion, you have advantage on attack rolls against that creature, given how distracting the illusion is to the target.

Channel Divinity: Cloak of Shadows
Starting at 6th level, you can use your Channel Divinity to vanish.

As an action, you become invisible until the end of your next turn. You become visible if you attack or cast a spell.

Divine Strike
At 8th level, you gain the ability to infuse your weapon strikes with poison – a gift from your deity. Once on each of your turns when you hit a creature with a weapon attack, you can cause the attack to deal an extra 1d8 poison damage to the target. When you reach 14th level, the extra damage increases to 2d8.

Improved Duplicity
At 17th level, you can create up to four duplicates of yourself, instead of one, when you use Invoke Duplicity. As a bonus action on your turn, you can move any number of them up to 30 feet, to a maximum range of 120 feet.";
        }

        private void BtnWar_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "War";
            TxtDisplayInfo.Text = @"War has many manifestations. It can make heroes of ordinary people. It can be desperate and horrific, with acts of cruelty and cowardice eclipsing instances of excellence and courage. In either case, the gods of war watch over warriors and reward them for their great deeds. The clerics of such gods excel in battle, inspiring others to fight the good fight or offering acts of violence as prayers. Gods of war include champions of honor and chivalry (such as Torm, Heironeous, and Kiri-Jolith) as well as gods of destruction and pillage (such as Erythnul, the Fury, Gruumsh, and Ares) and gods of conquest and domination (such as Bane, Hextor, and Maglubiyet). Other war gods (such as Tempus, Nike, and Nuada) take a more neutral stance, promoting war in all its manifestations and supporting warriors in any circumstance.

War Domain spells:
1st level - Divine Favor, Shield of Faith
3rd level - Magic Weapon, Spiritual Weapon
5th level - Crusader's Mantle, Spirit Guardians
7th level - Freedom of Movement, Stoneskin
9th level - Flame Strike, Hold Monster

Bonus Proficiency
At 1st level, you gain proficiency with martial weapons and heavy armor.

War Priest
From 1st level, your god delivers bolts of inspiration to you while you are engaged in battle. When you use the Attack action, you can make one weapon attack as a bonus action.

You can use this feature a number of times equal to your Wisdom modifier (a minimum of once). You regain all expended uses when you finish a long rest.

Channel Divinity: Guided Strike
Starting at 2nd level, you can use your Channel Divinity to strike with supernatural accuracy. When you make an attack roll, you can use your Channel Divinity to gain a +10 bonus to the roll. You make this choice after you see the roll, but before the DM says whether the attack hits or misses.

Channel Divinity: War God's Blessing
At 6th level, when a creature within 30 feet of you makes an attack roll, you can use your reaction to grant that creature a +10 bonus to the roll, using your Channel Divinity. You make this choice after you see the roll, but before the DM says whether the attack hits or misses.

Divine Strike
At 8th level, you gain the ability to infuse your weapon strikes with divine energy. Once on each of your turns when you hit a creature with a weapon attack, you can cause the attack to deal an extra 1d8 damage of the same type dealt by the weapon to the target. When you reach 14th level, the extra damage increases to 2d8.

Avatar of Battle
At 17th level, you gain resistance to bludgeoning, piercing, and slashing damage from nonmagical weapons.";
        }
    }
}
