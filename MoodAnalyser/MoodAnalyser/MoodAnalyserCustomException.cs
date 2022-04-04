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
            EmptyMood,
            NullMood,
            NoSuchClass,
            NoSuchConstructor,
            NoSuchField,
        }

        public MoodAnalyserCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}