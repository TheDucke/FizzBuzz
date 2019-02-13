using FizzBuzz;

namespace FizzBuzz2
{
    public class FizzBuzz2 : FizzBuzz.FizzBuzz , IFizzBuzz
    {
        #region Methods

        protected override void LoadConditions()
        {
            Conditions.Add(new Condition("lucky", i => i.ToString().Contains("3")));
            base.LoadConditions();
        }

        #endregion Methods
    }
}