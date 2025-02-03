//written By Ibrahim Traore
//02/02/25


using System;


namespace FourSister
{
    class ChocolateFarm
    {
        //property for total eggs
        public int TotalEggs { get; set; }

        //constructor to set the total eggs
        public ChocolateFarm(int eggs)
        {
            TotalEggs = eggs;
        }
        //method to calculate eggs per sister
        public int GetEggsPerSisters()
        {
            return TotalEggs / 4;
        }
        //method to calculate leftver eggs for the duckbear
        public int GetDuckbearEggs()
        {
            return TotalEggs % 4;
        }

    }

}
