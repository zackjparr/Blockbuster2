using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Blockbuster
{
    public class QATesting
    {
        [Theory]
        [InlineData(0, "Dom gets the Family together")]
        [InlineData(1, "Dom buys the Family a nice dinner")]
        [InlineData(2, "The Rock steals the dinner")]
        [InlineData(3, "Dom and The Rock fight")]
        [InlineData(4, "Dom and The Rock make peace and eat together")]
        public void TestDVDScenesConstructor(int index, string expected)
        {
            //Arrange
            List<string> DVDScenes1 = new List<string>();
            DVDScenes1.Add("Dom gets the Family together");
            DVDScenes1.Add("Dom buys the Family a nice dinner");
            DVDScenes1.Add("The Rock steals the dinner");
            DVDScenes1.Add("Dom and The Rock fight");
            DVDScenes1.Add("Dom and The Rock make peace and eat together");
            DVD d = new DVD("Fast & Furious 10: Family", "Action", 300, DVDScenes1);

            //Act
            string actual = d.Scenes[index];

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, "Freddy Kreuger looks to broaden his stock portfolio")]
        [InlineData(1, "He invests all his assests into $AMC and $GME")]
        [InlineData(2, "Freddy Kreuger waits as he has diamond hands")]
        [InlineData(3, "He still holds.")]
        [InlineData(4, "Still holding.")]
        public void TestVHSScenesConstructor(int index, string expected)
        {
            //Arrange
            List<string> VHSScenes3 = new List<string>();
            VHSScenes3.Add("Freddy Kreuger looks to broaden his stock portfolio");
            VHSScenes3.Add("He invests all his assests into $AMC and $GME");
            VHSScenes3.Add("Freddy Kreuger waits as he has diamond hands");
            VHSScenes3.Add("He still holds.");
            VHSScenes3.Add("Still holding.");
            VHS d = new VHS("Nightmare on Wall Street", "Drama", 300, VHSScenes3, 0);

            //Act
            string actual = d.Scenes[index];

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestBlockBusterConstructor()
        {
            //Arrange
            BlockbusterDB blockBuster = new BlockbusterDB();

            //Act
            int actual = blockBuster.Movies.Count;

            //Assert
            Assert.Equal(6, actual);
        }
    }
}
