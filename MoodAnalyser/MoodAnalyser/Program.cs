namespace MoodAnalyserSpace
{
    public class MoodAnlyser
    {
        public string Analysemood(string message)
        {
            if (message.Contains("SAD"))
                return "SAD";
            else return "HAPPY";
        }
        static void Main(string[] args)
        {

        }
    }
}