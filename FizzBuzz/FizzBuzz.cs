using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz : IFizzBuzz
    {
        #region Members

        protected readonly List<Condition> Conditions = new List<Condition>();

        #endregion Members

        #region Ctor

        public FizzBuzz()
        {
            Initialize();
        }

        #endregion Ctor

        #region Methods

        public string ExecuteFizzBuzz(string[] args)
        {
            return EvaluateParameters(args, out var lowerBound, out var upperBound)
                ? ProcessIntRange(lowerBound, upperBound)
                : throw new ArgumentException("Invalid Input.");
        }

        protected virtual void LoadConditions()
        {
            Conditions.Add(new Condition("fizzbuzz", i => i % 15 == 0));
            Conditions.Add(new Condition("buzz", i => i % 5 == 0));
            Conditions.Add(new Condition("fizz", i => i % 3 == 0));
            Conditions.Add(new Condition("integer", i => true, i => $"{ i } "));
        }

        private bool EvaluateParameters(string[] args, out int lowerBound, out int upperBound)
        {
            lowerBound = 0;
            upperBound = 0;
            var valid = false;

            if (args != null
                && args.Length == 2
                && int.TryParse(args[0], out var lb)
                && int.TryParse(args[1], out var ub)
                && lb < ub
                && lb > 0)
            {
                lowerBound = lb;
                upperBound = ub;
                valid = true;
            }

            return valid;
        }

        private string ProcessIntRange(int lowerBound, int upperBound)
        {
            var sb = new StringBuilder();

            for (var i = lowerBound; i <= upperBound; i++)
            {
                if (Conditions.Any(pair => pair.IsMatch(i)))
                    sb.Append(Conditions.First(pair => pair.IsMatch(i)).Function.Invoke(i));
            }

            return sb.ToString();
        }

        private void Initialize()
        {
            LoadConditions();
        }

        #endregion Methods
    }
}