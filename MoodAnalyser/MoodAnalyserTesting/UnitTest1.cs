using MoodAnalyserSpace;
using NUnit.Framework;

namespace MoodAnalyserTesting
{
    public class Tests
    {
        MoodAnlyser moodAnlyser;
        [SetUp]
        public void Setup()
        {   //arrange
            moodAnlyser = new MoodAnlyser();
        }
        //summary//
        // TC-1.1 Given "I am in Sad mood" message should return SAD//

        [Test]
        public void Give_Message_when_ShouldReturnSad()
        {  //act
            string message = moodAnlyser.Analysemood("I am in SAD mood");

            //assert
            Assert.AreEqual("SAD", message);
        }


        ///</summary>
        /// TC-1.2 Given "I am in Any mood" message should return HAPPY//
        [Test]
        public void Give_Message_When_SouldReturnHappy()
        {
            //act
            string message = moodAnlyser.Analysemood("I am in ANY mood");
            //assert
            Assert.AreEqual("HAPPY", message);
        }
    }
}