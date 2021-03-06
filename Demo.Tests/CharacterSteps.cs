﻿using System;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Demo.Tests
{
    [Binding]
    public class CharacterSteps
    {

        private Character _player;

        [Given(@"I'm a new player")]
        public void GivenImANewPlayer()
        {
            _player = new Character();
        }

        [Given(@"I have a damage resistance of (.*)")]
        public void GivenIHaveADamageResistanceOf(int resistence)
        {
            _player.DamageResistance = resistence;
        }

        [Given(@"I'm an Elf")]
        public void GivenImAnElf()
        {
            _player.Race = "Elf";
        }

        [Given(@"I have the following attributes")]
        public void GivenIHaveTheFollowingAttributes(Table table)
        {
            var race = table.Rows.First(row => row["attribute"] == "Race")["value"];
            var resistance = table.Rows.First(row => row["attribute"] == "Resistance")["value"];

            _player.Race = race;
            _player.DamageResistance = int.Parse(resistance);
        }

        [When(@"I take (.*) damage")]
        public void WhenITakeDamage(int damage)
        {
            _player.Hit(damage);
        }
        
        [Then(@"My health should now be (.*)")]
        public void ThenMyHealthShouldNowBe(int expectedHealth)
        {
            Assert.AreEqual(expectedHealth, _player.Health);
        }
        
        [Then(@"I should be dead")]
        public void ThenIShouldBeDead()
        {
            Assert.IsTrue(_player.IsDead);
        }
    }
}
