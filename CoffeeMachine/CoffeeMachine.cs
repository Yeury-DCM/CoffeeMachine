
namespace CoffeeMachine
{
    public class CoffeeMachine
    {
        private CoffeeMaker coffee;
        private Cup smallCup;
        private Cup mediumCup;
        private Cup bigCup;
        private SugarBowl sugar;

        public Cup GetCupType(string cupType)
        {
            //switch (cupType.ToLower())
            //{
            //    case "small":
            //        return smallCup;
            //    case "medium":
            //        return mediumCup;
            //    case "big":
            //        return bigCup;
            //    default:
            //        throw new ArgumentException("Invalid cup type");
            //}
            return new Cup();
        }

        public Cup GetCoffeeCup(string cupType, int cupAmmount, int sugarAmmount)
        {
            return new();
        }
    }
}
