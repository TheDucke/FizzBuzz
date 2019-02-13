using System;

namespace FizzBuzz
{
    public sealed class Condition
    {
        #region Ctor

        public Condition(string text, Func<int, bool> isMatch, Func<int, string> function = null)
        {
            Text = text;
            IsMatch = isMatch;
            Function = function ?? delegate { return $"{ text } "; };
        }

        #endregion Ctor

        #region Properties

        public string Text { get; }

        public Func<int, bool> IsMatch { get; }

        public Func<int, string> Function { get; }

        #endregion Properties
    }
}