

namespace MoodAnalyserSpace
{
    public class MoodAnlyser
    {
        string message;
        public MoodAnlyser()
        {

        }
        public MoodAnlyser(string message)
        {
            this.message = message;
        }
        public string Analysemood()
        {
            try
            {
                if (message.Equals(string.Empty))
                    throw new MoodAnalyserCustomexception(MoodAnalyserCustomexception.ExceptionType.EMPTY_MOOD, "mood should not empty");
                else if (this.message.Contains("SAD"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
              
                return "HAPPY";
            }
        }
        static void Main(string[] args)
        {

        }
    }
}