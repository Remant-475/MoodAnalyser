using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalysers
{
    public class MoodAnalyserCustomException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            Empty_Mood,
            Null_Mood,
            No_Such_Class,
            No_Such_Constructor,
            No_Such_Field,
        }

        public MoodAnalyserCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}