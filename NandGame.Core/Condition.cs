namespace NandGame.Core
{
    public class Condition
    {
        public Condition(bool lessThanZero, bool equalToZero, bool greaterThanZero)
        {
            LessThanZero = lessThanZero;
            EqualToZero = equalToZero;
            GreaterThanZero = greaterThanZero;
        }

        public bool LessThanZero { get; set; }

        public bool EqualToZero { get; set; }

        public bool GreaterThanZero { get; set; }
    }
}