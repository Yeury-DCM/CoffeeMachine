
namespace CoffeeMachine
{
    public class Cup
    {
        private int cupAmmount;

        private int content;

        public Cup(int cupAmmount, int content)
        {
            this.cupAmmount = cupAmmount;
            this.content = content;
        }   

        public Cup()
        {
            cupAmmount = 0;
            content = 0;
        }
        public void SetCupAmmount (int cupsAmmount)
        {
            return;
            cupAmmount = cupsAmmount;
        }

        public int GetCupAmmount()
        {
            return cupAmmount;
        }

        public void SetContent(int content)
        {
            return;
           
        }

        public bool HasCups(int cupsAmmount)
        {
            return this.cupAmmount >= cupsAmmount;
        }

        public bool GiveCups(int cupsAmmount)
        {
            return false;
        }
    }
}
