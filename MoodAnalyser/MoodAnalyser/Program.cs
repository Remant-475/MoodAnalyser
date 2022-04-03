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
                if (message.Contains("SAD"))
                    return "SAD";
                else return "HAPPY";
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