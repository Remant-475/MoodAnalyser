using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserSpace
{
    public class MoodAnalyserCustomexception : Exception
    {
        ExceptionType type;

        public enum ExceptionType
        {
            EMPTY_MOOD,
            EMPTY_NULL
        }
        public MoodAnalyserCustomexception(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

    }
}