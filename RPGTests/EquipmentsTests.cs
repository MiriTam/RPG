using System;
using Xunit;

namespace RPGTests
{
    public class EquipmentsTests
    {
        RPG.Heroes.Warrior testWarrior = new RPG.Heroes.Warrior("Tamara");

        RPG.Items.Weapon testAxe = new RPG.Items.Weapon(
        
            "Common axe",
            1,
            RPG.Slot.Weapon,
            RPG.Items.WeaponType.Axe,
            7,
            1.1
        );
        
        RPG.Items.Armour testPlateBody = new RPG.Items.Armour( 
        
            "Common plate body armour", 
            1, 
            RPG.Slot.Body, 
            RPG.Items.ArmourType.Plate, 
            new RPG.Primary { Strength = 1 }
        );

        RPG.Items.Weapon testBow = new RPG.Items.Weapon(
            "Common bow", 
            1, 
            RPG.Slot.Weapon, 
            RPG.Items.WeaponType.Bow, 
            12, 
            0.8
        );

        RPG.Items.Armour testClothHead = new RPG.Items.Armour(
            "Common cloth head armor", 
            1, 
            RPG.Slot.Head, 
            RPG.Items.ArmourType.Cloth, 
            new RPG.Primary() { Intelligence = 5 }
        );


        [Fact]
        public void EquipItem_WeaponAboveLevel_ShouldThrowException()
        {
            RPG.Heroes.Warrior warrior = testWarrior;
            RPG.Items.Weapon level2axe = testAxe;
            testAxe.LevelRequirement = 2;
            string expectedExceptionMessage = "Level too high!";

            Exception exception = Assert.Throws<RPG.InvalidWeaponException>(() => warrior.EquipItem(level2axe, RPG.Slot.Weapon));
            Assert.Equal(exception.Message, expectedExceptionMessage);
        }

        [Fact]
        public void EquipItem_ArmourAboveLevel_ShouldThrowException()
        {
            RPG.Heroes.Warrior warrior = testWarrior;
            RPG.Items.Armour level2plate = testPlateBody;
            level2plate.LevelRequirement = 2;
            string expectedExceptionMessage = "Level too high!";

            Exception exception = Assert.Throws<RPG.InvalidArmourException>(() => warrior.EquipItem(level2plate, RPG.Slot.Body));
            Assert.Equal(exception.Message, expectedExceptionMessage);
        }

        [Fact]
        public void EquipItem_WrongWeaponType_ShouldThrowException()
        {
            RPG.Heroes.Warrior warrior = testWarrior;
            RPG.Items.Weapon bow = testBow;
            string expectedExceptionMessage = "Wrong weapon type!";

            Exception exception = Assert.Throws<RPG.InvalidWeaponException>(() => warrior.EquipItem(bow, RPG.Slot.Weapon));
            Assert.Equal(exception.Message, expectedExceptionMessage);
        }

        [Fact]
        public void EquipItem_WrongArmourType_ShouldThrowException()
        {
            RPG.Heroes.Warrior warrior = testWarrior;
            RPG.Items.Armour cloth = testClothHead;
            string expectedExceptionMessage = "Wrong armour type!";

            Exception exception = Assert.Throws<RPG.InvalidArmourException>(() => warrior.EquipItem(cloth, RPG.Slot.Head));
            Assert.Equal(exception.Message, expectedExceptionMessage);
        }

        [Fact]
        public void EquipItem_ValidWeapon_ShouldReturnSucessMessage()
        {
            RPG.Heroes.Warrior warrior = testWarrior;
            RPG.Items.Weapon axe = testAxe;
            string message = warrior.EquipItem(axe, RPG.Slot.Weapon);
            string expectedMessage = "New weapon equiped!";

            Assert.Equal(message, expectedMessage);
        }

        [Fact]
        public void EquipItem_ValidArmour_ShouldReturnSuccessMessage()
        {
            RPG.Heroes.Warrior warrior = testWarrior;
            RPG.Items.Armour plate = testPlateBody;
            string message = warrior.EquipItem(plate, RPG.Slot.Body);
            string expectedMessage = "New armour equiped!";

            Assert.Equal(message, expectedMessage);
        }

        [Fact]
        public void Damage_NoWeapon_CorrectValue()
        {
            RPG.Heroes.Warrior warrior = testWarrior;
            double damage = warrior.Damage();
            double expectedDamage = 1 * (1 + (5 / 100));

            Assert.Equal(damage, expectedDamage);
        }

        [Fact]
        public void Damage_WithWeapon_CorrectValue()
        {
            RPG.Heroes.Warrior warrior = testWarrior;
            RPG.Items.Weapon axe = testAxe;
            warrior.EquipItem(axe, RPG.Slot.Weapon);
            double damage = warrior.Damage();
            double expectedDamage = (7 * 1.1) * (1 + (5 / 100));

            Assert.Equal(damage, expectedDamage);
        }

        [Fact]
        void Damage_WithWeaponAndArmour_CorrectValue()
        {
            RPG.Heroes.Warrior warrior = testWarrior;
            RPG.Items.Weapon axe = testAxe;
            RPG.Items.Armour plate = testPlateBody;
            warrior.EquipItem(axe, RPG.Slot.Weapon);
            warrior.EquipItem(plate, RPG.Slot.Body);
            double damage = warrior.Damage();
            double expectedDamage = (7 * 1.1) * (1 + ((5 + 1) / 100));

            Assert.Equal(damage, expectedDamage);
        }
    }
}
