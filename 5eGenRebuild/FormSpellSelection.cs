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
        int AvailableCantrips, AvailableLevel1, MaximumCantrips, MaximumLevel1;

        public FormSpellSelection(Character NewToon)
        {
            InitializeComponent();
            ThisToon = NewToon;
            InitialiseOptions();
            InitialiseSpells();
            LblAvailableCantrips.Text = AvailableCantrips.ToString();
            LblAvailableLevel1.Text = AvailableLevel1.ToString();
        }

        public void InitialiseOptions()
        {

            if (ThisToon.Class == "Bard")
            {
                AvailableCantrips = MaximumCantrips = 2;
                AvailableLevel1 = MaximumLevel1 = 4;
                this.Text = "Spell selection (Bard)";

                // --CANTRIPS--
                ListSpellsAvailable0.Items.Add("Blade Ward");
                ListSpellsAvailable0.Items.Add("Dancing Lights");
                ListSpellsAvailable0.Items.Add("Friends");
                ListSpellsAvailable0.Items.Add("Light");
                ListSpellsAvailable0.Items.Add("Mage Hand");
                ListSpellsAvailable0.Items.Add("Mending");
                ListSpellsAvailable0.Items.Add("Message");
                ListSpellsAvailable0.Items.Add("Minor Illusion");
                ListSpellsAvailable0.Items.Add("Prestidigitation");
                ListSpellsAvailable0.Items.Add("True Strike");
                ListSpellsAvailable0.Items.Add("Vicious Mockery");

                // --LEVEL 1--
                ListSpellsAvailable1.Items.Add("Animal Friendship");
                ListSpellsAvailable1.Items.Add("Bane");
                ListSpellsAvailable1.Items.Add("Charm Person");
                ListSpellsAvailable1.Items.Add("Color Spray");
                ListSpellsAvailable1.Items.Add("Command");
                ListSpellsAvailable1.Items.Add("Comprehend Languages");
                ListSpellsAvailable1.Items.Add("Cure Wounds");
                ListSpellsAvailable1.Items.Add("Detect Magic");
                ListSpellsAvailable1.Items.Add("Disguise Self");
                ListSpellsAvailable1.Items.Add("Dissonant Whispers");
                ListSpellsAvailable1.Items.Add("Faerie Fire");
                ListSpellsAvailable1.Items.Add("Feather Fall");
                ListSpellsAvailable1.Items.Add("Healing Word");
                ListSpellsAvailable1.Items.Add("Heroism");
                ListSpellsAvailable1.Items.Add("Identify");
                ListSpellsAvailable1.Items.Add("Illusory Script");
                ListSpellsAvailable1.Items.Add("Longstrider");
                ListSpellsAvailable1.Items.Add("Silent Image");
                ListSpellsAvailable1.Items.Add("Sleep");
                ListSpellsAvailable1.Items.Add("Speak With Animals");
                ListSpellsAvailable1.Items.Add("Tasha's Hideous Laughter");
                ListSpellsAvailable1.Items.Add("Thunderwave");
                ListSpellsAvailable1.Items.Add("Unseen Servant");
            }

            else if (ThisToon.Class == "Cleric")
            {
                // --CANTRIPS--
                AvailableCantrips = MaximumCantrips = 3;
                ListSpellsAvailable0.Items.Add("Guidance");
                ListSpellsAvailable0.Items.Add("Light");
                ListSpellsAvailable0.Items.Add("Mending");
                ListSpellsAvailable0.Items.Add("Resistance");
                ListSpellsAvailable0.Items.Add("Sacred Flame");
                ListSpellsAvailable0.Items.Add("Spare the Dying");
                ListSpellsAvailable0.Items.Add("Thaumaturgy");

                // --LEVEL 1--
                ListSelectedSpells1.Items.Add("Bane");
                ListSelectedSpells1.Items.Add("Bless");
                ListSelectedSpells1.Items.Add("Ceremony");
                ListSelectedSpells1.Items.Add("Command");
                ListSelectedSpells1.Items.Add("Create/Destroy Water");
                ListSelectedSpells1.Items.Add("Cure Wounds");
                ListSelectedSpells1.Items.Add("Detect Good/Evil");
                ListSelectedSpells1.Items.Add("Detect Magic");
                ListSelectedSpells1.Items.Add("Detect Poison/Disease");
                ListSelectedSpells1.Items.Add("Guiding Bolt");
                ListSelectedSpells1.Items.Add("Healing Word");
                ListSelectedSpells1.Items.Add("Inflict Wounds");
                ListSelectedSpells1.Items.Add("Protection from Good/Evil");
                ListSelectedSpells1.Items.Add("Purify Food/Drink");
                ListSelectedSpells1.Items.Add("Sanctuary");
                ListSelectedSpells1.Items.Add("Shield of Faith");

                // --DOMAIN SPELLS--
                if (ThisToon.Domain == "Knowledge")
                {
                    this.Text = "Spell selection (Cleric - Knowledge)";
                    ListSelectedSpells1.Items.Add("Command");
                    ListSelectedSpells1.Items.Add("Identify");
                }
                else if (ThisToon.Domain == "Life")
                {
                    this.Text = "Spell selection (Cleric - Life)";
                    ListSelectedSpells1.Items.Add("Bless");
                    ListSelectedSpells1.Items.Add("Cure Wounds");
                }
                else if (ThisToon.Domain == "Light")
                {
                    this.Text = "Spell selection (Cleric - Light)";
                    ListSelectedSpells0.Items.Add("Light");
                    ListSelectedSpells1.Items.Add("Burning Hands");
                    ListSelectedSpells1.Items.Add("Faerie Fire");
                }
                else if (ThisToon.Domain == "Nature")
                {
                    this.Text = "Spell selection (Cleric - Nature)";
                    ListSelectedSpells1.Items.Add("Animal Friendship");
                    ListSelectedSpells1.Items.Add("Speak With Animals");
                }
                else if (ThisToon.Domain == "Tempest")
                {
                    this.Text = "Spell selection (Cleric - Tempest)";
                    ListSelectedSpells1.Items.Add("Fog Cloud");
                    ListSelectedSpells1.Items.Add("Thunderwave");
                }
                else if (ThisToon.Domain == "Trickery")
                {
                    this.Text = "Spell selection (Cleric - Trickery)";
                    ListSelectedSpells1.Items.Add("Charm Person");
                    ListSelectedSpells1.Items.Add("Disguise Self");
                }
                else if (ThisToon.Domain == "War")
                {
                    this.Text = "Spell selection (Cleric - War)";
                    ListSelectedSpells1.Items.Add("Divine Favor");
                    ListSelectedSpells1.Items.Add("Shield of Faith");
                }

                foreach(var item in ListSelectedSpells0.Items)
                {
                    if (ListSpellsAvailable0.Items.Contains(item))
                    {
                        ListSpellsAvailable0.Items.Remove(item);
                    }
                }

                foreach(var item in ListSelectedSpells1.Items)
                {
                    if (ListSpellsAvailable1.Items.Contains(item))
                    {
                        ListSpellsAvailable1.Items.Remove(item);
                    }
                }
            }

            else if (ThisToon.Class == "Druid")
            {
                AvailableCantrips = MaximumCantrips = 2;
                this.Text = "Spell selection (Druid)";

                // --CANTRIPS--
                ListSpellsAvailable0.Items.Add("Druidcraft");
                ListSpellsAvailable0.Items.Add("Guidance");
                ListSpellsAvailable0.Items.Add("Mending");
                ListSpellsAvailable0.Items.Add("Poison Spray");
                ListSpellsAvailable0.Items.Add("Produce Flame");
                ListSpellsAvailable0.Items.Add("Resistance");
                ListSpellsAvailable0.Items.Add("Shillelagh");
                ListSpellsAvailable0.Items.Add("Thorn Whip");

                // --LEVEL 1--
                ListSelectedSpells1.Items.Add("Animal Friendship");
                ListSelectedSpells1.Items.Add("Charm Person");
                ListSelectedSpells1.Items.Add("Create/Destroy Water");
                ListSelectedSpells1.Items.Add("Cure Wounds");
                ListSelectedSpells1.Items.Add("Detect Magic");
                ListSelectedSpells1.Items.Add("Detect Poison/Disease");
                ListSelectedSpells1.Items.Add("Entangle");
                ListSelectedSpells1.Items.Add("Faerie Fire");
                ListSelectedSpells1.Items.Add("Fog Cloud");
                ListSelectedSpells1.Items.Add("Goodberry");
                ListSelectedSpells1.Items.Add("Healing Word");
                ListSelectedSpells1.Items.Add("Jump");
                ListSelectedSpells1.Items.Add("Longstrider");
                ListSelectedSpells1.Items.Add("Protection from Good/Evil");
                ListSelectedSpells1.Items.Add("Purify Food/Drink");
                ListSelectedSpells1.Items.Add("Speak With Animals");
                ListSelectedSpells1.Items.Add("Thunderwave");
            }

            else if (ThisToon.Class == "Sorcerer")
            {
                AvailableCantrips = MaximumCantrips = 4;
                AvailableLevel1 = MaximumLevel1 = 2;
                this.Text = "Spell selection (Sorcerer)";

                // --CANTRIPS--
                ListSpellsAvailable0.Items.Add("Acid Splash");
                ListSpellsAvailable0.Items.Add("Blade Ward");
                ListSpellsAvailable0.Items.Add("Chill Touch");
                ListSpellsAvailable0.Items.Add("Dancing Lights");
                ListSpellsAvailable0.Items.Add("Fire Bolt");
                ListSpellsAvailable0.Items.Add("Friends");
                ListSpellsAvailable0.Items.Add("Light");
                ListSpellsAvailable0.Items.Add("Mage Hand");
                ListSpellsAvailable0.Items.Add("Mending");
                ListSpellsAvailable0.Items.Add("Message");
                ListSpellsAvailable0.Items.Add("Minor Illusion");
                ListSpellsAvailable0.Items.Add("Poison Spray");
                ListSpellsAvailable0.Items.Add("Prestidigitation");
                ListSpellsAvailable0.Items.Add("Ray of Frost");
                ListSpellsAvailable0.Items.Add("Shocking Grasp");
                ListSpellsAvailable0.Items.Add("True Strike");

                // --LEVEL 1--
                ListSpellsAvailable1.Items.Add("Burning Hands");
                ListSpellsAvailable1.Items.Add("Charm Person");
                ListSpellsAvailable1.Items.Add("Chromatic Orb");
                ListSpellsAvailable1.Items.Add("Color Spray");
                ListSpellsAvailable1.Items.Add("Comprehend Languages");
                ListSpellsAvailable1.Items.Add("Detect Magic");
                ListSpellsAvailable1.Items.Add("Disguise Self");
                ListSpellsAvailable1.Items.Add("Expeditious Retreat");
                ListSpellsAvailable1.Items.Add("False Life");
                ListSpellsAvailable1.Items.Add("Feather Fall");
                ListSpellsAvailable1.Items.Add("Fog Cloud");
                ListSpellsAvailable1.Items.Add("Grease");
                ListSpellsAvailable1.Items.Add("Jump");
                ListSpellsAvailable1.Items.Add("Mage Armour");
                ListSpellsAvailable1.Items.Add("Magic Missile");
                ListSpellsAvailable1.Items.Add("Ray of Sickness");
                ListSpellsAvailable1.Items.Add("Shield");
                ListSpellsAvailable1.Items.Add("Silent Image");
                ListSpellsAvailable1.Items.Add("Sleep");
                ListSpellsAvailable1.Items.Add("Thunderwave");
                ListSpellsAvailable1.Items.Add("Witch Bolt");
            }

            else if (ThisToon.Class == "Warlock")
            {
                AvailableCantrips = MaximumCantrips = AvailableLevel1 = MaximumLevel1 = 2;
                this.Text = "Spell selection (Warlock)";

                // --CANTRIPS--
                ListSpellsAvailable0.Items.Add("Blade Ward");
                ListSpellsAvailable0.Items.Add("Chill Touch");
                ListSpellsAvailable0.Items.Add("Eldritch Blast");
                ListSpellsAvailable0.Items.Add("Friends");
                ListSpellsAvailable0.Items.Add("Mage Hand");
                ListSpellsAvailable0.Items.Add("Minor Illusion");
                ListSpellsAvailable0.Items.Add("Poison Spray");
                ListSpellsAvailable0.Items.Add("Prestidigitation");
                ListSpellsAvailable0.Items.Add("True Strike");

                // --LEVEL 1--
                ListSpellsAvailable1.Items.Add("Armour of Agathys");
                ListSpellsAvailable1.Items.Add("Arms of Hadar");
                ListSpellsAvailable1.Items.Add("Charm Person");
                ListSpellsAvailable1.Items.Add("Comprehend Languages");
                ListSpellsAvailable1.Items.Add("Expeditious Retreat");
                ListSpellsAvailable1.Items.Add("Hellish Rebuke");
                ListSpellsAvailable1.Items.Add("Hex");
                ListSpellsAvailable1.Items.Add("Illusory Script");
                ListSpellsAvailable1.Items.Add("Protection from Good/Evil");
                ListSpellsAvailable1.Items.Add("Unseen Servant");
                ListSpellsAvailable1.Items.Add("Witch Bolt");
            }

            else if (ThisToon.Class == "Wizard")
            {
                AvailableCantrips = MaximumCantrips = 3;
                AvailableLevel1 = MaximumLevel1 = 6;
                this.Text = "Spell selection (Wizard)";

                // --CANTRIPS--
                ListSpellsAvailable0.Items.Add("Acid Splash");
                ListSpellsAvailable0.Items.Add("Blade Ward");
                ListSpellsAvailable0.Items.Add("Chill Touch");
                ListSpellsAvailable0.Items.Add("Dancing Lights");
                ListSpellsAvailable0.Items.Add("Fire Bolt");
                ListSpellsAvailable0.Items.Add("Friends");
                ListSpellsAvailable0.Items.Add("Light");
                ListSpellsAvailable0.Items.Add("Mage Hand");
                ListSpellsAvailable0.Items.Add("Mending");
                ListSpellsAvailable0.Items.Add("Message");
                ListSpellsAvailable0.Items.Add("Minor Illusion");
                ListSpellsAvailable0.Items.Add("Poison Spray");
                ListSpellsAvailable0.Items.Add("Prestidigitation");
                ListSpellsAvailable0.Items.Add("Ray of Frost");
                ListSpellsAvailable0.Items.Add("Shocking Grasp");
                ListSpellsAvailable0.Items.Add("True Strike");

                // --LEVEL 1--
                ListSpellsAvailable1.Items.Add("Alarm");
                ListSpellsAvailable1.Items.Add("Burning Hands");
                ListSpellsAvailable1.Items.Add("Charm Person");
                ListSpellsAvailable1.Items.Add("Chromatic Orb");
                ListSpellsAvailable1.Items.Add("Color Spray");
                ListSpellsAvailable1.Items.Add("Comprehend Languages");
                ListSpellsAvailable1.Items.Add("Detect Magic");
                ListSpellsAvailable1.Items.Add("Disguise Self");
                ListSpellsAvailable1.Items.Add("Expeditious Retreat");
                ListSpellsAvailable1.Items.Add("False Life");
                ListSpellsAvailable1.Items.Add("Feather Fall");
                ListSpellsAvailable1.Items.Add("Find Familiar");
                ListSpellsAvailable1.Items.Add("Fog Cloud");
                ListSpellsAvailable1.Items.Add("Grease");
                ListSpellsAvailable1.Items.Add("Identify");
                ListSpellsAvailable1.Items.Add("Illusory Script");
                ListSpellsAvailable1.Items.Add("Jump");
                ListSpellsAvailable1.Items.Add("Longstrider");
                ListSpellsAvailable1.Items.Add("Mage Armour");
                ListSpellsAvailable1.Items.Add("Magic Missile");
                ListSpellsAvailable1.Items.Add("Protection from Good/Evil");
                ListSpellsAvailable1.Items.Add("Ray of Sickness");
                ListSpellsAvailable1.Items.Add("Shield");
                ListSpellsAvailable1.Items.Add("Silent Image");
                ListSpellsAvailable1.Items.Add("Sleep");
                ListSpellsAvailable1.Items.Add("Tasha's Hideous Laughter");
                ListSpellsAvailable1.Items.Add("Tenser's Floating Disk");
                ListSpellsAvailable1.Items.Add("Thunderwave");
                ListSpellsAvailable1.Items.Add("Unseen Servant");
                ListSpellsAvailable1.Items.Add("Witch Bolt");
            }
        }

        public void InitialiseSpells()
        {
            // CANTRIPS
            Spell AcidSplash = new Spell(0, "Acid Splash", @"Conjuration cantrip

Casting Time: 1 action
Range: 60 feet
Components: V, S
Duration: Instantaneous

You hurl a bubble of acid. Choose one creature within range, or choose two creatures within range that are within 5 feet of each other. A target must succeed on a Dexterity saving throw or take 1d6 acid damage.

At Higher Levels. This spell’s damage increases by 1d6 when you reach 5th level (2d6), 11th level (3d6), and 17th level (4d6).", "Conjuration", false, 60, "Instant", true, false, false);
            AllSpells.Add("Acid Splash", AcidSplash);

            Spell BladeWard = new Spell(0, "Blade Ward", @"Abjuration cantrip

Casting Time: 1 action
Range: Self
Components: V, S
Duration: 1 round

You extend your hand and trace a sigil of warding in the air. Until the end of your next turn, you have resistance against bludgeoning, piercing, and slashing damage dealt by weapon attacks.", "Abjuration", false, 0, "1 round", true, true, false);
            AllSpells.Add("Blade Ward", BladeWard);

            Spell ChillTouch = new Spell(0, "Chill Touch", @"Necromancy cantrip

Casting Time: 1 action
Range: 120 feet
Components: V, S
Duration: 1 round

You create a ghostly, skeletal hand in the space of a creature within range. Make a ranged spell attack against the creature to assail it with the chill of the grave. On a hit, the target takes 1d8 necrotic damage, and it can’t regain hit points until the start of your next turn. Until then, the hand clings to the target. If you hit an undead target, it also has disadvantage on attack rolls against you until the end of your next turn.

At Higher Levels. This spell’s damage increases by 1d8 when you reach 5th level (2d8), 11th level (3d8), and 17th level (4d8).", "Necromancy", false, 120, "1 round", true, true, false);
            AllSpells.Add("Chill Touch", ChillTouch);

            Spell DancingLights = new Spell(0, "Dancing Lights", @"Evocation cantrip

Casting Time: 1 action
Range: 120 feet
Components: V, S, M (a bit of phosphorus or wychwood, or a glowworm)
Duration: Concentration, up to 1 minute

You create up to four torch-sized lights within range, making them appear as torches, lanterns, or glowing orbs that hover in the air for the duration. You can also combine the four lights into one glowing vaguely humanoid form of Medium size. Whichever form you choose, each light sheds dim light in a 10-foot radius.

As a bonus action on your turn, you can move the lights up to 60 feet to a new spot within range. A light must be within 20 feet of another light created by this spell, and a light winks out if it exceeds the spell’s range.", "Evocation", false, 120, "Concentration, up to 1 minute", true, true, true);
            AllSpells.Add("Dancing Lights", DancingLights);

            Spell Druidcraft = new Spell(0, "Druidcraft", @"Transmutation cantrip

Casting Time: 1 action
Range: 30 feet
Components: V, S
Duration: Instantaneous

Whispering to the spirits of nature, you create one of the following effects within range:

You create a tiny, harmless sensory effect that predicts what the weather will be at your location for the next 24 hours. The effect might manifest as a golden orb for clear skies, a cloud for rain, falling snowflakes for snow, and so on. This effect persists for 1 round.
You instantly make a flower blossom, a seed pod open, or a leaf bud bloom.
You create an instantaneous, harmless sensory effect, such as falling leaves, a puff of wind, the sound of a small animal, or the faint odor of skunk. The effect must fit in a 5-foot cube.
You instantly light or snuff out a candle, a torch, or a small campfire.", "Transmutation", false, 30, "Instant", true, true, false);
            AllSpells.Add("Druidcraft", Druidcraft);

            Spell EldritchBlast = new Spell(0, "Eldritch Blast", @"Evocation cantrip

Casting Time: 1 action
Range: 120 feet
Components: V, S
Duration: Instantaneous

A beam of crackling energy streaks toward a creature within range. Make a ranged spell attack against the target. On a hit, the target takes 1d10 force damage.

At Higher Levels. The spell creates more than one beam when you reach higher levels: two beams at 5th level, three beams at 11th level, and four beams at 17th level. You can direct the beams at the same target or at different ones. Make a separate attack roll for each beam.", "Evocation", false, 120, "Instant", true, true, false);
            AllSpells.Add("Eldritch Blast", EldritchBlast);

            Spell FireBolt = new Spell(0, "Fire Bolt", @"Evocation cantrip

Casting Time: 1 action
Range: 120 feet
Components: V, S
Duration: Instantaneous

You hurl a mote of fire at a creature or object within range. Make a ranged spell attack against the target. On a hit, the target takes 1d10 fire damage. A flammable object hit by this spell ignites if it isn’t being worn or carried.

At Higher Levels. This spell’s damage increases by 1d10 when you reach 5th level (2d10), 11th level (3d10), and 17th level (4d10).", "Evocation", false, 120, "Instant", true, true, false);
            AllSpells.Add("Fire Bolt", FireBolt);

            Spell Friends = new Spell(0, "Friends", @"Enchantment cantrip

Casting Time: 1 action
Range: Self
Components: S, M (a small amount of makeup applied to the face as this spell is cast)
Duration: Concentration, up to 1 minute

For the duration, you have advantage on all Charisma checks directed at one creature of your choice that isn’t hostile toward you. When the spell ends, the creature realizes that you used magic to influence its mood and becomes hostile toward you. A creature prone to violence might attack you. Another creature might seek retribution in other ways (at the DM’s discretion), depending on the nature of your interaction with it.", "Enchantment", false, 0, "Concentration, up to 1 minute", false, true, true);
            AllSpells.Add("Friends", Friends);

            Spell Guidance = new Spell(0, "Guidance", @"Divination cantrip

Casting Time: 1 action
Range: Touch
Components: V, S
Duration: Concentration, up to 1 minute

You touch one willing creature. Once before the spell ends, the target can roll a d4 and add the number rolled to one ability check of its choice. It can roll the die before or after making the ability check. The spell then ends.", "Divination", false, 0, "Concentration, up to 1 minute", true, true, false);
            AllSpells.Add("Guidance", Guidance);

            Spell Light = new Spell(0, "Light", @"Evocation cantrip

Casting Time: 1 action
Range: Touch
Components: V, M (a firefly or phosphorescent moss)
Duration: 1 hour

You touch one object that is no larger than 10 feet in any dimension. Until the spell ends, the object sheds bright light in a 20-foot radius and dim light for an additional 20 feet. The light can be colored as you like. Completely covering the object with something opaque blocks the light. The spell ends if you cast it again or dismiss it as an action.

If you target an object held or worn by a hostile creature, that creature must succeed on a Dexterity saving throw to avoid the spell.", "Evocation", false, 0, "1 hour", true, false, true);
            AllSpells.Add("Light", Light);

            Spell MageHand = new Spell(0, "Mage Hand", @"Conjuration cantrip

Casting Time: 1 action
Range: 30 feet
Components: V, S
Duration: 1 minute

A spectral, floating hand appears at a point you choose within range. The hand lasts for the duration or until you dismiss it as an action. The hand vanishes if it is ever more than 30 feet away from you or if you cast this spell again.

You can use your action to control the hand. You can use the hand to manipulate an object, open an unlocked door or container, stow or retrieve an item from an open container, or pour the contents out of a vial. You can move the hand up to 30 feet each time you use it.

The hand can’t attack, activate magical items, or carry more than 10 pounds.", "Conjuration", false, 30, "1 minute", true, true, false);
            AllSpells.Add("Mage Hand", MageHand);

            Spell Mending = new Spell(0, "Mending", @"Transmutation cantrip

Casting Time: 1 minute
Range: Touch
Components: V, S, M (two lodestones)
Duration: Instantaneous

This spell repairs a single break or tear in an object you touch, such as a broken chain link, two halves of a broken key, a torn cloak, or a leaking wineskin. As long as the break or tear is no larger than 1 foot in any dimension, you mend it, leaving no trace of the former damage.

This spell can physically repair a magic item or construct, but the spell can’t restore magic to such an object.", "Transmutation", false, 0, "Instant", true, true, true);
            AllSpells.Add("Mending", Mending);

            Spell Message = new Spell(0, "Message", @"Transmutation cantrip

Casting Time: 1 action
Range: 120 feet
Components: V, S, M (a short piece of copper wire)
Duration: 1 round

You point your finger toward a creature within range and whisper a message. The target (and only the target) hears the message and can reply in a whisper that only you can hear.

You can cast this spell through solid objects if you are familiar with the target and know it is beyond the barrier. Magical silence, 1 foot of stone, 1 inch of common metal, a thin sheet of lead, or 3 feet of wood blocks the spell. The spell doesn’t have to follow a straight line and can travel freely around corners or through openings.", "Transmutation", false, 120, "1 round", true, true, true);
            AllSpells.Add("Message", Message);

            Spell MinorIllusion = new Spell(0, "Minor Illusion", @"Illusion cantrip

Casting Time: 1 action
Range: 30 feet
Components: S, M (a bit of fleece)
Duration: 1 minute

You create a sound or an image of an object within range that lasts for the duration. The illusion also ends if you dismiss it as an action or cast this spell again.

If you create a sound, its volume can range from a whisper to a scream. It can be your voice, someone else’s voice, a lion’s roar, a beating of drums, or any other sound you choose. The sound continues unabated throughout the duration, or you can make discrete sounds at different times before the spell ends.

If you create an image of an object—such as a chair, muddy footprints, or a small chest—it must be no larger than a 5-foot cube. The image can’t create sound, light, smell, or any other sensory effect. Physical interaction with the image reveals it to be an illusion, because things can pass through it.

If a creature uses its action to examine the sound or image, the creature can determine that it is an illusion with a successful Intelligence (Investigation) check against your spell save DC. If a creature discerns the illusion for what it is, the illusion becomes faint to the creature.", "Illusion", false, 30, "1 minute", false, true, true);
            AllSpells.Add("Minor Illusion", MinorIllusion);

            Spell PoisonSpray = new Spell(0, "Poison Spray", @"Conjuration cantrip

Casting Time: 1 action
Range: 10 feet
Components: V, S
Duration: Instantaneous

You extend your hand toward a creature you can see within range and project a puff of noxious gas from your palm. The creature must succeed on a Constitution saving throw or take 1d12 poison damage.

At Higher Levels. This spell’s damage increases by 1d12 when you reach 5th level (2d12), 11th level (3d12), and 17th level (4d12).", "Conjuration", false, 10, "Instant", true, true, false);
            AllSpells.Add("Poison Spray", PoisonSpray);

            Spell Prestidigitation = new Spell(0, "Prestidigitation", @"Transmutation cantrip

Casting Time: 1 action
Range: 10 feet
Components: V, S
Duration: Up to 1 hour

This spell is a minor magical trick that novice spellcasters use for practice. You create one of the following magical effects within range:

You create an instantaneous, harmless sensory effect, such as a shower of sparks, a puff of wind, faint musical notes, or an odd odor.
You instantaneously light or snuff out a candle, a torch, or a small campfire.
You instantaneously clean or soil an object no larger than 1 cubic foot.
You chill, warm, or flavor up to 1 cubic foot of nonliving material for 1 hour.
You make a color, a small mark, or a symbol appear on an object or a surface for 1 hour.
You create a nonmagical trinket or an illusory image that can fit in your hand and that lasts until the end of your next turn.
If you cast this spell multiple times, you can have up to three of its non-instantaneous effects active at a time, and you can dismiss such an effect as an action.", "Transmutation", false, 10, "Up to 1 hour", true, true, false);
            AllSpells.Add("Prestidigitation", Prestidigitation);

            Spell ProduceFlame = new Spell(0, "Produce Flame", @"Conjuration cantrip

Casting Time: 1 action
Range: Self
Components: V, S
Duration: 10 minutes

A flickering flame appears in your hand. The flame remains there for the duration and harms neither you nor your equipment. The flame sheds bright light in a 10-foot radius and dim light for an additional 10 feet. The spell ends if you dismiss it as an action or if you cast it again.

You can also attack with the flame, although doing so ends the spell. When you cast this spell, or as an action on a later turn, you can hurl the flame at a creature within 30 feet of you. Make a ranged spell attack. On a hit, the target takes 1d8 fire damage.

At Higher Levels. This spell’s damage increases by 1d8 when you reach 5th level (2d8), 11th level (3d8), and 17th level (4d8).", "Conjuration", false, 0, "10 minutes", true, true, false);
            AllSpells.Add("Produce Flame", ProduceFlame);

            Spell RayOfFrost = new Spell(0, "Ray of Frost", @"Evocation cantrip

Casting Time: 1 action
Range: 60 feet
Components: V, S
Duration: Instantaneous

A frigid beam of blue-white light streaks toward a creature within range. Make a ranged spell attack against the target. On a hit, it takes 1d8 cold damage, and its speed is reduced by 10 feet until the start of your next turn.

At Higher Levels. The spell’s damage increases by 1d8 when you reach 5th level (2d8), 11th level (3d8), and 17th level (4d8).", "Evocation", false, 60, "Instant", true, true, false);
            AllSpells.Add("Ray of Frost", RayOfFrost);

            Spell Resistance = new Spell(0, "Resistance", @"Abjuration cantrip

Casting Time: 1 action
Range: Touch
Components: V, S, M (a miniature cloak)
Duration: Concentration, up to 1 minute

You touch one willing creature. Once before the spell ends, the target can roll a d4 and add the number rolled to one saving throw of its choice. It can roll the die before or after the saving throw. The spell then ends.", "Abjuration", false, 0, "Concentration, up to 1 minute", true, true, true);
            AllSpells.Add("Resistance", Resistance);

            Spell SacredFlame = new Spell(0, "Sacred Flame", @"Evocation cantrip

Casting Time: 1 action
Range: 60 feet
Components: V, S
Duration: Instantaneous

Flame-like radiance descends on a creature that you can see within range. The target must succeed on a Dexterity saving throw or take 1d8 radiant damage. The target gains no benefit from cover for this saving throw.

At Higher Levels. The spell’s damage increases by 1d8 when you reach 5th level (2d8), 11th level (3d8), and 17th level (4d8).", "Evocation", false, 60, "Instant", true, true, false);
            AllSpells.Add("Sacred Flame", SacredFlame);

            Spell Shillelagh = new Spell(0, "Shillelagh", @"Transmutation cantrip

Casting Time: 1 bonus action
Range: Touch
Components: V, S, M (mistletoe, a shamrock leaf, and a club or quarterstaff)
Duration: 1 minute

The wood of a club or quarterstaff you are holding is imbued with nature’s power. For the duration, you can use your spellcasting ability instead of Strength for the attack and damage rolls of melee attacks using that weapon, and the weapon’s damage die becomes a d8. The weapon also becomes magical, if it isn’t already. The spell ends if you cast it again or if you let go of the weapon.", "Transmutation", true, 0, "1 minute", true, true, true);
            AllSpells.Add("Shillelagh", Shillelagh);

            Spell ShockingGrasp = new Spell(0, "Shocking Grasp", @"Evocation cantrip

Casting Time: 1 action
Range: Touch
Components: V, S
Duration: Instantaneous

Lightning springs from your hand to deliver a shock to a creature you try to touch. Make a melee spell attack against the target. You have advantage on the attack roll if the target is wearing armor made of metal. On a hit, the target takes 1d8 lightning damage, and it can’t take reactions until the start of its next turn.

At Higher Levels. The spell’s damage increases by 1d8 when you reach 5th level (2d8), 11th level (3d8), and 17th level (4d8).", "Evocation", false, 0, "Instant", true, true, false);
            AllSpells.Add("Shocking Grasp", ShockingGrasp);

            Spell SpareTheDying = new Spell(0, "Spare the Dying", @"Necromancy cantrip

Casting Time: 1 action
Range: Touch
Components: V, S
Duration: Instantaneous

You touch a living creature that has 0 hit points. The creature becomes stable. This spell has no effect on undead or constructs.", "Necromancy", false, 0, "Instant", true, true, false);
            AllSpells.Add("Spare the Dying", SpareTheDying);

            Spell Thaumaturgy = new Spell(0, "Thaumaturgy", @"Transmutation cantrip

Casting Time: 1 action
Range: 30 feet
Components: V
Duration: Up to 1 minute

You manifest a minor wonder, a sign of supernatural power, within range. You create one of the following magical effects within range:

Your voice booms up to three times as loud as normal for 1 minute.
You cause flames to flicker, brighten, dim, or change color for 1 minute.
You cause harmless tremors in the ground for 1 minute.
You create an instantaneous sound that originates from a point of your choice within range, such as a rumble of thunder, the cry of a raven, or ominous whispers.
You instantaneously cause an unlocked door or window to fly open or slam shut.
• You alter the appearance of your eyes for 1 minute.

If you cast this spell multiple times, you can have up to three of its 1-minute effects active at a time, and you can dismiss such an effect as an action.", "Transmutation", false, 30, "Up to 1 minute", true, false, false);
            AllSpells.Add("Thaumaturgy", Thaumaturgy);

            Spell ThornWhip = new Spell(0, "Thorn Whip", @"Transmutation cantrip

Casting Time: 1 action
Range: 30 feet
Components: V, S, M (the stem of a plant with thorns)
Duration: Instantaneous

You create a long, vine-like whip covered in thorns that lashes out at your command toward a creature in range. Make a melee spell attack against the target. If the attack hits, the creature takes 1d6 piercing damage, and if the creature is Large or smaller, you pull the creature up to 10 feet closer to you.

At Higher Levels. This spell’s damage increases by 1d6 when you reach 5th level (2d6), 11th level (3d6), and 17th level (4d6).", "Transmutation", false, 30, "Instant", true, true, true);
            AllSpells.Add("Thorn Whip", ThornWhip);

            Spell TrueStrike = new Spell(0, "True Strike", @"Divination cantrip

Casting Time: 1 action
Range: 30 feet
Components: S
Duration: Concentration, up to 1 round

You extend your hand and point a finger at a target in range. Your magic grants you a brief insight into the target’s defenses. On your next turn, you gain advantage on your first attack roll against the target, provided that this spell hasn’t ended.", "Divination", false, 30, "Concentration, up to 1 round", false, true, false);
            AllSpells.Add("True Strike", TrueStrike);

            Spell ViciousMockery = new Spell(0, "Vicious Mockery", @"Enchantment cantrip

Casting Time: 1 action
Range: 60 feet
Components: V
Duration: Instantaneous

You unleash a string of insults laced with subtle enchantments at a creature you can see within range. If the target can hear you (though it need not understand you), it must succeed on a Wisdom saving throw or take 1d4 psychic damage and have disadvantage on the next attack roll it makes before the end of its next turn.

At Higher Levels. This spell’s damage increases by 1d4 when you reach 5th level (2d4), 11th level (3d4), and 17th level (4d4).", "Enchantment", false, 60, "Instant", true, false, false);
            AllSpells.Add("Vicious Mockery", ViciousMockery);

            // 1ST LEVEL
            Spell Alarm = new Spell(1, "Alarm", @"1st-level abjuration (ritual)

Casting Time: 1 action
Range: 30 feet
Components: V, S, M (a tiny bell and a piece of fine silver wire)
Duration: 8 hours

You set an alarm against unwanted intrusion. Choose a door, a window, or an area within range that is no larger than a 20-foot cube. Until the spell ends, an alarm alerts you whenever a tiny or larger creature touches or enters the warded area. When you cast the spell, you can designate creatures that won’t set off the alarm. You also choose whether the alarm is mental or audible.

A mental alarm alerts you with a ping in your mind if you are within 1 mile of the warded area. This ping awakens you if you are sleeping. An audible alarm produces the sound of a hand bell for 10 seconds within 60 feet.", "Abjuration", false, 30, "8 hours", true, true, true);
            AllSpells.Add("Alarm", Alarm);

            Spell AnimalFriendship = new Spell(1, "Animal Friendship", @"1st-level enchantment

Casting Time: 1 action
Range: 30 feet
Components: V, S, M (a morsel of food)
Duration: 24 hours

This spell lets you convince a beast that you mean it no harm. Choose a beast that you can see within range. It must see and hear you. If the beast’s Intelligence is 4 or higher, the spell fails. Otherwise, the beast must succeed on a Wisdom saving throw or be charmed by you for the spell’s duration. If you or one of your companions harms the target, the spell ends.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, you can affect one additional beast for each slot level above 1st.", "Enchantment", false, 30, "24 hours", true, true, true);
            AllSpells.Add("Animal Friendship", AnimalFriendship);

            Spell ArmourOfAgathys = new Spell(1, "Armour of Agathys", @"1st-level abjuration

Casting Time: 1 action
Range: Self
Components: V, S, M (a cup of water)
Duration: 1 hour

A protective magical force surrounds you, manifesting as a spectral frost that covers you and your gear. You gain 5 temporary hit points for the duration. If a creature hits you with a melee attack while you have these hit points, the creature takes 5 cold damage.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, both the temporary hit points and the cold damage increase by 5 for each slot.", "Abjuration", false, 0, "1 hour", true, true, true);
            AllSpells.Add("Armour of Agathys", ArmourOfAgathys);

            Spell ArmsOfHadar = new Spell(1, "Arms of Hadar", @"1st-level conjuration

Casting Time: 1 action
Range: Self (10-foot radius)
Components: V, S
Duration: Instantaneous

You invoke the power of Hadar, the Dark Hunger. Tendrils of dark energy erupt from you and batter all creatures within 10 feet of you. Each creature in that area must make a Strength saving throw. On a failed save, a target takes 2d6 necrotic damage and can’t take reactions until its next turn. On a successful save, the creature takes half damage, but suffers no other effect.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d6 for each slot level above 1st.", "Conjuration", false, 0, "Instant", true, true, false);
            AllSpells.Add("Arms of Hadar", ArmsOfHadar);

            Spell Bane = new Spell(1, "Bane", @"1st-level enchantment

Casting Time: 1 action
Range: 30 feet
Components: V, S, M (a drop of blood)
Duration: Concentration, up to 1 minute

Up to three creatures of your choice that you can see within range must make Charisma saving throws. Whenever a target that fails this saving throw makes an attack roll or a saving throw before the spell ends, the target must roll a d4 and subtract the number rolled from the attack roll or saving throw.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, you can target one additional creature for each slot level above 1st.", "Enchantment", false, 30, "Concentration, up to 1 minute", true, true, true);
            AllSpells.Add("Bane", Bane);

            Spell Bless = new Spell(1, "Bless", @"1st-level enchantment

Casting Time: 1 action
Range: 30 feet
Components: V, S, M (a sprinkling of holy water)
Duration: Concentration, up to 1 minute

You bless up to three creatures of your choice within range. Whenever a target makes an attack roll or a saving throw before the spell ends, the target can roll a d4 and add the number rolled to the attack roll or saving throw.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, you can target one additional creature for each slot level above 1st.", "Enchantment", false, 30, "Concentration, up to 1 minute", true, true, true);
            AllSpells.Add("Bless", Bless);

            Spell BurningHands = new Spell(1, "Burning Hands", @"1st-level evocation

Casting Time: 1 action
Range: Self (15-foot cone)
Components: V, S
Duration: Instantaneous

As you hold your hands with thumbs touching and fingers spread, a thin sheet of flames shoots forth from your outstretched fingertips. Each creature in a 15-foot cone must make a Dexterity saving throw. A creature takes 3d6 fire damage on a failed save, or half as much damage on a successful one.

The fire ignites any flammable objects in the area that aren’t being worn or carried.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d6 for each slot level above 1st.", "Evocation", false, 15, "Instantaneous", true, true, false);
            AllSpells.Add("Burning Hands", BurningHands);

            Spell Ceremony = new Spell(1, "Ceremony", @"1st-level evocation (ritual)

Casting Time: 1 hour
Range: Touch
Components: V, S, M (25 gp worth of powdered silver, which the spell consumes)
Duration: Instantaneous (see below)

You perform one of several religious ceremonies. When you cast the spell, choose one of the following ceremonies, the target of which must be within 10 feet of you throughout the casting.

Atonement. You touch one willing creature whose alignment has changed, and you make a DC 20 Wisdom (Insight) check. On a successful check, you restore the target to its original alignment.

Bless Water. You touch one vial of water and cause it to become holy water.

Coming of Age. You touch one humanoid who is a young adult. For the next 24 hours, whenever the target makes an ability check, it can roll a d4 and add the number rolled to the ability check. A creature can benefit from this rite only once.

Dedication. You touch one humanoid who wishes to be dedicated to your god’s service. For the next 24 hours, whenever the target makes a saving throw, it can roll a d4 and add the number rolled to the save. A creature can benefit from this rite only once.

Funeral Rite. You touch one corpse, and for the next 7 days, the target can’t become undead by any means short of a Wish spell.

Investiture (UA). You touch one willing humanoid. Choose one 1st-level spell you have prepared and expend a spell slot and any material components as if you were casting that spell. The spell has no effect. Instead, the target can cast this spell once without having to expend a spell slot or use material components. If the target doesn’t cast the spell within 1 hour, the invested spell is lost.

Wedding. You touch adult humanoids willing to be bonded together in marriage. For the next 7 days, each target gains a +2 bonus to AC while they are within 30 feet of each other. A creature can benefit from this rite again only if widowed.", "Evocation", false, 0, "Instant", true, true, true);
            AllSpells.Add("Ceremony", Ceremony);

            Spell CharmPerson = new Spell(1, "Charm Person", @"1st-level enchantment

Casting Time: 1 action
Range: 30 feet
Components: V, S
Duration: 1 hour

You attempt to charm a humanoid you can see within range. It must make a Wisdom saving throw, and does so with advantage if you or your companions are fighting it. If it fails the saving throw, it is charmed by you until the spell ends or until you or your companions do anything harmful to it. The charmed creature regards you as a friendly acquaintance. When the spell ends, the creature knows it was charmed by you.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, you can target one additional creature for each slot level above 1st. The creatures must be within 30 feet of each other when you target them.", "Enchantment", false, 30, "1 hour", true, true, false);
            AllSpells.Add("Charm Person", CharmPerson);

            Spell ChromaticOrb = new Spell(1, "Chromatic Orb", @"1st-level evocation

Casting Time: 1 action
Range: 90 feet
Components: V, S, M (a diamond worth at least 50 gp)
Duration: Instantaneous

You hurl a 4-inch-diameter sphere of energy at a creature that you can see within range. You choose acid, cold, fire, lightning, poison, or thunder for the type of orb you create, and then make a ranged spell attack against the target. If the attack hits, the creature takes 3d8 damage of the type you chose.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d8 for each slot level above 1st.", "Evocation", false, 90, "Instant", true, true, true);
            AllSpells.Add("Chromatic Orb", ChromaticOrb);

            Spell ColorSpray = new Spell(1, "Color Spray", @"1st-level illusion

Casting Time: 1 action
Range: Self (15-foot cone)
Components: V, S, M
Duration: 1 round

A dazzling array of flashing, colored light springs from your hand. Roll 6d10, the total is how many hit points of creatures this spell can effect. Creatures in a 15-foot cone originating from you are affected in ascending order of their current hit points (ignoring unconscious creatures and creatures that can’t see).

Starting with the creature that has the lowest current hit points, each creature affected by this spell is blinded until the spell ends. Subtract each creature’s hit points from the total before moving on to the creature with the next lowest hit points. A creature’s hit points must be equal to or less than the remaining total for the creature to be affected.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, roll an additional 2d10 for each slot level above 1st.", "Illusion", false, 15, "1 round", true, true, true);
            AllSpells.Add("Color Spray", ColorSpray);

            Spell Command = new Spell(1, "Command", @"1st-level enchantment

Casting Time: 1 action
Range: 60 feet
Components: V
Duration: 1 round

You speak a one - word command to a creature you can see within range.The target must succeed on a Wisdom saving throw or follow the command on its next turn.The spell has no effect if the target is undead, if it doesn’t understand your language, or if your command is directly harmful to it. Some typical commands and their effects follow.You might issue a command other than one described here. If you do so, the DM determines how the target behaves.If the target can’t follow your command, the spell ends.

Approach.The target moves toward you by the shortest and most direct route, ending its turn if it moves within 5 feet of you.

Drop.The target drops whatever it is holding and then ends its turn.

Flee.The target spends its turn moving away from you by the fastest available means.

Grovel.The target falls prone and then ends its turn.

Halt.The target doesn’t move and takes no actions. A flying creature stays aloft, provided that it is able to do so.If it must move to stay aloft, it flies the minimum distance needed to remain in the air.

At Higher Levels.When you cast this spell using a spell slot of 2nd level or higher, you can affect one additional creature for each slot level above 1st.The creatures must be within 30 feet of each other when you target them.", "Enchantment", false, 60, "1 round", true, false, false);
            AllSpells.Add("Command", Command);

            Spell CompelledDuel = new Spell(1, "Compelled Duel", @"1st-level enchantment

Casting Time: 1 bonus action
Range: 30 feet
Components: V
Duration: Concentration, up to 1 minute

You attempt to compel a creature into a duel. One creature that you can see within range must make a Wisdom saving throw. On a failed save, the creature is drawn to you, compelled by your divine demand. For the duration, it has disadvantage on attack rolls against creatures other than you, and must make a Wisdom saving throw each time it attempts to move to a space that is more than 30 feet away from you; if it succeeds on this saving throw, this spell doesn’t restrict the target’s movement for that turn.

The spell ends if you attack any other creature, if you cast a spell that targets a hostile creature other than the target, if a creature friendly to you damages the target or casts a harmful spell on it, or if you end your turn more than 30 feet away from the target.", "Enchantment", true, 30, "Concentration, up to 1 minute", true, false, false);
            AllSpells.Add("Compelled Duel", CompelledDuel);

            Spell ComprehendLanguages = new Spell(1, "Comprehend Languages", @"1st-level divination (ritual)

Casting Time: 1 action
Range: Self
Components: V, S, M (a pinch of soot and salt)
Duration: 1 hour

For the duration, you understand the literal meaning of any spoken language that you hear. You also understand any written language that you see, but you must be touching the surface on which the words are written. It takes about 1 minute to read one page of text.

This spell doesn’t decode secret messages in a text or glyph, such as an arcane sigil, that isn’t part of a written language.", "Divination", false, 0, "1 hour", true, true, true);
            AllSpells.Add("Comprehend Languages", ComprehendLanguages);

            Spell CreateDestroyWater = new Spell(1, "Create/Destroy Water", @"1st-level transmutation

Casting Time: 1 action
Range: 30 feet
Components: V, S, M (a drop of water if creating water or a few grains of sand if destroying it)
Duration: Instantaneous

You either create or destroy water.

Create Water. You create up to 10 gallons of clean water within range in an open container. Alternatively, the water falls as rain in a 30-foot cube within range, extinguishing exposed flames in the area.

Destroy Water. You destroy up to 10 gallons of water in an open container within range. Alternatively, you destroy fog in a 30-foot cube within range.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, you create or destroy 10 additional gallons of water, or the size of the cube increases by 5 feet, for each slot level above 1st.", "Transmutation", false, 30, "Instant", true, true, true);
            AllSpells.Add("Create/Destroy Water", CreateDestroyWater);

            Spell CureWounds = new Spell(1, "Cure Wounds", @"1st-level evocation

Casting Time: 1 action
Range: Touch
Components: V, S
Duration: Instantaneous

A creature you touch regains a number of hit points equal to 1d8 + your spellcasting ability modifier. This spell has no effect on undead or constructs.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the healing increases by 1d8 for each slot level above 1st.

", "Evocation", false, 0, "Instant", true, true, false);
            AllSpells.Add("Cure Wounds", CureWounds);

            Spell DetectGoodEvil = new Spell(1, "Detect Good/Evil", @"1st-level divination

Casting Time: 1 action
Range: Self
Components: V, S
Duration: Concentration, up to 10 minutes

For the duration, you know if there is an aberration, celestial, elemental, fey, fiend, or undead within 30 feet of you, as well as where the creature is located. Similarly, you know if there is a place or object within 30 feet of you that has been magically consecrated or desecrated.

The spell can penetrate most barriers, but it is blocked by 1 foot of stone, 1 inch of common metal, a thin sheet of lead, or 3 feet of wood or dirt.", "Divination", false, 0, "Concentration, up to 10 minutes", true, true, false);
            AllSpells.Add("Detect Good/Evil", DetectGoodEvil);

            Spell DetectMagic = new Spell(1, "Detect Magic", @"1st-level divination (ritual)

Casting Time: 1 action
Range: Self
Components: V, S
Duration: Concentration, up to 10 minutes

For the duration, you sense the presence of magic within 30 feet of you. If you sense magic in this way, you can use your action to see a faint aura around any visible creature or object in the area that bears magic, and you learn its school of magic, if any.

The spell can penetrate most barriers, but is blocked by 1 foot of stone, 1 inch of common metal, a thin sheet of lead, or 3 feet of wood or dirt.", "Divination", false, 30, "Concentration, up to 10 minutes", true, true, false);
            AllSpells.Add("Detect Magic", DetectMagic);

            Spell DetectPoisonDisease = new Spell(1, "Detect Poison/Disease", @"1st-level divination

Casting Time: 1 action
Range: Self
Components: V, S, M (a yew leaf)
Duration: Concentration, up to 10 minutes

For the duration, you can sense the presence and location of poisons, poisonous creatures, and diseases within 30 feet of you. You also identify the kind of poison, poisonous creature, or disease in each case.

The spell can penetrate most barriers, but is blocked by 1 foot of stone, 1 inch of common metal, a thin sheet of lead, or 3 feet of wood or dirt.", "Divination", false, 30, "Concentration, up to 10 minutes", true, true, true);
            AllSpells.Add("Detect Poison/Disease", DetectPoisonDisease);

            Spell DisguiseSelf = new Spell(1, "Disguise Self", @"1st-level illusion

Casting Time: 1 action
Range: Self
Components: V, S
Duration: 1 hour

You make yourself – including your clothing, armor, weapons, and other belongings on your person – look different until the spell ends or until you use your action to dismiss it. You can seem 1 foot shorter or taller and can appear thin, fat, or in between. You can’t change your body type, so you must adopt a form that has the same basic arrangement of limbs. Otherwise, the extent of the illusion is up to you.

The changes wrought by this spell fail to hold up to physical inspection. For example, if you use this spell to add a hat to your outfit, objects pass through the hat, and anyone who touches it would feel nothing or would feel your head and hair. If you use this spell to appear thinner than you are, the hand of someone who reaches out to touch you would bump into you while it was seemingly still in midair. To discern that you are disguised, a creature can use its action to inspect your appearance and must succeed on an Intelligence (Investigation) check against your spell save DC.", "Illusion", false, 0, "1 hour", true, true, false);
            AllSpells.Add("Disguise Self", DisguiseSelf);

            Spell DissonantWhispers = new Spell(1, "Dissonant Whispers", @"1st-level enchantment

Casting Time: 1 action
Range: 60 feet
Components: V
Duration: Instantaneous

You whisper a discordant melody that only one creature of your choice within range can hear, wracking it with terrible pain. The target must make a Wisdom saving throw. On a failed save, it takes 3d6 psychic damage and must immediately use its reaction, if available, to move as far as its speed allows away from you. The creature doesn’t move into obviously dangerous ground, such as a fire or a pit. On a successful save, the target takes half as much damage and doesn’t have to move away. A deafened creature automatically succeeds on the save.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d6 for each slot level above 1st.", "Enchantment", false, 60, "Instant", true, false, false);
            AllSpells.Add("Dissonant Whispers", DissonantWhispers);

            Spell DivineFavor = new Spell(1, "Divine Favor", @"1st-level evocation

Casting Time: 1 bonus action
Range: Self
Components: V, S
Duration: Concentration, up to 1 minute

Your prayer empowers you with divine radiance. Until the spell ends, your weapon attacks deal an extra 1d4 radiant damage on a hit.", "Evocation", true, 0, "Concentration, up to 1 minute", true, true, false);
            AllSpells.Add("Divine Favor", DivineFavor);

            Spell EnsnaringStrike = new Spell(1, "Ensnaring Strike", @"1st-level conjuration

Casting Time: 1 bonus action
Range: Self
Components: V
Duration: Concentration, up to 1 minute

The next time you hit a creature with a weapon attack before this spell ends, a writhing mass of thorny vines appears at the point of impact, and the target must succeed on a Strength saving throw or be restrained by the magical vines until the spell ends. A Large or larger creature has advantage on this saving throw. If the target succeeds on the save, the vines shrivel away.

While restrained by this spell, the target takes 1d6 piercing damage at the start of each of its turns. A creature restrained by the vines or one that can touch the creature can use its action to make a Strength check against your spell save DC. On a success, the target is freed.

At Higher Levels. If you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d6 for each slot level above 1st.", "Conjuration", true, 0, "Concentration, up to 1 minute", true, false, false);
            AllSpells.Add("Ensnaring Strike", EnsnaringStrike);

            Spell Entangle = new Spell(1, "Entangle", @"1st-level conjuration

Casting Time: 1 action
Range: 90 feet
Components: V, S
Duration: Concentration, up to 1 minute

Grasping weeds and vines sprout from the ground in a 20-foot square starting from a point within range. For the duration, these plants turn the ground in the area into difficult terrain.

A creature in the area when you cast the spell must succeed on a Strength saving throw or be restrained by the entangling plants until the spell ends. A creature restrained by the plants can use its action to make a Strength check against your spell save DC. On a success, it frees itself.

When the spell ends, the conjured plants wilt away.", "Conjuration", false, 90, "Concentration, up to 1 minute", true, true, false);
            AllSpells.Add("Entangle", Entangle);

            Spell ExpeditiousRetreat = new Spell(1, "Expeditious Retreat", @"1st-level transmutation

Casting Time: 1 bonus action
Range: Self
Components: V, S
Duration: Concentration, up to 10 minutes

This spell allows you to move at an incredible pace. When you cast this spell, and then as a bonus action on each of your turns until the spell ends, you can take the Dash action.", "Transmutation", true, 0, "Concentration, up to 10 minutes", true, true, false);
            AllSpells.Add("Expeditious Retreat", ExpeditiousRetreat);

            Spell FaerieFire = new Spell(1, "Faerie Fire", @"1st-level evocation

Casting Time: 1 action
Range: 60 feet
Components: V
Duration: Concentration, up to 1 minute

Each object in a 20-foot cube within range is outlined in blue, green, or violet light (your choice).

Any creature in the area when the spell is cast is also outlined in light if it fails a Dexterity saving throw. For the duration, objects and affected creatures shed dim light in a 10-foot radius.

Any attack roll against an affected creature or object has advantage if the attacker can see it, and the affected creature or object can’t benefit from being invisible.", "Evocation", false, 60, "Concentration, 1 minute", true, false, false);
            AllSpells.Add("Faerie Fire", FaerieFire);

            Spell FalseLife = new Spell(1, "False Life", @"1st-level necromancy

Casting Time: 1 action
Range: Self
Components: V, S, M (a small amount of alcohol or distilled spirits)
Duration: 1 hour

Bolstering yourself with a necromantic facsimile of life, you gain 1d4 + 4 temporary hit points for the duration.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, you gain 5 additional temporary hit points for each slot level above 1st.", "Necromancy", false, 0, "1 hour", true, true, true);
            AllSpells.Add("False Life", FalseLife);

            Spell FeatherFall = new Spell(1, "Feather Fall", @"1st-level transmutation

Casting Time: 1 reaction, which you take when you or a creature within 60 feet of you falls
Range: 60 feet
Components: V, M (a small feather or piece of down)
Duration: 1 minute

Choose up to five falling creatures within range. A falling creature’s rate of descent slows to 60 feet per round until the spell ends. If the creature lands before the spell ends, it takes no falling damage and can land on its feet, and the spell ends for that creature.", "Transmutation", true, 60, "1 minute", true, false, true);
            AllSpells.Add("Feather Fall", FeatherFall);

            Spell FindFamiliar = new Spell(1, "Find Familiar", @"1st-level conjuration (ritual)

Casting Time: 1 hour
Range: 10 feet
Components: V, S, M (10 gp worth of charcoal, incense, and herbs that must be consumed by fire in a brass brazier)
Duration: Instantaneous

You gain the service of a familiar, a spirit that takes an animal form you choose: bat, cat, crab, frog (toad), hawk, lizard, octopus, owl, poisonous snake, fish (quipper), rat, raven, sea horse, spider, or weasel. Appearing in an unoccupied space within range, the familiar has the statistics of the chosen form, though it is a celestial, fey, or fiend (your choice) instead of a beast.

Your familiar acts independently of you, but it always obeys your commands. In combat, it rolls its own initiative and acts on its own turn. A familiar can’t attack, but it can take other actions as normal.

When the familiar drops to 0 hit points, it disappears, leaving behind no physical form. It reappears after you cast this spell again.

While your familiar is within 100 feet of you, you can communicate with it telepathically. Additionally, as an action, you can see through your familiar’s eyes and hear what it hears until the start of your next turn, gaining the benefits of any special senses that the familiar has. During this time, you are deaf and blind with regard to your own senses.

As an action, you can temporarily dismiss your familiar. It disappears into a pocket dimension where it awaits your summons. Alternatively, you can dismiss it forever. As an action while it is temporarily dismissed, you can cause it to reappear in any unoccupied space within 30 feet of you.

You can’t have more than one familiar at a time. If you cast this spell while you already have a familiar, you instead cause it to adopt a new form. Choose one of the forms from the above list. Your familiar transforms into the chosen creature.

Finally, when you cast a spell with a range of touch, your familiar can deliver the spell as if it had cast the spell. Your familiar must be within 100 feet of you, and it must use its reaction to deliver the spell when you cast it. If the spell requires an attack roll, you use your attack modifier for the roll.", "Conjuration", false, 10, "Instant", true, true, true);
            AllSpells.Add("Find Familiar", FindFamiliar);

            Spell FogCloud = new Spell(1, "Fog Cloud", @"1st-level conjuration

Casting Time: 1 action
Range: 120 feet
Components: V, S
Duration: Concentration, up to 1 hour

You create a 20-foot-radius sphere of fog centered on a point within range. The sphere spreads around corners, and its area is heavily obscured. It lasts for the duration or until a wind of moderate or greater speed (at least 10 miles per hour) disperses it.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the radius of the fog increases by 20 feet for each slot level above 1st.", "Conjuration", false, 120, "Concentration, up to 1 hour", true, true, false);
            AllSpells.Add("Fog Cloud", FogCloud);

            Spell Goodberry = new Spell(1, "Goodberry", @"1st-level transmutation

Casting Time: 1 action
Range: Touch
Components: V, S, M (a sprig of mistletoe)
Duration: Instantaneous

Up to ten berries appear in your hand and are infused with magic for the duration. A creature can use its action to eat one berry. Eating a berry restores 1 hit point, and the berry provides enough nourishment to sustain a creature for one day.

The berries lose their potency if they have not been consumed within 24 hours of the casting of this spell.", "Transmutation", false, 0, "Instant", true, true, true);
            AllSpells.Add("Goodberry", Goodberry);

            Spell Grease = new Spell(1, "Grease", @"1st-level conjuration

Casting Time: 1 action
Range: 60 feet
Components: V, S, M (a bit of pork rind or butter)
Duration: 1 minute

Slick grease covers the ground in a 10-foot square centered on a point within range and turns it into difficult terrain for the duration.

When the grease appears, each creature standing in its area must succeed on a Dexterity saving throw or fall prone. A creature that enters the area or ends its turn there must also succeed on a Dexterity saving throw or fall prone.", "Conjuration", false, 60, "1 minute", true, true, true);
            AllSpells.Add("Grease", Grease);

            Spell GuidingBolt = new Spell(1, "Guiding Bolt", @"1st-level evocation

Casting Time: 1 action
Range: 120 feet
Components: V, S
Duration: 1 round

A flash of light streaks toward a creature of your choice within range. Make a ranged spell attack against the target. On a hit, the target takes 4d6 radiant damage, and the next attack roll made against this target before the end of your next turn has advantage, thanks to the mystical dim light glittering on the target until then.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d6 for each slot level above 1st.", "Evocation", false, 120, "1 round", true, true, false);
            AllSpells.Add("Guiding Bolt", GuidingBolt);

            Spell HailOfThorns = new Spell(1, "Hail of Thorns", @"1st-level conjuration

Casting Time: 1 bonus action
Range: Self
Components: V
Duration: Concentration, up to 1 minute

The next time you hit a creature with a ranged weapon attack before the spell ends, this spell creates a rain of thorns that sprouts from your ranged weapon or ammunition. In addition to the normal effect of the attack, the target of the attack and each creature within 5 feet of it must make a Dexterity saving throw. A creature takes 1d10 piercing damage on a failed save, or half as much damage on a successful one.

At Higher Levels. If you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d10 for each slot level above 1st (to a maximum of 6d10).", "Conjuration", true, 0, "Concentration, up to 1 minute", true, false, false);
            AllSpells.Add("Hail of Thorns", HailOfThorns);

            Spell HealingWord = new Spell(1, "Healing Word", @"1st-level evocation

Casting Time: 1 bonus action
Range: 60 feet
Components: V
Duration: Instantaneous

A creature of your choice that you can see within range regains hit points equal to 1d4 + your spellcasting ability modifier. This spell has no effect on undead or constructs.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the healing increases by 1d4 for each slot level above 1st.", "Evocation", true, 60, "Instant", true, false, false);
            AllSpells.Add("Healing Word", HealingWord);

            Spell HellishRebuke = new Spell(1, "Hellish Rebuke", @"1st-level evocation

Casting Time: 1 reaction, which you take when you are damaged by a creature within 60 feet of you that you can see
Range: 60 feet
Components: V, S
Duration: Instantaneous

You point your finger, and the creature that damaged you is momentarily surrounded by hellish flames. The creature must make a Dexterity saving throw. It takes 2d10 fire damage on a failed save, or half as much damage on a successful one.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d10 for each slot level above 1st.", "Evocation", true, 60, "Instant", true, true, false);
            AllSpells.Add("Hellish Rebuke", HellishRebuke);

            Spell Heroism = new Spell(1, "Heroism", @"1st-level enchantment

Casting Time: 1 action
Range: Touch
Components: V, S
Duration: Concentration, up to 1 minute

A willing creature you touch is imbued with bravery. Until the spell ends, the creature is immune to being frightened and gains temporary hit points equal to your spellcasting ability modifier at the start of each of its turns. When the spell ends, the target loses any remaining temporary hit points from this spell.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, you can target one additional creature for each slot level above 1st.", "Enchantment", false, 0, "Concentration, up to 1 minute", true, true, false);
            AllSpells.Add("Heroism", Heroism);

            Spell Hex = new Spell(1, "Hex", @"1st-level enchantment

Casting Time: 1 bonus action
Range: 90 feet
Components: V, S, M (the petrified eye of a newt)
Duration: Concentration, up to 1 hour

You place a curse on a creature that you can see within range. Until the spell ends, you deal an extra 1d6 necrotic damage to the target whenever you hit it with an attack. Also, choose one ability when you cast the spell. The target has disadvantage on ability checks made with the chosen ability.

If the target drops to 0 hit points before this spell ends, you can use a bonus action on a subsequent turn of yours to curse a new creature.

A Remove Curse cast on the target ends this spell early.

At Higher Levels. When you cast this spell using a spell slot of 3rd or 4th level, you can maintain your concentration on the spell for up to 8 hours. When you use a spell slot of 5th level or higher, you can maintain your concentration on the spell for up to 24 hours.", "Enchantment", true, 90, "Concentration, up to 1 hour", true, true, true);
            AllSpells.Add("Hex", Hex);

            Spell HuntersMark = new Spell(1, "Hunter's Mark", @"1st-level divination

Casting Time: 1 bonus action
Range: 90 feet
Components: V
Duration: Concentration, up to 1 hour

You choose a creature you can see within range and mystically mark it as your quarry. Until the spell ends, you deal an extra 1d6 damage to the target whenever you hit it with a weapon attack, and you have advantage on any Wisdom (Perception) or Wisdom (Survival) check you make to find it.

If the target drops to 0 hit points before this spell ends, you can use a bonus action on a subsequent turn of yours to mark a new creature.

At Higher Levels. When you cast this spell using a spell slot of 3rd or 4th level, you can maintain your concentration on the spell for up to 8 hours. When you use a spell slot of 5th level or higher, you can maintain your concentration on the spell for up to 24 hours.", "Divination", true, 90, "Concentration, up to 1 hour", true, false, false);
            AllSpells.Add("Hunter's Mark", HuntersMark);

            Spell Identify = new Spell(1, "Identify", @"1st-level divination (ritual)

Casting Time: 1 minute
Range: Touch
Components: V, S, M (a pearl worth at least 100 gp and an owl feather)
Duration: Instantaneous

You choose one object that you must touch throughout the casting of the spell. If it is a magic item or some other magic-imbued object, you learn its properties and how to use them, whether it requires attunement to use, and how many charges it has, if any. You learn whether any spells are affecting the item and what they are. If the item was created by a spell, you learn which spell created it.

If you instead touch a creature throughout the casting, you learn what spells, if any, are currently affecting it.", "Divination", false, 0, "Instantaneous", true, true, true);
            AllSpells.Add("Identify", Identify);

            Spell IllusoryScript = new Spell(1, "Illusory Script", @"1st-level illusion

Casting Time: 1 minute
Range: Touch
Components: S, M (a lead-based ink worth at least 10 gp, which the spell consumes)
Duration: 10 days

You write on parchment, paper, or some other suitable writing material and imbue it with a potent illusion that lasts for the duration.

To you and any creatures you designate when you cast the spell, the writing appears normal, written in your hand, and conveys whatever meaning you intended when you wrote the text. To all others, the writing appears as if it were written in an unknown or magical script that is unintelligible. Alternatively, you can cause the writing to appear to be an entirely different message, written in a different hand and language, though the language must be one you know.

Should the spell be dispelled, the original script and the illusion both disappear. A creature with truesight can read the hidden message.", "Illusion", false, 0, "10 days", false, true, true);
            AllSpells.Add("Illusory Script", IllusoryScript);

            Spell InflictWounds = new Spell(1, "Inflict Wounds", @"1st-level necromancy

Casting Time: 1 action
Range: Touch
Components: V, S
Duration: Instantaneous

Make a melee spell attack against a creature you can reach. On a hit, the target takes 3d10 necrotic damage.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d10 for each slot level above 1st.", "Necromancy", false, 0, "Instant", true, true, false);
            AllSpells.Add("Inflict Wounds", InflictWounds);

            Spell Jump = new Spell(1, "Jump", @"1st-level transmutation

Casting Time: 1 action
Range: Touch
Components: V, S, M (a grasshopper’s hind leg)
Duration: 1 minute

You touch a creature. The creature’s jump distance is tripled until the spell ends.", "Transmutation", false, 0, "1 minute", true, true, true);
            AllSpells.Add("Jump", Jump);

            Spell Longstrider = new Spell(1, "Longstrider", @"1st-level transmutation

Casting Time: 1 action
Range: Touch
Components: V, S, M (a pinch of dirt)
Duration: 1 hour

You touch a creature. The target’s speed increases by 10 feet until the spell ends.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, you can target one additional creature for each slot level above 1st.", "Transmutation", false, 0, "1 hour", true, true, true);
            AllSpells.Add("Longstrider", Longstrider);

            Spell MageArmour = new Spell(1, "Mage Armour", @"1st-level abjuration

Casting Time: 1 action
Range: Touch
Components: V, S, M (a piece of cured leather)
Duration: 8 hours

You touch a willing creature who isn’t wearing armor, and a protective magical force surrounds it until the spell ends. The target’s base AC becomes 13 + its Dexterity modifier. The spell ends if the target dons armor or if you dismiss the spell as an action.", "Abjuration", false, 0, "8 hours", true, true, true);
            AllSpells.Add("Mage Armour", MageArmour);

            Spell MagicMissile = new Spell(1, "Magic Missile", @"1st-level evocation

Casting Time: 1 action
Range: 120 feet
Components: V, S
Duration: Instantaneous

You create three glowing darts of magical force. Each dart hits a creature of your choice that you can see within range. A dart deals 1d4 + 1 force damage to its target. The darts all strike simultaneously and you can direct them to hit one creature or several.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the spell creates one more dart for each slot level above 1st.", "Evocation", false, 120, "Instant", true, true, false);
            AllSpells.Add("Magic Missile", MagicMissile);

            Spell ProtectionGoodEvil = new Spell(1, "Protection from Good/Evil", @"1st-level abjuration

Casting Time: 1 action
Range: Touch
Components: V, S, M (holy water or powdered silver and iron, which the spell consumes)
Duration: Concentration, up to 10 minutes

Until the spell ends, one willing creature you touch is protected against certain types of creatures: aberrations, celestials, elementals, fey, fiends, and undead.

The protection grants several benefits. Creatures of those types have disadvantage on attack rolls against the target. The target also can’t be charmed, frightened, or possessed by them. If the target is already charmed, frightened, or possessed by such a creature, the target has advantage on any new saving throw against the relevant effect.", "Abjuration", false, 0, "Concentration, up to 10 minutes", true, true, true);
            AllSpells.Add("Protection from Good/Evil", ProtectionGoodEvil);

            Spell PurifyFoodDrink = new Spell(1, "Purify Food/Drink", @"1st-level transmutation (ritual)

Casting Time: 1 action
Range: 10 feet
Components: V, S
Duration: Instantaneous

All nonmagical food and drink within a 5-foot-radius sphere centered on a point of your choice within range is purified and rendered free of poison and disease.", "Transmutation", false, 10, "Instant", true, true, false);
            AllSpells.Add("Purify Food/Drink", PurifyFoodDrink);

            Spell RayOfSickness = new Spell(1, "Ray of Sickness", @"1st-level necromancy

Casting Time: 1 action
Range: 60 feet
Components: V, S
Duration: Instantaneous

A ray of sickening greenish energy lashes out toward a creature within range. Make a ranged spell attack against the target. On a hit, the target takes 2d8 poison damage and must make a Constitution saving throw. On a failed save, it is also poisoned until the end of your next turn.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d8 for each slot level above 1st.", "Necromancy", false, 60, "Instant", true, true, false);
            AllSpells.Add("Ray Of Sickness", RayOfSickness);

            Spell Sanctuary = new Spell(1, "Sanctuary", @"1st-level abjuration

Casting Time: 1 bonus action
Range: 30 feet
Components: V, S, M (a small silver mirror)
Duration: 1 minute

You ward a creature within range against attack. Until the spell ends, any creature who targets the warded creature with an attack or a harmful spell must first make a Wisdom saving throw. On a failed save, the creature must choose a new target or lose the attack or spell. This spell doesn’t protect the warded creature from area effects, such as the explosion of a fireball.

If the warded creature makes an attack or casts a spell that affects an enemy creature, this spell ends.", "Abjuration", true, 30, "1 minute", true, true, true);
            AllSpells.Add("Sanctuary", Sanctuary);

            Spell SearingSmite = new Spell(1, "Searing Smite", @"1st-level evocation

Casting Time: 1 bonus action
Range: Self
Components: V
Duration: Concentration, up to 1 minute

The next time you hit a creature with a melee weapon attack during the spell’s duration, your weapon flares with white-hot intensity, and the attack deals an extra 1d6 fire damage to the target and causes the target to ignite in flames.

At the start of each of its turns until the spell ends, the target must make a Constitution saving throw. On a failed save, it takes 1d6 fire damage. On a successful save, the spells ends. If the target or a creature within 5 feet of it uses an action to put out the flames, or if some other effect douses the flames (such as the target being submerged in water), the spell ends.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the initial extra damage dealt by the attack increases by 1d6 for each slot.", "Evocation", true, 0, "Concentration, up to 1 minute", true, false, false);
            AllSpells.Add("Searing Smite", SearingSmite);

            Spell Shield = new Spell(1, "Shield", @"1st-level abjuration

Casting Time: 1 reaction, which you take when you are hit by an attack or targeted by the Magic Missile spell
Range: Self
Components: V, S
Duration: 1 round

An invisible barrier of magical force appears and protects you. Until the start of your next turn, you have a +5 bonus to AC, including against the triggering attack, and you take no damage from Magic Missile.", "Abjuration", true, 0, "1 round", true, true, false);
            AllSpells.Add("Shield", Shield);

            Spell ShieldOfFaith = new Spell(1, "Shield of Faith", @"1st-level abjuration

Casting Time: 1 bonus action
Range: 60 feet
Components: V, S, M (a small parchment with a bit of holy text written on it)
Duration: Concentration, up to 10 minutes

A shimmering field appears and surrounds a creature of your choice within range, granting it a +2 bonus to AC for the duration.", "Abjuration", true, 60, "Concentration, up to 10 minutes", true, true, true);
            AllSpells.Add("Shield of Faith", ShieldOfFaith);

            Spell SilentImage = new Spell(1, "Silent Image", @"1st-level illusion

Casting Time: 1 action
Range: 60 feet
Components: V, S, M (a bit of fleece)
Duration: Concentration, up to 10 minutes

You create the image of an object, a creature, or some other visible phenomenon that is no larger than a 15-foot cube. The image appears at a spot within range and lasts for the duration. The image is purely visual; it isn’t accompanied by sound, smell, or other sensory effects.

You can use your action to cause the image to move to any spot within range. As the image changes location, you can alter its appearance so that its movements appear natural for the image. For example, if you create an image of a creature and move it, you can alter the image so that it appears to be walking.

Physical interaction with the image reveals it to be an illusion, because things can pass through it. A creature that uses its action to examine the image can determine that it is an illusion with a successful Intelligence (Investigation) check against your spell save DC. If a creature discerns the illusion for what it is, the creature can see through the image.", "Illusion", false, 60, "Concentration, up to 10 minutes", true, true, true);
            AllSpells.Add("Silent Image", SilentImage);

            Spell Sleep = new Spell(1, "Sleep", @"1st-level enchantment

Casting Time: 1 action
Range: 90 feet
Components: V, S, M (a pinch of fine sand, rose petals, or a cricket)
Duration: 1 minute

This spell sends creatures into a magical slumber. Roll 5d8, the total is how many hit points of creatures this spell can affect. Creatures within 20 feet of a point you choose within range are affected in ascending order of their current hit points (ignoring unconscious creatures).

Starting with the creature that has the lowest current hit points, each creature affected by this spell falls unconscious until the spell ends, the sleeper takes damage, or someone uses an action to shake or slap the sleeper awake. Subtract each creature’s hit points from the total before moving on to the creature with the next lowest hit points. A creature’s hit points must be equal to or less than the remaining total for that creature to be affected. Undead and creatures immune to being charmed aren’t affected by this spell.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, roll an additional 2d8 for each slot level above 1st.", "Enchantment", false, 90, "1 minute", true, true, true);
            AllSpells.Add("Sleep", Sleep);

            Spell SpeakWithAnimals = new Spell(1, "Speak With Animals", @"1st-level divination (ritual)

Casting Time: 1 action
Range: Self
Components: V, S
Duration: 10 minutes

You gain the ability to comprehend and verbally communicate with beasts for the duration. The knowledge and awareness of many beasts is limited by their intelligence, but at minimum, beasts can give you information about nearby locations and monsters, including whatever they can perceive or have perceived within the past day. You might be able to persuade a beast to perform a small favor for you, at the DM’s discretion.", "Divination", false, 0, "10 minutes", true, true, true);
            AllSpells.Add("Speak With Animals", SpeakWithAnimals);

            Spell TashasHideousLaughter = new Spell(1, "Tasha's Hideous Laughter", @"1st-level enchantment

Casting Time: 1 action
Range: 30 feet
Components: V, S, M (tiny tarts and a feather that is waved in the air)
Duration: Concentration, up to 1 minute

A creature of your choice that you can see within range perceives everything as hilariously funny and falls into fits of laughter if this spell affects it. The target must succeed on a Wisdom saving throw or fall prone, becoming incapacitated and unable to stand up for the duration. A creature with an Intelligence score of 4 or less isn’t affected.

At the end of each of its turns, and each time it takes damage, the target can make another Wisdom saving throw. The target has advantage on the saving throw if it’s triggered by damage. On a success, the spell ends.", "Enchantment", false, 30, "Concentration, up to 1 minute", true, true, true);
            AllSpells.Add("Tasha's Hideous Laughter", TashasHideousLaughter);

            Spell TensersDisk = new Spell(1, "Tenser's Floating Disk", @"1st-level conjuration (ritual)

Casting Time: 1 action
Range: 30 feet
Components: V, S, M (a drop of mercury)
Duration: 1 hour

This spell creates a circular, horizontal plane of force, 3 feet in diameter and 1 inch thick, that floats 3 feet above the ground in an unoccupied space of your choice that you can see within range. The disk remains for the duration, and can hold up to 500 pounds. If more weight is placed on it, the spell ends, and everything on the disk falls to the ground.

The disk is immobile while you are within 20 feet of it. If you move more than 20 feet away from it, the disk follows you so that it remains within 20 feet of you. It can move across uneven terrain, up or down stairs, slopes, and the like, but it can’t cross an elevation change of 10 feet or more. For example, the disk can’t move across a 10-foot-deep pit, nor could it leave such a pit if it were created at the bottom.

If you move more than 100 feet from the disk (typically because it can’t move around an obstacle to follow you), the spell ends.", "Conjuration", false, 30, "1 hour", true, true, true);
            AllSpells.Add("Tenser's Floating Disk", TensersDisk);

            Spell ThunderousSmite = new Spell(1, "Thunderous Smite", @"1st-level evocation

Casting Time: 1 bonus action
Range: Self
Components: V
Duration: Concentration, up to 1 minute

The first time you hit with a melee weapon attack during this spell’s duration, your weapon rings with thunder that is audible within 300 feet of you, and the attack deals an extra 2d6 thunder damage to the target. Additionally, if the target is a creature, it must succeed on a Strength saving throw or be pushed 10 feet away from you and knocked prone.", "Evocation", true, 0, "Concentration, up to 1 minute", true, false, false);
            AllSpells.Add("Thunderous Smite", ThunderousSmite);

            Spell Thunderwave = new Spell(1, "Thunderwave", @"1st-level evocation

Casting Time: 1 action
Range: Self (15-foot cube)
Components: V, S
Duration: Instantaneous

A wave of thunderous force sweeps out from you. Each creature in a 15-foot cube originating from you must make a Constitution saving throw. On a failed save, a creature takes 2d8 thunder damage and is pushed 10 feet away from you. On a successful save, the creature takes half as much damage and isn’t pushed.

In addition, unsecured objects that are completely within the area of effect are automatically pushed 10 feet away from you by the spell’s effect, and the spell emits a thunderous boom audible out to 300 feet.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d8 for each slot level above 1st.", "Evocation", false, 15, "Instant", true, true, false);
            AllSpells.Add("Thunderwave", Thunderwave);

            Spell UnseenServant = new Spell(1, "Unseen Servant", @"1st-level conjuration (ritual)

Casting Time: 1 action
Range: 60 feet
Components: V, S, M (a piece of string and a bit of wood)
Duration: 1 hour

This spell creates an invisible, mindless, shapeless, Medium force that performs simple tasks at your command until the spell ends. The servant springs into existence in an unoccupied space on the ground within range. It has AC 10, 1 hit point, and a Strength of 2, and it can’t attack. If it drops to 0 hit points, the spell ends.

Once on each of your turns as a bonus action, you can mentally command the servant to move up to 15 feet and interact with an object. The servant can perform simple tasks that a human servant could do, such as fetching things, cleaning, mending, folding clothes, lighting fires, serving food, and pouring wine. Once you give the command, the servant performs the task to the best of its ability until it completes the task, then waits for your next command.

If you command the servant to perform a task that would move it more than 60 feet away from you, the spell ends.", "Conjuration", false, 60, "1 hour", true, true, true);
            AllSpells.Add("Unseen Servant", UnseenServant);

            Spell WitchBolt = new Spell(1, "Witch Bolt", @"1st-level evocation

Casting Time: 1 action
Range: 30 feet
Components: V, S, M (a twig from a tree that has been struck by lightning)
Duration: Concentration, up to 1 minute

A beam of crackling, blue energy lances out toward a creature within range, forming a sustained arc of lightning between you and the target. Make a ranged spell attack against that creature. On a hit, the target takes 1d12 lightning damage, and on each of your turns for the duration, you can use your action to deal 1d12 lightning damage to the target automatically. The spell ends if you use your action to do anything else. The spell also ends if the target is ever outside the spell’s range or if it has total cover from you.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the initial damage increases by 1d12 for each slot level above 1st.", "Evocation", false, 30, "Concentration, up to 1 minute", true, true, true);
            AllSpells.Add("Witch Bolt", WitchBolt);

            Spell WrathfulSmite = new Spell(1, "Wrathful Smite", @"1st-level evocation

Casting Time: 1 bonus action
Range: Self
Components: V
Duration: Concentration, up to 1 minute

The next time you hit with a melee weapon attack during this spell’s duration, your attack deals an extra 1d6 psychic damage. Additionally, if the target is a creature, it must make a Wisdom saving throw or be frightened of you until the spell ends. As an action, the creature can make a Wisdom check against your spell save DC to steel its resolve and end this spell.", "Evocation", true, 0, "Concentration, up to 1 minute", true, false, false);
            AllSpells.Add("Wrathful Smite", WrathfulSmite);
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            TxtDisplayInfo.Clear();
            if (TabGroupAvailable.SelectedTab.Text == "Cantrips")
            {
                TabGroupSelected.SelectTab(TabSelectedCantrips);
                if (ListSpellsAvailable0.SelectedItem != null)
                {
                    if (AvailableCantrips > 0)
                    {
                        AvailableCantrips--;
                        LblAvailableCantrips.Text = AvailableCantrips.ToString();
                        ListSelectedSpells0.Items.Add(ListSpellsAvailable0.SelectedItem);
                        ListSpellsAvailable0.Items.Remove(ListSpellsAvailable0.SelectedItem);
                        ListSelectedSpells0.ClearSelected();
                        ListSpellsAvailable0.ClearSelected();
                    }
                    else
                    {
                        MessageBox.Show("You can only select " + MaximumCantrips + " cantrips", "Too many cantrips");
                    }

                }
            }
            else if (TabGroupAvailable.SelectedTab.Text == "Level 1")
            {
                TabGroupSelected.SelectTab(TabSelectedLevel1);
                if (ListSpellsAvailable1.SelectedItem != null)
                {
                    if (AvailableLevel1 > 0)
                    {
                        AvailableLevel1--;
                        LblAvailableLevel1.Text = AvailableLevel1.ToString();
                        ListSelectedSpells1.Items.Add(ListSpellsAvailable1.SelectedItem);
                        ListSpellsAvailable1.Items.Remove(ListSpellsAvailable1.SelectedItem);
                        ListSelectedSpells1.ClearSelected();
                        ListSpellsAvailable1.ClearSelected();
                    }
                    else
                    {
                        MessageBox.Show("You can only select " + MaximumLevel1 + " level 1 spells", "Too many spells");
                    }
                }
            }
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            //EXCEPTIONS
            if (ThisToon.Class == "Cleric")
            {
                if (ThisToon.Domain == "Knowledge")
                {
                    if (ListSelectedSpells1.GetItemText(ListSelectedSpells1.SelectedItem) == "Command")
                    {
                        MessageBox.Show("This is a domain spell", "Cannot deselect spell");
                    }
                    else if (ListSelectedSpells1.GetItemText(ListSelectedSpells1.SelectedItem) == "Identify")
                    {
                        MessageBox.Show("This is a domain spell", "Cannot deselect spell");
                    }
                }
                else if (ThisToon.Domain == "Life")
                {

                }
                else if (ThisToon.Domain == "Light")
                {
                    if (ListSelectedSpells0.GetItemText(ListSelectedSpells1.SelectedItem) == "Light")
                    {
                        MessageBox.Show("This is a domain spell", "Cannot deselect spell");
                    }
                    else if (ListSelectedSpells1.GetItemText(ListSelectedSpells1.SelectedItem) == "Burning Hands")
                    {
                        MessageBox.Show("This is a domain spell", "Cannot deselect spell");
                    }
                    else if (ListSelectedSpells1.GetItemText(ListSelectedSpells1.SelectedItem) == "Faerie Fire")
                    {
                        MessageBox.Show("This is a domain spell", "Cannot deselect spell");
                    }
                }
            }

            else if (ThisToon.SubRace == "Dark Elf")
            {
                if (ListSelectedSpells0.GetItemText(ListSelectedSpells0.SelectedItem) == "Dancing Lights")
                {
                    MessageBox.Show("This is a racial spell", "Cannot deselect spell");
                }
            }

            else if (ThisToon.Race == "Tiefling")
            {
                if (ListSelectedSpells0.GetItemText(ListSelectedSpells0.SelectedItem) == "Thaumaturgy")
                {
                    MessageBox.Show("This is a racial spell", "Cannot deselect spell");
                }
            }

            else if (ThisToon.SubRace == "Forest Gnome")
            {
                if (ListSelectedSpells0.GetItemText(ListSelectedSpells0.SelectedItem) == "Minor Illusion")
                {
                    MessageBox.Show("This is a racial spell", "Cannot deselect spell");
                }
            }

            else
            {
                if (TabGroupSelected.SelectedTab.Text == "Cantrips")
                {
                    if (ListSelectedSpells0.SelectedItem != null)
                    {
                        AvailableCantrips++;
                        LblAvailableCantrips.Text = AvailableCantrips.ToString();
                        ListSpellsAvailable0.Items.Add(ListSelectedSpells0.SelectedItem);
                        ListSelectedSpells0.Items.Remove(ListSelectedSpells0.SelectedItem);
                    }
                }
                else if (TabGroupSelected.SelectedTab.Text == "Level 1")
                {
                    if (ListSelectedSpells1.SelectedItem != null)
                    {
                        AvailableLevel1++;
                        LblAvailableLevel1.Text = AvailableLevel1.ToString();
                        ListSpellsAvailable1.Items.Add(ListSelectedSpells1.SelectedItem);
                        ListSelectedSpells1.Items.Remove(ListSelectedSpells1.SelectedItem);
                    }
                }

            }
        }

        private void ListSpellsAvailable0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListSpellsAvailable0.SelectedItem != null)
            {
                ListSelectedSpells0.ClearSelected();
                ListSelectedSpells1.ClearSelected();
                ListSpellsAvailable1.ClearSelected();
                TxtDisplayInfo.Clear();
                TxtDisplayInfo.Text = AllSpells[ListSpellsAvailable0.GetItemText(ListSpellsAvailable0.SelectedItem)].GetSpellDesc();
            }
        }

        private void ListSpellsAvailable1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListSpellsAvailable1.SelectedItem != null)
            {
                ListSpellsAvailable0.ClearSelected();
                ListSelectedSpells0.ClearSelected();
                ListSelectedSpells1.ClearSelected();
                TxtDisplayInfo.Clear();
                TxtDisplayInfo.Text = AllSpells[ListSpellsAvailable1.GetItemText(ListSpellsAvailable1.SelectedItem)].GetSpellDesc();
            }
        }

        private void ListSelectedSpells0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListSelectedSpells0.SelectedItem != null)
            {
                ListSpellsAvailable0.ClearSelected();
                ListSpellsAvailable1.ClearSelected();
                ListSelectedSpells1.ClearSelected();
                TxtDisplayInfo.Clear();
                TxtDisplayInfo.Text = AllSpells[ListSelectedSpells0.GetItemText(ListSelectedSpells0.SelectedItem)].GetSpellDesc();
            }
        }

        private void ListSelectedSpells1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListSelectedSpells1.SelectedItem != null)
            {
                ListSpellsAvailable0.ClearSelected();
                ListSpellsAvailable1.ClearSelected();
                ListSelectedSpells0.ClearSelected();
                TxtDisplayInfo.Clear();
                TxtDisplayInfo.Text = AllSpells[ListSelectedSpells1.GetItemText(ListSelectedSpells1.SelectedItem)].GetSpellDesc();
            }
        }

        private List<string> GetSpellNames0()
        {
            List<string> SpellNames0 = new List<string>();
            List<Spell> SpellsAt0 = new List<Spell>();

            if (ThisToon.Spellbook.ContainsKey(0) == true)
            {
                SpellsAt0 = ThisToon.Spellbook[0];
            }
            else
            {
                Console.WriteLine("No cantrips found");
            }

            // THIS CAN PROBABLY GO INSIDE THE 'IF' STATEMENT ABOVE
            foreach (var thing in SpellsAt0)
            {
                SpellNames0.Add(thing.GetSpellName());
            }

            return SpellNames0;
        }

        private List<string> GetSpellNames1()
        {
            List<string> SpellNames1 = new List<string>();
            List<Spell> SpellsAt1 = new List<Spell>();

            if (ThisToon.Spellbook.ContainsKey(1) == true)
            {
                SpellsAt1 = ThisToon.Spellbook[1];
            }
            else
            {
                Console.WriteLine("No first level spells found");
            }

            foreach (var thing in SpellsAt1)
            {
                SpellNames1.Add(thing.GetSpellName());
            }

            return SpellNames1;
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            if (AvailableCantrips == 0 && AvailableLevel1 == 0)
            {
                this.Hide();
                FormNewToon CreationMenu = new FormNewToon(ThisToon);
                CreationMenu.Show();
            }
            else
            {
                MessageBox.Show("You must use all of your spell selections", "Not enough spells selected");
            }

            foreach (var item in ListSelectedSpells0.Items)
            {
                AllSpells[item.ToString()].AddToSpellbook(ThisToon);
            }
            foreach (var item in ListSelectedSpells1.Items)
            {
                AllSpells[item.ToString()].AddToSpellbook(ThisToon);
            }
        }

    }
}
