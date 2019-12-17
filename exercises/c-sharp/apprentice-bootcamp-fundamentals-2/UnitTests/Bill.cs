using System;

namespace apprentice_bootcamp_fundamentals_2
{
    public class Bill
    {

        public int CalculateBill(bool isDealer, int adverts, int products)
        {
            int rate = 20;

            if(isDealer)
            {
                rate = 50;
            }
            return adverts * (10 * products + rate) ;
        }
    }
}