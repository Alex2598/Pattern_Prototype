using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Legacy;
using Pattern_Prototype.Classes;
using Pattern_Prototype.Interfaces;
namespace Pattern_Prototype.Tests
{
    [TestClass]
    public class CloneTests
    {
        [TestMethod]
        public void PetCloneTest()
        {
            var pet = new Pet("Buddy", "John");
            var clone = (Pet)pet.Clone();

            Assert.AreNotSame(pet, clone);
            Assert.AreEqual(pet.Name, clone.Name);
            Assert.AreEqual(pet.Owner, clone.Owner);
        }

        [TestMethod]
        public void WildAnimalCloneTest()
        {
            var wildAnimal = new WildAnimal("Lion", "Savanna");
            var clone = (WildAnimal)wildAnimal.Clone();

            Assert.AreNotSame(wildAnimal, clone);
            Assert.AreEqual(wildAnimal.Name, clone.Name);
            Assert.AreEqual(wildAnimal.Habitat, clone.Habitat);
        }

        [TestMethod]
        public void HomePetCloneTest()
        {
            var homePet = new HomePet("Whiskers", "Jane", true);
            var clone = (HomePet)homePet.Clone();

            Assert.AreNotSame(homePet, clone);
            Assert.AreEqual(homePet.Name, clone.Name);
            Assert.AreEqual(homePet.Owner, clone.Owner);
            Assert.AreEqual(homePet.IsHousebroken, clone.IsHousebroken);
        }
    }
}