using System;
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
