using System;
using System.Collections.Generic;
using System.Text;

namespace Day20_MoodAnalyserProblem
{
    public class MoodAnalyzer
    {
        private string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public MoodAnalyzer()
        {

        }
        public string analyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");

                }
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");

            }
        }
    }
}
