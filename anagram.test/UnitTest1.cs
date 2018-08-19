using System;
using anagram;
using Xunit;

namespace anagram.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var anagram = new Aangram();
            string[] list = new string[] { "a", "b", "d" };
            Assert.True(anagram.checkAnagram(list, "bad"));
            list = new string[] { "a", "b", "c", "d", "e" };
            Assert.False(anagram.checkAnagram(list, "bat"));
            list = new string[] { "a", "b", "c", "d", "e", "f", "g" };
            Assert.False(anagram.checkAnagram(list, "cabbage"));
            list = new string[] { "a", "b", "c", "d", "e", "f", "g", "a", "b" };
            Assert.False(anagram.checkAnagram(list, "cabbage"));
        }
    }
}
