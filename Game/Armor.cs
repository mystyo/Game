﻿namespace Game
{
    public class Armor : EquipableArmor
    {
        public override int ArmorValue { get; set; }
        public override string Name { get; set; }
        public override int Id { get; set; }
        private static int _id = 0;
        public override int Weight { get; set; }
        public override int StrengthBonus { get; set; }
        public override GearSlotType SlotType { get; set; }

        public Armor(string name, int weight, int armorValue, GearSlotType gearSlotType, int strengthBonus = 0)
        {
            Name = name;
            Id = _id + 1;
            _id += 1;
            Weight = weight;
            ArmorValue = armorValue;
            StrengthBonus = strengthBonus;
            SlotType = gearSlotType;
        }

        public override void UseItem(Character character)
        {
            
        }
    }
}
