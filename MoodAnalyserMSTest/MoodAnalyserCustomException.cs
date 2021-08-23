using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserMSTest
{
    public class MoodAnalyserCustomException : Exception
    {
        public enum ExceptionType
        {
            Null_Message, Empty_Message,
            No_Such_Field, No_Such_Method,
            No_Such_Class, Object_Creation_Issue
        }
        private readonly ExceptionType type;
        public MoodAnalyserCustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
