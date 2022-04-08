using MoodAnalysers;
using MoodAnalyserSpace;
using NUnit.Framework;


namespace MoodAnalyserTesting
{
    public class Tests
    {
        MoodAnalyser moodAnalyser;
        MoodAnalyserFactory moodAnalyserFactory;
        [SetUp]
        public void Setup()
        {
            string result = "";
            //arrange
            moodAnalyser = new MoodAnalyser(result);
            moodAnalyserFactory = new MoodAnalyserFactory();
        }

        //<summary>
        // TC-1.1 Given "I am in Sad mood" message should return SAD using constructor
        //</summary>
        [Test]
        public void GivenMessage_ShouldReturnSad()
        {
            moodAnalyser = new MoodAnalyser("I am in SAD mood".ToLower());
            // act
            string message = moodAnalyser.AnalyseMood();
            // assert
            Assert.AreEqual("SAD", message);
        }
        //<summary>
        // TC-1.2 Given "I am in Any mood" message should return HAPPY using constructor
        //</summary>
        [Test]
        public void GivenMessage_ShouldReturnHappy()
        {
            moodAnalyser = new MoodAnalyser("I am in ANY Mood".ToLower());
            string message = moodAnalyser.AnalyseMood();
            Assert.AreEqual("HAPPY", message);
        }

        // <summary>
        // TC-2.1 Given Null Mood Should Return Happy
        // </summary>
        [Test]
        public void GivenMessage_WhenNull_ShouldReturnHappy()
        {
            moodAnalyser = new MoodAnalyser();
            //act
            string message = moodAnalyser.AnalyseMood();
            //assert
            Assert.AreEqual("HAPPY", message);
        }

        // <summary>
        // TC 3.2 Given Empty Mood Should ThrowMoodAnalysisException indicating Empty Mood
        // </summary>
        [Test]
        public void GivenMessage_WhenEmpty_CustomException()
        {
            string message = string.Empty;
            string expected = "Mood should not be Empty";
            try
            {
                //act
                moodAnalyser = new MoodAnalyser(message);
            }
            catch (MoodAnalyserCustomException exception)
            {   //assert
                Assert.AreEqual(expected, exception.Message);
            }
        }
        // <summary>
        // TC 3.1 Given Null Mood Should ThrowMoodAnalysisException
        // </summary>
        [Test]
        public void GivenMessage_WhenNull_CustomException()
        {
            string message = null;
            string expected = "Mood should not be Null";
            try
            {
                //act
                moodAnalyser = new MoodAnalyser(message);
            }
            catch (MoodAnalyserCustomException exception)
            {   //assert
                Assert.AreEqual(expected, exception.Message);
            }
        }

        // <summary>
        // Tc 4.1 Given MoodAnalyser Class Name Should Return MoodAnalyser Object
        // </summary>
        [Test]
        public void MoodAnalyserClass_NameShouldReturnMood_AnalyserObject()
        {    //act
            object expected = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserSpace.MoodAnalyser", "MoodAnalyser");
            //assert
            expected.Equals(obj);
        }

        // <summary>
        // TC 4.2 Given Class Name When Improper Should Throw MoodAnalysisException
        // </summary>
        [Test]
        public void MoodAnalyser_Improper_ClassNameShouldThrow_MoodAnalyserException()
        {    //act
            string expected = "Class not found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserSpace.Mood", "Mood");
            }
            catch (MoodAnalyserCustomException exception)
            {   //assert
                Assert.AreEqual(expected, exception.Message);
            }
        }
        // <summary>
        // TC 4.3 Given Class When Improper Constructor name Should Throw MoodAnalysisException
        // </summary>
        [Test]
        public void MoodAnalyser_Improper_ConstructorName_ShoulThrow_MoodAnalyserException()
        {    //act
            string expected = "Constructor not found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserSpace.MoodAnalyser", "AnalyserMood");
            }
            catch (MoodAnalyserCustomException exception)
            {   //assert
                Assert.AreEqual(expected, exception.Message);
            }
        }
        /// <summary>
        /// TC 5.1 - Given MoodAnalyser When Proper Return MoodAnalyser Object
        /// </summary>
        [Test]
        public void MoodAnalyser_WhenProperReturnMoodAnalyserObject()
        {
            object expected = new MoodAnalyser("Happy");
            object obj = MoodAnalyserFactory.CreateMoodAnalyserParameterisedConstructor("MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        /// <summary>
        /// TC 5.2 - Given Class Name When Improper Should Throw MoodAnalysisException
        /// </summary>
        [Test]
        public void MoodAnalyser_When_ImproperClassName_ShouldThrowMoodAnalysisException()
        {
            string expected = "Class not found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyserParameterisedConstructor("ImproperClassname", "MoodAnalyser");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// TC 5.3 - Given Class When Constructor Not Proper Should Throw MoodAnalysisException
        /// </summary>
        [Test]
        public void MoodAnalyser_When_ImproperConstructorName_ShouldThrowMoodAnalysisException()
        {
            string expected = "Constructor not found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyserParameterisedConstructor("MoodAnalyser", "MoodAnalysersss");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
        /// <summary>
        /// TC - 6.1 -Given Happy Message Using Reflector when Proper Should Return HAPPY Mood
        /// </summary>
        [Test]
        public void GiveHappyMessageUsingReflectionReturnHappy()
        {
            string result = MoodAnalyserFactory.InvokeAnalyseMood("HAPPY", "AnalyseMood");
            Assert.AreEqual("HAPPY", result);
        }
        /// <summary>
        /// TC 6.2 - Given Happy Message using Reflector When Improper Method Should Throw Exception.
        /// </summary>
        [Test]
        public void GivenHappyWhenImproperThrowMoodAnalysisException()
        {
            try
            {
                string result = MoodAnalyserFactory.InvokeAnalyseMood("HAPPY", "AnalyseMoods");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual("Constructor not found", exception.Message);
            }
        }
    }
}