// written by Ibrahim Traore
// 02/06/2025

using System;

class Inventory
{
    public int GetItemPrice(int itemNumber)
    {
        if (itemNumber == 1) return 10;
        else if (itemNumber == 2) return 15;
        else if (itemNumber == 3) return 25;
        else if (itemNumber == 4) return 1;
        else if (itemNumber == 5) return 20;
        else if (itemNumber == 6) return 200;
        else if (itemNumber == 7) return 1;
        else return -1;
    }
}
