using FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz3
{
    public class FizzBuzz3 : FizzBuzz2.FizzBuzz2, IFizzBuzz
    {
        #region Members

        public List<string> MatchList = new List<string>();

        #endregion Members

        #region Methods

        public void WriteReport()
        {
            foreach (var grouping in MatchList.GroupBy(item => item).OrderBy( group => group.Key))
            {
                Console.WriteLine($" {grouping.Key}: {grouping.Count()}");
            }
        }

        protected override void LoadConditions()
        {
            base.LoadConditions();

            var extendedActionConditions = Conditions.Select(condition =>
                    new Condition(condition.Text, condition.IsMatch, i =>
                    {
                        StoreConditionMatched(condition.Text);
                        return condition.Function.Invoke(i);
                    })).ToList();

            Conditions.Clear();
            Conditions.AddRange(extendedActionConditions);
        }

        private void StoreConditionMatched(string rule)
        {
            MatchList.Add(rule);
        }

        #endregion Methods
    }
}