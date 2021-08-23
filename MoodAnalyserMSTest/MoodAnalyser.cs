using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserMSTest
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            //try
            //{
            //    if (this.message.Contains("Sad"))
            //        return "SAD";
            //    else
            //        return "HAPPY";
            //}
            //catch
            //{
            //    return "Happy";
            //}
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.Empty_Message, "Mood should not be Empty");
                }
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {

                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.Null_Message, "Mood should not be null");
            }
        }
    }
}
