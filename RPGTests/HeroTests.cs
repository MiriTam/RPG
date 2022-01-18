using System;
using Xunit;

namespace RPGTests
{
    public class HeroTests
    {
        [Fact]
        public void Hero_IsCreated_ShouldBeLevel1()
        {
            RPG.Heroes.Mage mage = new RPG.Heroes.Mage("Tamara");
            int level = mage.Level;
            int expectedLevel = 1;
            Assert.Equal(expectedLevel, level);
        }

        [Fact]
        public void LevelUp_Hero_ShouldBeLevel2()
        {
            RPG.Heroes.Mage mage = new RPG.Heroes.Mage("Tamara");
            mage.LevelUp();
            int level = mage.Level;
            int expectedLevel = 2;
            Assert.Equal(level, expectedLevel);
        }

        [Fact]
        public void Mage_UponCreation_HasCorrectAttributes()
        {
            RPG.Heroes.Mage mage = new RPG.Heroes.Mage("Tamara");
            int strength = mage.PrimaryAttributes.Strength;
            int expectedStrength = 1;
            int dexterity = mage.PrimaryAttributes.Dexterity;
            int expectedDexterity = 1;
            int intelligence = mage.PrimaryAttributes.Intelligence;
            int expectedIntelligence = 8;

            Assert.Equal(strength, expectedStrength);
            Assert.Equal(dexterity, expectedDexterity);
            Assert.Equal(intelligence, expectedIntelligence);
        }

        [Fact]
        public void Ranger_UponCreation_HasCorrectAttributes()
        {
            RPG.Heroes.Ranger ranger = new RPG.Heroes.Ranger("Tamara");
            int strength = ranger.PrimaryAttributes.Strength;
            int expectedStrength = 1;
            int dexterity = ranger.PrimaryAttributes.Dexterity;
            int expectedDexterity = 7;
            int intelligence = ranger.PrimaryAttributes.Intelligence;
            int expectedIntelligence = 1;

            Assert.Equal(strength, expectedStrength);
            Assert.Equal(dexterity, expectedDexterity);
            Assert.Equal(intelligence, expectedIntelligence);
        }

        [Fact]
        public void Rogue_UponCreation_HasCorrectAttributes()
        {
            RPG.Heroes.Rogue rogue = new RPG.Heroes.Rogue("Tamara");
            int strength = rogue.PrimaryAttributes.Strength;
            int expectedStrength = 2;
            int dexterity = rogue.PrimaryAttributes.Dexterity;
            int expectedDexterity = 6;
            int intelligence = rogue.PrimaryAttributes.Intelligence;
            int expectedIntelligence = 1;

            Assert.Equal(strength, expectedStrength);
            Assert.Equal(dexterity, expectedDexterity);
            Assert.Equal(intelligence, expectedIntelligence);
        }

        [Fact]
        public void Warrior_UponCreation_HasCorrectAttributes()
        {
            RPG.Heroes.Warrior warrior = new RPG.Heroes.Warrior("Tamara");
            int strength = warrior.PrimaryAttributes.Strength;
            int expectedStrength = 5;
            int dexterity = warrior.PrimaryAttributes.Dexterity;
            int expectedDexterity = 2;
            int intelligence = warrior.PrimaryAttributes.Intelligence;
            int expectedIntelligence = 1;

            Assert.Equal(strength, expectedStrength);
            Assert.Equal(dexterity , expectedDexterity);
            Assert.Equal(intelligence, expectedIntelligence);
        }

        [Fact]
        public void LevelUp_Mage_HasCorrectAttributes()
        {
            RPG.Heroes.Mage mage = new RPG.Heroes.Mage("Tamara");
            mage.LevelUp();
            int strength = mage.PrimaryAttributes.Strength;
            int expectedStrength = 2;
            int dexterity = mage.PrimaryAttributes.Dexterity;
            int expectedDexterity = 2;
            int intelligence = mage.PrimaryAttributes.Intelligence;
            int expectedIntelligence = 13;

            Assert.Equal(strength, expectedStrength);
            Assert.Equal(dexterity, expectedDexterity);
            Assert.Equal(intelligence, expectedIntelligence);
        }

        [Fact]
        public void LevelUp_Ranger_HasCorrectAttributes()
        {
            RPG.Heroes.Ranger ranger = new RPG.Heroes.Ranger("Tamara");
            ranger.LevelUp();
            int strength = ranger.PrimaryAttributes.Strength;
            int expectedStrength = 2;
            int dexterity = ranger.PrimaryAttributes.Dexterity;
            int expectedDexterity = 12;
            int intelligence = ranger.PrimaryAttributes.Intelligence;
            int expectedIntelligence = 2;

            Assert.Equal(strength, expectedStrength);
            Assert.Equal(dexterity, expectedDexterity);
            Assert.Equal(intelligence, expectedIntelligence);
        }

        [Fact]
        public void LevelUp_Rogue_HasCorrectAttributes()
        {
            RPG.Heroes.Rogue rogue = new RPG.Heroes.Rogue("Tamara");
            rogue.LevelUp();
            int strength = rogue.PrimaryAttributes.Strength;
            int expectedStrength = 3;
            int dexterity = rogue.PrimaryAttributes.Dexterity;
            int expectedDexterity = 10;
            int intelligence = rogue.PrimaryAttributes.Intelligence;
            int expectedIntelligence = 2;

            Assert.Equal(strength, expectedStrength);
            Assert.Equal(dexterity, expectedDexterity);
            Assert.Equal(intelligence, expectedIntelligence);
        }

        [Fact]
        public void LevelUp_Warrior_HasCorrectAttributes()
        {
            RPG.Heroes.Warrior warrior = new RPG.Heroes.Warrior("Tamara");
            warrior.LevelUp();
            int strength = warrior.PrimaryAttributes.Strength;
            int expectedStrength = 8;
            int dexterity = warrior.PrimaryAttributes.Dexterity;
            int expectedDexterity = 4;
            int intelligence = warrior.PrimaryAttributes.Intelligence;
            int expectedIntelligence = 2;

            Assert.Equal(strength, expectedStrength);
            Assert.Equal(dexterity, expectedDexterity);
            Assert.Equal(intelligence, expectedIntelligence);
        }
    }
}
