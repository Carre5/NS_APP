using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSApp.Models
{
    public class HeroModel
    {
        public string Name { get; set; }
        public int AttributeValue { get; set; }
        public int SkillValue { get; set; }

        public HeroStats HeroStats { get; set; }
    }

    public class HeroStats
    {
        public int Dexterity { get; set; }
        public int Perception { get; set; }
        public int Charisma { get; set; }
        public int Cleverness { get; set; }
        public int Body { get; set; }


        public int Meele { get; set; }
        public int MeleeWeapons { get; set; }
        public int Throwing { get; set; }
        public int CarDriving { get; set; }
        public int MotorcycleDriving { get; set; }
        public int TruckDriving { get; set; }
        public int Pickpocketing { get; set; }
        public int OpeningLocks { get; set; }
        public int NimbleHands { get; set; }
        public int Handguns { get; set; }
        public int Rifles { get; set; }
        public int MachineGuns { get; set; }
        public int Bow{ get; set; }
        public int Crossbow{ get; set; }
        public int Slingshot { get; set; }
        public int DirectionSense { get; set; }
        public int TrapPreparation { get; set; }
        public int Tracking { get; set; }
        public int Hearing { get; set; }
        public int Seeing { get; set; }
        public int Alertness { get; set; }
        public int Sneaking { get; set; }
        public int Hiding { get; set; }
        public int Masquarade { get; set; }
        public int Hunting { get; set; }
        public int FieldKnowledge { get; set; }
        public int WaterGetting { get; set; }
        public int Bullying { get; set; }
        public int Persuation { get; set; }
        public int Leadership { get; set; }
        public int EmotionsAwareness { get; set; }
        public int Bluff { get; set; }
        public int AnimalCare { get; set; }
        public int PainResistance { get; set; }
        public int Niezlomnosc { get; set; }
        public int Morale { get; set; }
        public int FirstAid { get; set; }
        public int WoundHealing { get; set; }
        public int IlnessHealing { get; set; }
        public int Mechanics { get; set; }
        public int Electronics { get; set; }
        public int Computers { get; set; }
        public int Mathematics { get; set; }
        public int History { get; set; }
        public int Geography { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Biology { get; set; }
        public int Chirurgy { get; set; }
        public int Psychology { get; set; }
        public int HeavyMachinery { get; set; }
        public int CombatVehicles { get; set; }
        public int Boats { get; set; }
        public int Gunsmith { get; set; }
        public int Launchers { get; set; }
        public int Explosives { get; set; }
        public int Condition { get; set; }
        public int Swimming { get; set; }
        public int Climbing { get; set; }
        public int HorseRiding { get; set; }
        public int Powozenie { get; set; }
        public int Ujezdzanie { get; set; }
}
}
