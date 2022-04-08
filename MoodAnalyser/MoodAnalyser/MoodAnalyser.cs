using MoodAnalysers;
using System;
namespace MoodAnalyserSpace
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser()
        {

        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {
                if (message.Equals(string.Empty))
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.Empty_Mood, "Mood should not be Empty");
                else if (message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                //throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NullMood, "Mood should not be Null");
                return "HAPPY";
            }
        }

    }
}