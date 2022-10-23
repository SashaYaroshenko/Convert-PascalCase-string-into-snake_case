namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class Tests
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual("test_controller", Kata.ToUnderscore("TestController"));
            Assert.AreEqual("this_is_beautiful_day", Kata.ToUnderscore("ThisIsBeautifulDay"));
            Assert.AreEqual("am7_days", Kata.ToUnderscore("Am7Days"));
            Assert.AreEqual("my3_code_is4_times_better", Kata.ToUnderscore("My3CodeIs4TimesBetter"));
            Assert.AreEqual("arbitrarily_sending_different_types_to_functions_makes_katas_cool", Kata.ToUnderscore("ArbitrarilySendingDifferentTypesToFunctionsMakesKatasCool"));
            Assert.AreEqual("1", Kata.ToUnderscore(1), "Numbers should be turned to strings!");
        }
    }
}