using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserMSTest
{
    public class MoodAnalyser
    {
        public MoodAnalyser()
        {

        }
        public string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {
                if (this.message.Contains("Sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch
            {
                return "Happy";
            }

        }
    }
}
