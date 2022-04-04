using MoodAnalyserSpace;
using NUnit.Framework;

namespace MoodAnalyserTesting
{
    public class Tests
    {
        MoodAnlyser moodAnlyser;
        [SetUp]
        public void Setup()
        {
            string result = "";
            //arrange
            moodAnlyser = new MoodAnlyser(result);
        }
        //summary//Refactor
        // TC-1.1 Given "I am in Sad mood" message should return SAD//

        [Test]
        public void Give_Message_when_ShouldReturnSad()
        {
            moodAnlyser = new MoodAnlyser("I am in a SAD mood");
            //act
            string message = moodAnlyser.Analysemood();

            //assert
            Assert.AreEqual("SAD", message);
        }
        //summary//Refactor
        /// TC-1.2 Given "I am in Any mood" message should return HAPPY//
        [Test]
        public void Give_Message_When_ShouldReturnHappy()
        {
            moodAnlyser = new MoodAnlyser("I am in ANY mood");
            //act
            string message = moodAnlyser.Analysemood();
            //assert
            Assert.AreEqual("HAPPY", message);
        }

        //summary//Handling null exception//
        //TC-2.1 and TC-3.1 given null mood should return Happy//
        [Test]
        public void Give_msg_WhenNull_ShouldReturnHappy()
        {
            moodAnlyser = new MoodAnlyser();
            //act
            string message = moodAnlyser.Analysemood();
            //assert
            Assert.AreEqual("HAPPY", message);
        }
        [Test]
        public void Give_Message_WhenNull_ShouldReturnHappy()
        {
            moodAnlyser = new MoodAnlyser();
            //act
            string message = moodAnlyser.Analysemood();
            //assert
            Assert.AreEqual("HAPPY", message);
        }
        //customexception
        //TC-3.2 Given Empty Mood
        //Should ThrowMoodAnalys is Exception indicating Empty Mood
        [Test]
        public void give_msg_When_EmptyCustomexception()
        {    //arrange
            string message = "";
            string expected = "mood should not empty";
            try
            {
                //act
                moodAnlyser = new MoodAnlyser(message);
            }
            catch (MoodAnalyserCustomexception exception)
            {
                //assert
                Assert.AreEqual(expected, exception.Message);
            }
        }




    }
}
