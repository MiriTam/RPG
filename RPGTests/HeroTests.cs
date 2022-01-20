using System;
using Xunit;

namespace RPGTests
{
    public class HeroTests
    {
        [Fact]
        public void Hero_IsCreated_ShouldBeLevel1()
        {
            //Arrange
            RPG.Heroes.Mage mage = new RPG.Heroes.Mage("Tamara");
            int expectedLevel = 1;

            //Act
            int actualLevel = mage.Level;

            //Assert
            Assert.Equal(expectedLevel, actualLevel);
        }

        [Fact]
        public void LevelUp_Hero_ShouldBeLevel2()
        {
            //Arrange
            RPG.Heroes.Mage mage = new RPG.Heroes.Mage("Tamara");
            int expectedLevel = 2;
            
            //Act
            mage.LevelUp();
            int actualLevel = mage.Level;

            //Assert
            Assert.Equal(expectedLevel, actualLevel);
        }

        [Fact]
        public void Mage_UponCreation_HasCorrectAttributes()
        {
            //Arrange
            RPG.Heroes.Mage mage = new RPG.Heroes.Mage("Tamara");
            RPG.Primary expectedAttributes = new RPG.Primary();
            expectedAttributes.Strength = 1;
            expectedAttributes.Dexterity = 1;
            expectedAttributes.Intelligence = 8;

            //Act
            RPG.Primary actualAttributes = mage.PrimaryAttributes;

            //Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }

        [Fact]
        public void Ranger_UponCreation_HasCorrectAttributes()
        {
            //Arrange
            RPG.Heroes.Ranger ranger = new RPG.Heroes.Ranger("Tamara");
            RPG.Primary expectedAttributes = new RPG.Primary();
            expectedAttributes.Strength = 1;
            expectedAttributes.Dexterity = 7;
            expectedAttributes.Intelligence = 1;

            //Act
            RPG.Primary actualAttributes = ranger.PrimaryAttributes;

            //Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }

        [Fact]
        public void Rogue_UponCreation_HasCorrectAttributes()
        {
            //Arrange
            RPG.Heroes.Rogue rogue = new RPG.Heroes.Rogue("Tamara");
            RPG.Primary expectedAttributes = new RPG.Primary();
            expectedAttributes.Strength = 2;
            expectedAttributes.Dexterity = 6;
            expectedAttributes.Intelligence = 1;

            //Act
            RPG.Primary actualAttributes = rogue.PrimaryAttributes;

            //Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }

        [Fact]
        public void Warrior_UponCreation_HasCorrectAttributes()
        {
            //Arrange
            RPG.Heroes.Warrior warrior = new RPG.Heroes.Warrior("Tamara");
            RPG.Primary expectedAttributes = new RPG.Primary();
            expectedAttributes.Strength = 5;
            expectedAttributes.Dexterity = 2;
            expectedAttributes.Intelligence = 1;

            //Act
            RPG.Primary actualAttributes = warrior.PrimaryAttributes;

            //Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }

        [Fact]
        public void LevelUp_Mage_HasCorrectAttributes()
        {
            //Arrange
            RPG.Heroes.Mage mage = new RPG.Heroes.Mage("Tamara");
            RPG.Primary expectedAttributes = new RPG.Primary();
            expectedAttributes.Strength = 2;
            expectedAttributes.Dexterity = 2;
            expectedAttributes.Intelligence = 13;

            //Act
            mage.LevelUp();
            RPG.Primary actualAttributes = mage.PrimaryAttributes;

            //Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }

        [Fact]
        public void LevelUp_Ranger_HasCorrectAttributes()
        {
            //Arrange
            RPG.Heroes.Ranger ranger = new RPG.Heroes.Ranger("Tamara");
            RPG.Primary expectedAttributes = new RPG.Primary();
            expectedAttributes.Strength = 2;
            expectedAttributes.Dexterity = 12;
            expectedAttributes.Intelligence = 2;

            //Act
            ranger.LevelUp();
            RPG.Primary actualAttributes = ranger.PrimaryAttributes;

            //Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }

        [Fact]
        public void LevelUp_Rogue_HasCorrectAttributes()
        {
            //Arrange
            RPG.Heroes.Rogue rogue = new RPG.Heroes.Rogue("Tamara");
            RPG.Primary expectedAttributes = new RPG.Primary();
            expectedAttributes.Strength = 3;
            expectedAttributes.Dexterity = 10;
            expectedAttributes.Intelligence = 2;

            //Act
            rogue.LevelUp();
            RPG.Primary actualAttributes = rogue.PrimaryAttributes;

            //Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }

        [Fact]
        public void LevelUp_Warrior_HasCorrectAttributes()
        {
            //Arrange
            RPG.Heroes.Warrior warrior = new RPG.Heroes.Warrior("Tamara");
            RPG.Primary expectedAttributes = new RPG.Primary();
            expectedAttributes.Strength = 8;
            expectedAttributes.Dexterity = 4;
            expectedAttributes.Intelligence = 2;

            //Act
            warrior.LevelUp();
            RPG.Primary actualAttributes = warrior.PrimaryAttributes;

            //Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }
    }
}
