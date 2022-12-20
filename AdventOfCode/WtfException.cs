using System;

namespace AdventOfCode
{
    public class WtfException : Exception
    {
        public WtfException() : base("wtf")
        {

        }
        
        public WtfException(string message) : base("wtf: " + message)
        {

        }
    }
}