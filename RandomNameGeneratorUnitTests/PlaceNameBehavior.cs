﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomNameGeneratorLibrary;

namespace RandomNameGeneratorUnitTests
{
    [TestClass]
    public class PlaceNameBehavior
    {
        private PlaceNameGenerator _placeGenerator;

        [TestInitialize]
        public void Setup()
        {
            _placeGenerator = new PlaceNameGenerator();
        }

        [TestMethod]
        public void ShouldGenerateRandomName()
        {
            var name = _placeGenerator.GenerateRandomPlaceName();

            Assert.IsFalse(string.IsNullOrWhiteSpace(name));
        }

        [TestMethod]
        public void ShouldGenerateSameNameIfSameRandomGenerator()
        {
            var personNameGenerator1 = new PersonNameGenerator(new Random(42));
            var personNameGenerator2 = new PersonNameGenerator(new Random(42));

            var firstName = personNameGenerator1.GenerateRandomFirstAndLastName();
            var secondName = personNameGenerator2.GenerateRandomFirstAndLastName();

            Assert.AreEqual(firstName, secondName);
        }
    }
}