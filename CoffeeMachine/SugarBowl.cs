using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public  class SugarBowl
    {
       private int sugarAmmount;
        public void SetSugarAmmount(int sugarAmmount)
        {
            return;
          //  this.sugarAmmount = sugarAmmount;
        }
        public int GetSugarAmmount()
        {
            return 0;
           // return sugarAmmount;
        }
        public bool HasSugar(int sugarAmmount)
        {
            return false;
           // return this.sugarAmmount >= sugarAmmount;
        }
        public int GiveSugar(int sugarAmmount)
        {
            return 0;
            //if (HasSugar(sugarAmmount))
            //{
            //    sugarAmmount -= sugarAmmount;
            //    return sugarAmmount;
            //}
            //return 0;
        }
    }
}
